using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace TodoMinute.Theme
{
    class TodoHoverableButtonImage : Control
    {
        private Image _imageNormal;
        private Image _imageHovered;

        private bool _hovered = false;

        #region Settings
        [Category("Todo")]
        public Image Image_Normal
        {
            get { return _imageNormal; }
            set
            {
                _imageNormal = value;
                Refresh();
            }
        }

        [Category("Todo")]
        public Image Image_Hovered
        {
            get { return _imageHovered; }
            set
            {
                _imageHovered = value;
                Refresh();
            }
        }
        #endregion

        public TodoHoverableButtonImage()
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
            Cursor = Cursors.Hand;
            Refresh();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hovered = false;
            Cursor = Cursors.Default;
            Refresh();
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            if (_hovered)
            {
                if (Image_Hovered != null)
                {
                    e.Graphics.DrawImage(Image_Hovered, ClientRectangle);
                }
            }
            else
            {
                if (Image_Normal != null)
                {
                    e.Graphics.DrawImage(Image_Normal, ClientRectangle);
                }
            }
        }
    }
}
