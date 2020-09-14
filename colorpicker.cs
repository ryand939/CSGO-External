using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWext
{
	public partial class colorpicker : Form
	{

		public colorpicker()
		{

			InitializeComponent();
		}

		private void lblVisuals_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pnlVis_Paint(object sender, PaintEventArgs e)
		{
			var borderStyleTopLeft = ButtonBorderStyle.Outset;
			var borderStyleBottomRight = ButtonBorderStyle.Inset;
			var borderWidth = 2; //default
			var borderColor = Color.Black;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, pnlFriendly.Width, pnlFriendly.Height),
								borderColor,//left
								borderWidth,
								borderStyleTopLeft,
								borderColor,//top
								borderWidth,
								borderStyleTopLeft,
								borderColor,//right
								borderWidth,
								borderStyleBottomRight,
								borderColor,//left
								borderWidth,
								borderStyleBottomRight);
		}

		private void lblFriendly_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblFriendly.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value)), 0, -1, StringFormat.GenericDefault);
		}

		private void colorpicker_Paint(object sender, PaintEventArgs e)
		{
			var borderColor = Color.Black;
			var borderStyle = ButtonBorderStyle.Outset;
			var borderWidth = 4;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, this.Width, this.Height),
								borderColor,
								borderWidth,
								borderStyle,
								borderColor,
								borderWidth,
								borderStyle,
								borderColor,
								borderWidth,
								borderStyle = ButtonBorderStyle.Inset, //right side
								borderColor,
								borderWidth,
								borderStyle = ButtonBorderStyle.Inset); //bottom side
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void lblRed_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblRed.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(210, 0, 0)), 0, -1, StringFormat.GenericDefault);
		}

		private void lblGreen_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblGreen.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(0, 210, 0)), 0, -1, StringFormat.GenericDefault);
		}

		private void lblBlue_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblBlue.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(0, 0, 210)), 0, -1, StringFormat.GenericDefault);
		}

		private void trackBlue_Scroll(object sender, EventArgs e)
		{
			lblFriendly.Invalidate(); // Causes label to be redrawn
		}

		public void trackGreen_ValueChanged(object sender, EventArgs e)
		{
			
		}

		private void trackRed_ValueChanged(object sender, EventArgs e)
		{

		}

		private void trackBlue_ValueChanged(object sender, EventArgs e)
		{

		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{
			var borderStyleTopLeft = ButtonBorderStyle.Outset;
			var borderStyleBottomRight = ButtonBorderStyle.Inset;
			var borderWidth = 2; //default
			var borderColor = Color.Black;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, pnlVisEnemy.Width, pnlVisEnemy.Height),
								borderColor,//left
								borderWidth,
								borderStyleTopLeft,
								borderColor,//top
								borderWidth,
								borderStyleTopLeft,
								borderColor,//right
								borderWidth,
								borderStyleBottomRight,
								borderColor,//left
								borderWidth,
								borderStyleBottomRight);
		}

		private void label4_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblRedEnemy.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(210, 0, 0)), 0, -1, StringFormat.GenericDefault);
		}

		private void label3_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblGreenEnemy.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(0, 210, 0)), 0, -1, StringFormat.GenericDefault);
		}

		private void label2_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblBlueEnemy.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(0, 0, 210)), 0, -1, StringFormat.GenericDefault);
		}

		private void lblEnemy_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblEnemy.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(trackRedEnemy.Value, trackGreenEnemy.Value, trackBlueEnemy.Value)), 0, -1, StringFormat.GenericDefault);
		}

		private void trackRedEnemy_ValueChanged(object sender, EventArgs e)
		{
			lblEnemy.Invalidate(); // Causes label to be redrawn
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
	
}
