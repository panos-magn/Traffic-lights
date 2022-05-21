using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
	internal class CheckLights1
	{
		public CheckLights1(PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3, Timer timer1)
		{
			if (pictureBox1.Visible == true)
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = true;     // change to yellow for 1 sec
				pictureBox3.Visible = false;
				//Check();
				timer1.Interval = 1000;
			}
			else if (pictureBox2.Visible == true)
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;        //change to red for 5 sec
				pictureBox3.Visible = true;
				//Check();
				timer1.Interval = 7000;
			}
			else if (pictureBox3.Visible == true)
			{
				pictureBox1.Visible = true;
				pictureBox2.Visible = false;        //change to green for 4 sec
				pictureBox3.Visible = false;
				//Check();
				timer1.Interval = 6000;
			}
		}
	}
}
