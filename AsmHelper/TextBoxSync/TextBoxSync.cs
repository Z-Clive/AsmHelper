using System;
using System.Drawing;
using System.Windows.Forms;

namespace AsmHelper.TextBoxSync
{
    public partial class TextBoxSync : UserControl
    {
        public RichTextBox TextBox { get { return txtInput; }       }

        public new bool Enabled
        {
            get { return txtInput.Enabled; }
            set { txtInput.Enabled = value; }
        }

        public TextBoxSync()
        {
            InitializeComponent();

            Load += TextBoxSync_Load;

            txtInput.TextChanged += txtInput_TextChanged;
            txtInput.VScroll += txtInput_VScroll;

            panel.Paint += panel_Paint;
        }

        void TextBoxSync_Load(object sender, EventArgs e)
        {
            txtInput.Focus();
        }

        void panel_Paint(object sender, PaintEventArgs e)
        {
            //获得当前坐标信息
            Point p = txtInput.Location;
            int crntFirstIndex = this.txtInput.GetCharIndexFromPosition(p);
            int crntFirstLine = this.txtInput.GetLineFromCharIndex(crntFirstIndex);
            Point crntFirstPos = this.txtInput.GetPositionFromCharIndex(crntFirstIndex);

            p.Y += this.txtInput.Height;

            int crntLastIndex = this.txtInput.GetCharIndexFromPosition(p);
            int crntLastLine = this.txtInput.GetLineFromCharIndex(crntLastIndex);
            Point crntLastPos = this.txtInput.GetPositionFromCharIndex(crntLastIndex);

            //准备画图
            using(Graphics g = this.panel.CreateGraphics())
            using(Font font = new Font(this.txtInput.Font, FontStyle.Bold))
            using (SolidBrush brush = new SolidBrush(Color.Green))
            {
                //画图开始

                //刷新画布
                Rectangle rect = this.panel.ClientRectangle;
                brush.Color = this.panel.BackColor;
                g.FillRectangle(brush, 0, 0, this.panel.ClientRectangle.Width, this.panel.ClientRectangle.Height);
                brush.Color = Color.Green;//重置画笔颜色

                //绘制行号
                int lineSpace = 0;
                if (crntFirstLine != crntLastLine)
                {
                    lineSpace = (crntLastPos.Y - crntFirstPos.Y) / (crntLastLine - crntFirstLine);
                }
                else
                {
                    lineSpace = Convert.ToInt32(this.txtInput.Font.Size);
                }

                int brushX = this.panel.ClientRectangle.Width - Convert.ToInt32(font.Size * 3);
                int brushY = crntLastPos.Y + Convert.ToInt32(font.Size * 0.21f);//惊人的算法啊！！

                for (int i = crntLastLine; i >= crntFirstLine; i--)
                {
                    g.DrawString((i + 1).ToString(), font, brush, brushX, brushY);
                    brushY -= lineSpace;
                }
            }
        }

        void txtInput_VScroll(object sender, EventArgs e)
        {
            panel.Invalidate();
        }

        void txtInput_TextChanged(object sender, EventArgs e)
        {
            panel.Invalidate();
        }
    }
}
