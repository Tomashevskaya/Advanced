using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;

namespace IPrinter
{
     class ImagePrint : IPrinter
     {
        public string text { get; set; }
        public void Print(string text)
        {
            Image bitmap = (Bitmap)Image.FromFile(@"D:\\DCIM\100APPLE\123.jpg");
            RectangleF rectf = new RectangleF(70, 90, 190, 150);
            Graphics g = Graphics.FromImage(bitmap);

            var format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(text, new Font("Arial", 12), Brushes.Black, rectf, format);
            g.Dispose();
            bitmap.Save("AddTextImage.Bmp", ImageFormat.Bmp);
        }
     }
}
