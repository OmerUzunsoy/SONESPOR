using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EsportsApp
{
    public class CustomButton : Button
    {
        // Yuvarlatılmış köşeler ve gradient için OnPaint metodu
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Kenarları yumuşatmak için

            // Gradient arka plan
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.FromArgb(95, 158, 160), // Başlangıç rengi
                Color.FromArgb(255, 255, 255), // Bitiş rengi
                LinearGradientMode.Vertical)) // Dikey geçiş
            {
                g.FillRectangle(brush, this.ClientRectangle);
            }

            // Yuvarlatılmış köşeler
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90); // Sol üst
            path.AddArc(this.Width - 20, 0, 20, 20, 270, 90); // Sağ üst
            path.AddArc(this.Width - 20, this.Height - 20, 20, 20, 0, 90); // Sağ alt
            path.AddArc(0, this.Height - 20, 20, 20, 90, 90); // Sol alt
            path.CloseAllFigures();

            // Çizim uygula
            this.Region = new Region(path);
        }

        // Hover efekti
        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(70, 130, 180); // Hover rengi
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.Transparent; // Varsayılan arka plan
        }

        // Tıklama efekti
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            this.BackColor = Color.FromArgb(60, 120, 170); // Tıklama rengi
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            this.BackColor = Color.FromArgb(70, 130, 180); // Hover sonrası
        }
    }
}