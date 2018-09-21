using System;
using System.Drawing;
using System.Windows.Forms;
public class Program: Form {
	
	//Creating tools
	private Font arial = new Font("Arial", 15, FontStyle.Bold);
	private Pen blackPen = new Pen(Color.Black);

//
//Contructor
//
	public Program(){

	//Setting Window Properties

	Size = new Size(450,900);  

	Text = "Assignment 2 - By Lucas Vinyard";
	BackColor=Color.Gray;

	//Creating Label for Top of Program
	 Label nameLabel = new Label();
		nameLabel.Text = "Traffic Light by Lucas Vinyard";
		nameLabel.BackColor = Color.White;
        nameLabel.AutoSize = false;
    	nameLabel.TextAlign = ContentAlignment.MiddleCenter;
        nameLabel.Font = arial;
		nameLabel.Height = 40;
		nameLabel.Width = 400;
		Controls.Add(nameLabel);


	}//End of Program
	
//On Paint
	protected override void OnPaint(PaintEventArgs e) {
		
		Graphics g = e.Graphics;
		
		//Draw Pen (Line across bottom screen)
		blackPen.Width = 5;
		g.DrawLine(blackPen,0,749,450,749);
		g.DrawLine(blackPen,0,40,450,40);
		
		//Draw Rectangle (Black box on bottom and top screen)
		g.FillRectangle(Brushes.White,0,750,450,910);
		g.FillRectangle(Brushes.White,0,0,450,40);
			
		base.OnPaint(e);
	}// End of OnPaint


}// End of Class
