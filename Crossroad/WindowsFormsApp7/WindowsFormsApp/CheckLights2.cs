using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
	internal class CheckLights2
	{
		public CheckLights2(PictureBox pictureBox4, PictureBox pictureBox5, PictureBox pictureBox6, Timer timer2)
		{
			if (pictureBox4.Visible == true)
			{
				pictureBox4.Visible = false;
				pictureBox5.Visible = false;        //change to green for 4 sec
				pictureBox6.Visible = true;
				timer2.Interval = 6000;
			}
			else if (pictureBox5.Visible == true)
			{
				pictureBox4.Visible = true;
				pictureBox5.Visible = false;        //change to red for 5 sec
				pictureBox6.Visible = false;
				timer2.Interval = 7000;
			}
			else if (pictureBox6.Visible == true)
			{
				pictureBox4.Visible = false;
				pictureBox5.Visible = true;     // change to yellow for 1 sec
				pictureBox6.Visible = false;
				timer2.Interval = 1000;
			}
		}
	}
}