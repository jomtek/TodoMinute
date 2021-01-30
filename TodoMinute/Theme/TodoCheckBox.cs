using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace TodoMinute.Theme
{
    class TodoCheckBox : Control
    {
        private bool _checked = false;

        private bool _hovered = false;

        #region Settings
        [Category("Todo")]
        public bool Checked
        {
            get { return _checked; }
            set
            {
                _checked = value;
                Refresh();
            }
        }
        #endregion

        public TodoCheckBox()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
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

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _checked = !_checked;
            Refresh();
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_checked)
            {
                if (_hovered)
                {
                    e.Graphics.DrawImage(Properties.Resources.check_square_hovered, ClientRectangle);
                }
                else
                {
                    e.Graphics.DrawImage(Properties.Resources.check_square_normal, ClientRectangle);
                }
            }
            else
            {
                if (_hovered)
                {
                    e.Graphics.DrawImage(Properties.Resources.square_hovered, ClientRectangle);
                }
                else
                {
                    e.Graphics.DrawImage(Properties.Resources.square_normal, ClientRectangle);
                }
            }
        }
    }
}
