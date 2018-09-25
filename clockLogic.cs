using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

public class clockLogic
{
    public static SolidBrush topcolor(int x)
    {
        SolidBrush top;
        if (x == -1)
        {
            top = new SolidBrush(Color.Gray);
        }
        else if ((x % 9) >= 0 && (x % 9) < 4)
        {
            top = new SolidBrush(Color.Green);
        }
        else
        {
            top = new SolidBrush(Color.Gray);
        }
        return top;
    }


    public static SolidBrush midcolor(int x)
    {
        SolidBrush mid;

        if ((x % 9) == 4)
        {
            mid = new SolidBrush(Color.Yellow);
        }
        else
        {
            mid = new SolidBrush(Color.Gray);
        }
        return mid;
    }

    public static SolidBrush botcolor(int x)
    {
        SolidBrush bot;

        if ((x % 9) > 4)
        {
            bot = new SolidBrush(Color.Red);
        }
        else
        {
            bot = new SolidBrush(Color.Gray);
        }
        return bot;
    }
}