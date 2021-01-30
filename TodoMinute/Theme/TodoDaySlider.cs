using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoMinute.Theme
{
    class TodoDaySlider : Control
    {
        private int _daysFromToday = 0;

        private bool _lBtnHovered = false;
        private bool _rBtnHovered = false;

        private Rectangle _lBtnRegion;
        private Rectangle _rBtnRegion;

        [Category("Todo")]
        public event OnDayChangedEventHandler OnDayChanged;
        public delegate void OnDayChangedEventHandler(object sender);

        #region Settings
        public DateTime SelectedDate
        {
            get
            {
                return DateTime.Today.AddDays(_daysFromToday);
            }
        }
        #endregion

        public TodoDaySlider()
        {
            DoubleBuffered = true;

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        #region Events
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            var mousePos = PointToClient(MousePosition);

            _lBtnHovered = _lBtnRegion.Contains(mousePos);
            _rBtnHovered = _rBtnRegion.Contains(mousePos);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            _lBtnHovered = false;
            _rBtnHovered = false;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            var mousePos = PointToClient(MousePosition);

            if (_lBtnRegion.Contains(mousePos))
            {
                _daysFromToday -= 1;
            }
            else
            {
                _daysFromToday += 1;
            }

            if (_lBtnRegion.Contains(mousePos) || _rBtnRegion.Contains(mousePos))
            {
                OnDayChanged?.Invoke(this);
                Refresh();
            }
        }
        #endregion

        private string DayToString()
        {
            switch (_daysFromToday)
            {
                case -2:
                    return "avant-hier";
                case -1:
                    return "hier";
                case 0:
                    return "aujourd'hui";
                case 1:
                    return "demain";
                case 2:
                    return "après-demain";
                default:
                    if (_daysFromToday < 0)
                    {
                        return $"il y a {Math.Abs(_daysFromToday)} jours";
                    }
                    else
                    {
                        return $"dans {_daysFromToday} jours";
                    }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            Size = new Size(310, 36);

            e.Graphics.FillRectangle(
                new SolidBrush(Color.FromArgb(30, Color.SlateGray)),
                ClientRectangle
            );

            // day region
            int lastNextDayRegionWidth = 45;
            var dayRegion = new Rectangle(new Point(lastNextDayRegionWidth, 0), new Size(Width - lastNextDayRegionWidth * 2, Height));

            using (var sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                var font = new Font("Segoe UI", 16f);
                e.Graphics.DrawString(DayToString(), font, new SolidBrush(Color.Gray), dayRegion, sf);
            }

            // left-right regions
            _lBtnRegion = new Rectangle(new Point(0, 0), Size.Round(new SizeF(lastNextDayRegionWidth, Height)));
            _rBtnRegion = new Rectangle(new Point(dayRegion.Right, 0), _lBtnRegion.Size);

            Image leftImg = Properties.Resources.arrow_left;
            Image rightImg = Properties.Resources.arrow_right;

            Color lBtnRegionBC = Color.Transparent;
            Color rBtnRegionBC = Color.Transparent;

            if (_lBtnHovered)
            {
                leftImg = Properties.Resources.arrow_left_hovered;
                lBtnRegionBC = Color.FromArgb(50, Color.Gray);
            }
            else if (_rBtnHovered)
            {
                rightImg = Properties.Resources.arrow_right_hovered;
                rBtnRegionBC = Color.FromArgb(50, Color.Gray);
            }

            e.Graphics.FillRectangle(new SolidBrush(lBtnRegionBC), _lBtnRegion);
            e.Graphics.FillRectangle(new SolidBrush(rBtnRegionBC), _rBtnRegion);

            e.Graphics.DrawImage(
                leftImg,
                new Rectangle(new Point(8, 5), Size.Round(new SizeF(lastNextDayRegionWidth * 0.60f, Height * 0.7f)))
            );

            e.Graphics.DrawImage(
                rightImg,
                new Rectangle(new Point(dayRegion.Right + 8, 5), Size.Round(new SizeF(lastNextDayRegionWidth * 0.60f, Height * 0.7f)))
            );
        }
    }
}
