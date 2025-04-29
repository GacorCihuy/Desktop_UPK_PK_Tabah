using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientPanel : Panel
{
    private Color colorTop = Color.White;
    private Color colorBottom = Color.Blue;

    [Category("Gradient")]
    public Color ColorTop
    {
        get { return colorTop; }
        set { colorTop = value; Invalidate(); }
    }

    [Category("Gradient")]
    public Color ColorBottom
    {
        get { return colorBottom; }
        set { colorBottom = value; Invalidate(); }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.colorTop, this.colorBottom, LinearGradientMode.Vertical))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
