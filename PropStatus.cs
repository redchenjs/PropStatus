using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace PropStatus
{
    public partial class PropStatus: UserControl
    {
        private int M_H_FL = 0;
        private int M_H_FR = 0;
        private int M_H_BL = 0;
        private int M_H_BR = 0;

        private int M_V_FL = 0;
        private int M_V_BL = 0;
        private int M_V_FR = 0;
        private int M_V_BR = 0;

        private PointF[] Mark = {
            new Point(149, 39),
            new Point(169, 39),
            new Point(159, 19)
        };

        private PointF[] Model = {
            new Point(59, 79),
            new Point(79, 59),
            new Point(239, 59),
            new Point(259, 79),
            new Point(259, 239),
            new Point(239, 259),
            new Point(79, 259),
            new Point(59, 239)
        };

        public PropStatus()
        {
            InitializeComponent();
        }

        private void PropStatus_Paint(object sender, System.Windows.Forms.PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;

            // Model
            g.DrawPolygon(new Pen(Color.White, 1), Mark);
            g.DrawPolygon(new Pen(Color.White, 2), Model);
            g.DrawEllipse(new Pen(Color.White, 1), new Rectangle(144, 144, 30, 30));
            g.DrawEllipse(new Pen(Color.White, 1), new Rectangle(154, 154, 10, 10));

            // Horizontal Front Left
            g.DrawRectangle(new Pen(Color.White, 1), new Rectangle(89, 59, 41, 21));
            switch (M_H_FL)
            {
                case 0:
                    g.FillRectangle(new SolidBrush(Color.White), new Rectangle(90, 60, 40, 20));
                    break;
                case 1:
                    g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(90, 60, 40, 20));
                    break;
                case 2:
                    g.FillRectangle(new SolidBrush(Color.DarkBlue), new Rectangle(90, 60, 40, 20));
                    break;
                default:
                    g.FillRectangle(new SolidBrush(Color.Transparent), new Rectangle(90, 60, 40, 20));
                    break;
            }

            // Horizontal Front Right
            g.DrawRectangle(new Pen(Color.White, 1), new Rectangle(189, 59, 41, 21));
            switch (M_H_FR)
            {
                case 0:
                    g.FillRectangle(new SolidBrush(Color.White), new Rectangle(190, 60, 40, 20));
                    break;
                case 1:
                    g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(190, 60, 40, 20));
                    break;
                case 2:
                    g.FillRectangle(new SolidBrush(Color.DarkBlue), new Rectangle(190, 60, 40, 20));
                    break;
                default:
                    g.FillRectangle(new SolidBrush(Color.Transparent), new Rectangle(190, 60, 40, 20));
                    break;
            }

            // Horizontal Back Left
            g.DrawRectangle(new Pen(Color.White, 1), new Rectangle(89, 237, 41, 21));
            switch (M_H_BL)
            {
                case 0:
                    g.FillRectangle(new SolidBrush(Color.White), new Rectangle(90, 238, 40, 20));
                    break;
                case 1:
                    g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(90, 238, 40, 20));
                    break;
                case 2:
                    g.FillRectangle(new SolidBrush(Color.DarkBlue), new Rectangle(90, 238, 40, 20));
                    break;
                default:
                    g.FillRectangle(new SolidBrush(Color.Transparent), new Rectangle(90, 238, 40, 20));
                    break;
            }

            // Horizontal Back Right
            g.DrawRectangle(new Pen(Color.White, 1), new Rectangle(189, 237, 41, 21));
            switch (M_H_BR)
            {
                case 0:
                    g.FillRectangle(new SolidBrush(Color.White), new Rectangle(190, 238, 40, 20));
                    break;
                case 1:
                    g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(190, 238, 40, 20));
                    break;
                case 2:
                    g.FillRectangle(new SolidBrush(Color.DarkBlue), new Rectangle(190, 238, 40, 20));
                    break;
                default:
                    g.FillRectangle(new SolidBrush(Color.Transparent), new Rectangle(190, 238, 40, 20));
                    break;
            }

            // Vertical Front Left
            g.DrawEllipse(new Pen(Color.White, 1), new Rectangle(63, 103, 32, 32));
            switch (M_V_FL)
            {
                case 0:
                    g.FillEllipse(new SolidBrush(Color.White), new Rectangle(64, 104, 30, 30));
                    break;
                case 1:
                    g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(64, 104, 30, 30));
                    break;
                case 2:
                    g.FillEllipse(new SolidBrush(Color.DarkBlue), new Rectangle(64, 104, 30, 30));
                    break;
                default:
                    g.FillEllipse(new SolidBrush(Color.Transparent), new Rectangle(64, 104, 30, 30));
                    break;
            }

            // Vertical Back Left
            g.DrawEllipse(new Pen(Color.White, 1), new Rectangle(63, 183, 32, 32));
            switch (M_V_BL)
            {
                case 0:
                    g.FillEllipse(new SolidBrush(Color.White), new Rectangle(64, 184, 30, 30));
                    break;
                case 1:
                    g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(64, 184, 30, 30));
                    break;
                case 2:
                    g.FillEllipse(new SolidBrush(Color.DarkBlue), new Rectangle(64, 184, 30, 30));
                    break;
                default:
                    g.FillEllipse(new SolidBrush(Color.Transparent), new Rectangle(64, 184, 30, 30));
                    break;
            }

            // Vertical Front Right
            g.DrawEllipse(new Pen(Color.White, 1), new Rectangle(223, 103, 32, 32));
            switch (M_V_FR)
            {
                case 0:
                    g.FillEllipse(new SolidBrush(Color.White), new Rectangle(224, 104, 30, 30));
                    break;
                case 1:
                    g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(224, 104, 30, 30));
                    break;
                case 2:
                    g.FillEllipse(new SolidBrush(Color.DarkBlue), new Rectangle(224, 104, 30, 30));
                    break;
                default:
                    g.FillEllipse(new SolidBrush(Color.Transparent), new Rectangle(224, 104, 30, 30));
                    break;
            }

            // Vertical Back Right
            g.DrawEllipse(new Pen(Color.White, 1), new Rectangle(223, 183, 32, 32));
            switch (M_V_BR)
            {
                case 0:
                    g.FillEllipse(new SolidBrush(Color.White), new Rectangle(224, 184, 30, 30));
                    break;
                case 1:
                    g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(224, 184, 30, 30));
                    break;
                case 2:
                    g.FillEllipse(new SolidBrush(Color.DarkBlue), new Rectangle(224, 184, 30, 30));
                    break;
                default:
                    g.FillEllipse(new SolidBrush(Color.Transparent), new Rectangle(224, 184, 30, 30));
                    break;
            }
        }

        [Category("推进器数据")]
        [Description("水平-左前")]
        [DefaultValue(0)]
        public int H_FL
        {
            get { return M_H_FL; }
            set
            {
                if (M_H_FL != value)
                {
                    M_H_FL = value;
                    this.Refresh();
                }
            }
        }

        [Category("推进器数据")]
        [Description("水平-右前")]
        [DefaultValue(0)]
        public int H_FR
        {
            get { return M_H_FR; }
            set
            {
                if (M_H_FR != value)
                {
                    M_H_FR = value;
                    this.Refresh();
                }
            }
        }

        [Category("推进器数据")]
        [Description("水平-左后")]
        [DefaultValue(0)]
        public int H_BL
        {
            get { return M_H_BL; }
            set
            {
                if (M_H_BL != value)
                {
                    M_H_BL = value;
                    this.Refresh();
                }
            }
        }

        [Category("推进器数据")]
        [Description("水平-右后")]
        [DefaultValue(0)]
        public int H_BR
        {
            get { return M_H_BR; }
            set
            {
                if (M_H_BR != value)
                {
                    M_H_BR = value;
                    this.Refresh();
                }
            }
        }

        [Category("推进器数据")]
        [Description("垂直-左前")]
        [DefaultValue(0)]
        public int V_FL
        {
            get { return M_V_FL; }
            set
            {
                if (M_V_FL != value)
                {
                    M_V_FL = value;
                    this.Refresh();
                }
            }
        }

        [Category("推进器数据")]
        [Description("垂直-左后")]
        [DefaultValue(0)]
        public int V_BL
        {
            get { return M_V_BL; }
            set
            {
                if (M_V_BL != value)
                {
                    M_V_BL = value;
                    this.Refresh();
                }
            }
        }

        [Category("推进器数据")]
        [Description("垂直-右前")]
        [DefaultValue(0)]
        public int V_FR
        {
            get { return M_V_FR; }
            set
            {
                if (M_V_FR != value)
                {
                    M_V_FR = value;
                    this.Refresh();
                }
            }
        }

        [Category("推进器数据")]
        [Description("垂直-右后")]
        [DefaultValue(0)]
        public int V_BR
        {
            get { return M_V_BR; }
            set
            {
                if (M_V_BR != value)
                {
                    M_V_BR = value;
                    this.Refresh();
                }
            }
        }
    }
}
