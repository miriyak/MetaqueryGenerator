using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaqueryGenerator.Forms.BaseControls
{
	public partial class CustomLabel : Label
	{
		public CustomLabel()
		{
			InitializeComponent();
			OutlineForeColor = Color.Black;
			OutlineWidth = 2;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
			using (GraphicsPath gp = new GraphicsPath())
			using (Pen outline = new Pen(OutlineForeColor, OutlineWidth)
			{ LineJoin = LineJoin.Round })
			using (StringFormat sf = new StringFormat())
			using (Brush foreBrush = new SolidBrush(ForeColor))
			{
				gp.AddString(Text, Font.FontFamily, (int)Font.Style,
					Font.Size, ClientRectangle, sf);
				e.Graphics.ScaleTransform(1.3f, 1.35f);
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				e.Graphics.DrawPath(outline, gp);
				e.Graphics.FillPath(foreBrush, gp);
			}
		}
		public Color OutlineForeColor { get; set; }
		public float OutlineWidth { get; set; }


	}
}
