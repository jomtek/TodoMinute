using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using TodoMinute.Task;
using System.Drawing.Text;

namespace TodoMinute.Theme
{
    public class TodoTask : ContainerControl
    {
        private bool _hovered = false;

        private TaskDescription _desc;

        private TodoHoverableButtonImage _stickyNote;
        private TodoCheckBox _checkBox;
        
        private ToolTip _helpTT;
        private ContextMenuStrip _contextMenuStrip;

        #region Settings
        public TaskDescription TDescription
        {
            get { return _desc; }
            set
            {
                _desc = value;
                Refresh();
            }
        }
        #endregion

        public TodoTask(TaskDescription desc)
        {
            DoubleBuffered = true;
            _desc = desc;
        }

        private void DescriptionChanged()
        {
            _stickyNote.Visible = _desc.Description.Length > 0;
            _helpTT.SetToolTip(_stickyNote, _desc.Description);
        }

        private void InitControls()
        {
            // visible controls
            _stickyNote = new TodoHoverableButtonImage()
            {
                Image_Normal = Properties.Resources.sticky_note_normal,
                Image_Hovered = Properties.Resources.sticky_note_hovered,
                Location = new Point(191, 0),
                Size = new Size(31, 36)
            };

            _checkBox = new TodoCheckBox()
            {
                Location = new Point(321, 0),
                Size = new Size(31, 36),
                Checked = _desc.Done
            };

            // help/on-click controls
            _helpTT = new ToolTip()
            {
                AutoPopDelay = 60000,
                ToolTipIcon = ToolTipIcon.Info
            };

            DescriptionChanged();

            _contextMenuStrip = new ContextMenuStrip();
            _contextMenuStrip.Items.Add("Modifier");
            _contextMenuStrip.Items.Add("Supprimer");

            _contextMenuStrip.ItemClicked += (object sender, ToolStripItemClickedEventArgs e) =>
            {
                switch (e.ClickedItem.Text)
                {
                    case "Modifier":
                        using (var form = new EditTaskForm(_desc))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                _desc.Title = form.NewTitle;
                                _desc.Description = form.NewDescription;
                                DescriptionChanged();
                                Refresh();
                            }
                        }
                        break;
                    case "Supprimer":
                        var parent = (PlanningPanel)Parent;
                        parent.RemoveTask(this);
                        break;
                }
            };

            // events
            _checkBox.Click += (object sender, EventArgs e) =>
            {
                _desc.Done = !_desc.Done;
                Refresh();
            };

            // // //

            Controls.AddRange(new Control[]
            {
                _stickyNote,
                _checkBox
            });

            ContextMenuStrip = _contextMenuStrip;
        }

        #region Events
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _hovered = true;
            Refresh();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hovered = false;
            Refresh();
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            // base
            e.Graphics.FillRectangle(
                new SolidBrush(Color.FromArgb(45, Color.SlateGray)),
                ClientRectangle
            );

            // text
            var textRegion = new Rectangle(new Point(5, 0), new Size(180, Height));
            using (var sf = new StringFormat() { LineAlignment = StringAlignment.Center })
            {
                e.Graphics.DrawString(_desc.Title, new Font("Segoe UI", 13f, FontStyle.Bold), new SolidBrush(Color.Black), textRegion, sf);
            }

            var taskStatusFont = new Font("Sitka Text", 15f, FontStyle.Underline);
            var taskStatusText = _desc.Done ? "fait" : "à faire";
            var taskStatusWidth = Size.Round(e.Graphics.MeasureString(taskStatusText, taskStatusFont)).Width;
            var taskStatusRegion = new Rectangle(new Point(321 - 6 - taskStatusWidth, 5), new Size(taskStatusWidth, Height));

            using (var sf = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center })
            {
                e.Graphics.DrawString(taskStatusText, taskStatusFont, new SolidBrush(Color.Gray), taskStatusRegion, sf);
            }

            // hovered bar
            if (_hovered)
            {
                e.Graphics.DrawLine(new Pen(Color.Green, 3f), new Point(0, Height), new Point(Width, Height));
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(360, 36);
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            InitControls();
        }
    }
}
