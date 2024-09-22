/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/22/2024
 * Time: 7:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace fastrandomgraphics
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Graphics g;
		public Pen p = new Pen(Color.White);
		public Pen p2 = new Pen(Color.Black);
		public Brush b = new SolidBrush(Color.Red);
		public Font f;
		void MainFormLoad(object sender, EventArgs e)
		{
			BackColor = Color.Black;
			r = new Random();
			g = CreateGraphics();
			f = Font;
		}
		public Random r ;
		public int ww = 2;
		public int hh = 2;
		public int x = 0 ;
		public int y = 0;
		public int px = 0 ;
		public int py = 0;
		
		void Timer1Tick(object sender, EventArgs e)
		{
			for(int i = 0 ; i < 10 ; i++){
			
			x = (int)r.Next(1,1920);//* (int)r.Next(1,10);
			y = (int)r.Next(1,1080);//* (int)r.Next(1,10);
			g.DrawEllipse(p,px,py,ww,hh);
			g.DrawLine(p2,x,y,px,py);
			px = x;
			py = y;
			}
		
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			button1.Visible = false;
		}
	}
}
