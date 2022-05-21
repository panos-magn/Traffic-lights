using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6;

namespace WindowsFormsApp7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = true;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			pictureBox6.Visible = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			timer2.Enabled = true;
			timer7.Enabled = true;
			timer8.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			CheckLights1 a = new CheckLights1(pictureBox1, pictureBox2, pictureBox3, timer1);
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			CheckLights2 c = new CheckLights2(pictureBox4, pictureBox5, pictureBox6, timer2);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (((textBox1.Text.Length != 0) && (textBox2.Text.Length != 0) && (textBox3.Text.Length != 0) && (textBox6.Text.Length != 0) && (textBox5.Text.Length != 0) && (textBox4.Text.Length != 0)) && ((int.Parse(textBox3.Text) > 0) && (int.Parse(textBox1.Text) > 0) && (int.Parse(textBox2.Text) > 0) && (int.Parse(textBox4.Text) > 0) && (int.Parse(textBox5.Text) > 0) && (int.Parse(textBox6.Text) > 0)))
			{
				timer7.Enabled = true;
				timer8.Enabled = true;
				if ((1000 * int.Parse(textBox3.Text) - 1000 * int.Parse(textBox2.Text) > 0))
				{
					timer3.Enabled = true;
					timer4.Enabled = true;
					timer3.Interval = 1000 * int.Parse(textBox3.Text);
					timer4.Interval = 1000 * int.Parse(textBox3.Text) - 1000 * int.Parse(textBox2.Text);
				}
				else if ((1000 * int.Parse(textBox4.Text) - 1000 * int.Parse(textBox5.Text) > 0))
				{
					timer5.Enabled = true;
					timer6.Enabled = true;
					timer5.Interval = 1000 * int.Parse(textBox4.Text) - 1000 * int.Parse(textBox5.Text);//pic4,5,6// 
					timer6.Interval = 1000 * int.Parse(textBox4.Text);
				}
				else
				{
					timer1.Enabled = true;
					timer2.Enabled = true;

				}

			}
			else
			{
				MessageBox.Show("Complete the empty cells");
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			if (pictureBox1.Visible == true)
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = true;          //Change to yellow for requested seconds
				pictureBox3.Visible = false;
				timer3.Interval = 1000 * int.Parse(textBox2.Text);

			}
			else if (pictureBox2.Visible == true)
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;
				pictureBox3.Visible = true;           //Change to red for requested seconds
				timer3.Interval = 1000 * int.Parse(textBox3.Text);
			}
			else if (pictureBox3.Visible == true)
			{
				pictureBox1.Visible = true;          //Change to green for requested seconds
				pictureBox2.Visible = false;
				pictureBox3.Visible = false;
				timer3.Interval = 1000 * int.Parse(textBox1.Text);
			}
		}

		private void timer4_Tick(object sender, EventArgs e)
		{
			if (pictureBox6.Visible == true)
			{
				pictureBox4.Visible = false;
				pictureBox5.Visible = true;          //Change to yellow for requested seconds
				pictureBox6.Visible = false;
				timer4.Interval = 1000 * int.Parse(textBox2.Text);

			}
			else if (pictureBox5.Visible == true)
			{
				pictureBox6.Visible = false;
				pictureBox5.Visible = false;
				pictureBox4.Visible = true;           //Change to red for requested seconds
				timer4.Interval = 1000 * int.Parse(textBox1.Text) + 1000 * int.Parse(textBox2.Text);
			}
			else if (pictureBox4.Visible == true)
			{
				pictureBox6.Visible = true;          //Change to green for requested seconds
				pictureBox5.Visible = false;
				pictureBox4.Visible = false;
				timer4.Interval = 1000 * int.Parse(textBox3.Text) - 1000 * int.Parse(textBox2.Text);
			}
		}

		private void timer5_Tick(object sender, EventArgs e)
		{
			if (pictureBox6.Visible == true)
			{
				pictureBox4.Visible = false;
				pictureBox5.Visible = true;          //Change to yellow for requested seconds
				pictureBox6.Visible = false;
				timer5.Interval = 1000 * int.Parse(textBox5.Text);

			}
			else if (pictureBox5.Visible == true)
			{
				pictureBox6.Visible = false;
				pictureBox5.Visible = false;
				pictureBox4.Visible = true;           //Change to red for requested seconds
				timer5.Interval = 1000 * int.Parse(textBox4.Text);
			}
			else if (pictureBox4.Visible == true)
			{
				pictureBox6.Visible = true;          //Change to green for requested seconds
				pictureBox5.Visible = false;
				pictureBox4.Visible = false;
				timer5.Interval = 1000 * int.Parse(textBox6.Text);
			}
		}

		private void timer6_Tick(object sender, EventArgs e)
		{
			if (pictureBox1.Visible == true)
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = true;          //Change to yellow for requested seconds
				pictureBox3.Visible = false;
				timer6.Interval = 1000 * int.Parse(textBox5.Text);

			}
			else if (pictureBox2.Visible == true)
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;
				pictureBox3.Visible = true;           //Change to red for requested seconds
				timer6.Interval = 1000 * int.Parse(textBox6.Text) + 1000 * int.Parse(textBox5.Text);
			}
			else if (pictureBox3.Visible == true)
			{
				pictureBox1.Visible = true;          //Change to green for requested seconds
				pictureBox2.Visible = false;
				pictureBox3.Visible = false;
				timer6.Interval = 1000 * int.Parse(textBox4.Text) - 1000 * int.Parse(textBox5.Text);
			}
		}

		private void timer7_Tick(object sender, EventArgs e)
		{
			int a = pictureBox7.Location.X;
			int b = pictureBox7.Location.Y;

			/*if (((a<=160)&&(pictureBox1.Visible ==true))||(a>200) )
			{
				pictureBox7.Location = new Point(a+40, b);
			}*/
			if (a <= 160)
			{
				if ((pictureBox1.Visible == true) || pictureBox3.Visible == true)
				{
					pictureBox7.Location = new Point(a + 40, b);
				}
			}
			else if (a == 200)
			{
				if (pictureBox1.Visible == true)
				{
					pictureBox7.Location = new Point(a + 40, b);
				}

			}
			else if (a > 200)
			{
				pictureBox7.Location = new Point(a + 40, b);
			}

		}

		private void timer8_Tick(object sender, EventArgs e)
		{
			int c = pictureBox8.Location.X;
			int d = pictureBox8.Location.Y;
			if (d <= 120)
			{
				if ((pictureBox4.Visible == true) || pictureBox6.Visible == true)
				{
					pictureBox8.Location = new Point(c, d + 40);
				}
			}
			else if (d == 160)
			{
				if (pictureBox6.Visible == true)
				{
					pictureBox8.Location = new Point(c, d + 40);
				}

			}
			else if (d > 160)
			{
				pictureBox8.Location = new Point(c ,d + 40);
			}
		}
	}
}
