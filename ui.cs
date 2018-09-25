//Lucas Vinyard

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
public class Program : Form
{
    //Creating tools
    private Font arial = new Font("Arial", 15, FontStyle.Bold);
    private Pen blackPen = new Pen(Color.Black);
    public int counter = -1;

    public static int pace = 1000;

    //Initizlizes Clock
    private static System.Timers.Timer seiko = new System.Timers.Timer(pace);

    //
    //Contructor
    //
    public Program()
    {

        //Setting Window Properties
        Size = new Size(450, 900);
        Text = "Assignment 2 - By Lucas Vinyard";
        BackColor = Color.DarkGreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;

        //Call Label for Top of Program
        initLabel();

        //Call Controls
        controls();



    }//End of Contructor

    //Creating Label
    protected void initLabel()
    {
        Label nameLabel = new Label();
        nameLabel.Text = "Traffic Light by Lucas Vinyard";
        nameLabel.BackColor = Color.White;
        nameLabel.AutoSize = false;
        nameLabel.TextAlign = ContentAlignment.MiddleCenter;
        nameLabel.Font = arial;
        nameLabel.Height = 40;
        nameLabel.Width = 400;
        Controls.Add(nameLabel);
    }

    //Creating Controls
    protected void controls()
    {
        //Start Button
        Button startButton = new Button();
        startButton.Location = new Point(20, 780);
        startButton.Font = new Font("Arial", 10, FontStyle.Bold);
        startButton.ForeColor = Color.Black;
        startButton.BackColor = Color.Green;
        startButton.Text = "Start";
        Controls.Add(startButton);
        startButton.Click += new EventHandler(startFunction);

        //GroupBox Rate of Change
        GroupBox roc = new GroupBox();
        roc.ForeColor = Color.Black;
        roc.BackColor = Color.White;
        roc.Text = "Rate of Change";
        roc.Location = new Point(130, 770);

        //Making slow RadioButton
        RadioButton slow = new RadioButton();
        slow.Location = new Point(25, 20);
        slow.Text = "Slow";
        roc.Controls.Add(slow);
        slow.Click += new EventHandler(slowfunction);

        //Making medium RadioButton
        RadioButton medium = new RadioButton();
        medium.Location = new Point(25, 45);
        medium.Text = "Medium";
        roc.Controls.Add(medium);
        medium.Click += new EventHandler(mediumfunction);

        //Making fast RadioButton
        RadioButton fast = new RadioButton();
        fast.Location = new Point(25, 70);
        fast.Text = "Fast";
        roc.Controls.Add(fast);
        fast.Click += new EventHandler(fastfunction);

        Controls.Add(roc);

        //Stop Button
        Button stopButton = new Button();
        stopButton.Location = new Point(20, 820);
        stopButton.Font = new Font("Arial", 10, FontStyle.Bold);
        stopButton.ForeColor = Color.Black;
        stopButton.BackColor = Color.Yellow;
        stopButton.Text = "Stop";
        Controls.Add(stopButton);
        stopButton.Click += new EventHandler(stopFunction);

        //Exit Button
        Button exitButton = new Button();
        exitButton.Location = new Point(350, 800);
        exitButton.Font = new Font("Arial", 10, FontStyle.Bold);
        exitButton.ForeColor = Color.Black;
        exitButton.BackColor = Color.Red;
        exitButton.Text = "Exit";
        Controls.Add(exitButton);
        exitButton.Click += new EventHandler(exitFunction);
    }




    //Seiko function
    protected void seiko_function(System.Object s, ElapsedEventArgs e)
    {
        counter++;
        Invalidate();
    }

    protected void startFunction(object x, EventArgs e)
    {
        seiko.Start();
        seiko.Elapsed += new ElapsedEventHandler(seiko_function);
    }
    protected void slowfunction(Object x, EventArgs e)
    {
        pace = 2000;
    }

    protected void mediumfunction(Object x, EventArgs e)
    {
        pace = 1000;
    }

    protected void fastfunction(Object x, EventArgs e)
    {
        pace = 500;
    }
    protected void stopFunction(object x, EventArgs e)
    {
        seiko.Stop();
    }

    protected void exitFunction(object x, EventArgs e)
    {
        seiko.Dispose();
        Application.Exit();
    }


    //On Paint
    protected override void OnPaint(PaintEventArgs e)
    {

        Graphics g = e.Graphics;

        //Draw Pen (Line across bottom screen)
        blackPen.Width = 5;
        g.DrawLine(blackPen, 0, 749, 450, 749);
        g.DrawLine(blackPen, 0, 40, 450, 40);

        //Draw Rectangle (Black box on bottom and top screen)
        g.FillRectangle(Brushes.White, 0, 750, 450, 910);
        g.FillRectangle(Brushes.White, 0, 0, 450, 40);

        //Drawing Circles


        RectangleF rect1 = new RectangleF(125, 65, 200, 200);
        RectangleF rect2 = new RectangleF(125, 295, 200, 200);
        RectangleF rect3 = new RectangleF(125, 525, 200, 200);
        g.FillEllipse(clockLogic.topcolor(counter), rect1);
        g.FillEllipse(clockLogic.midcolor(counter), rect2);
        g.FillEllipse(clockLogic.botcolor(counter), rect3);


        base.OnPaint(e);
    }// End of OnPaint


}// End of Class
