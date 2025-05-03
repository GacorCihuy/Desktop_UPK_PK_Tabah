using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace upk_pk_tabah
{
    public class GradientPanel : Panel // Warisi dari Panel
    {
        // Properti untuk gradasi warna
        public Color ColorTop { get; set; } = Color.LightBlue;
        public Color ColorBottom { get; set; } = Color.DarkBlue;

        // Override metode OnPaint untuk menggambar gradasi
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(
                ClientRectangle,
                ColorTop,
                ColorBottom,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}