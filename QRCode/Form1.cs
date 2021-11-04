using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            string qrtext = tbContent.Text;
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(qrtext);
            pbQRCode.Image = qrcode as Image;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG|*.png | JPEG|*.jpeg| GIF|*.gif|BMP|*.bmp";
            if(save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbQRCode.Image.Save(save.FileName);
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            if(load.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbQRCode.ImageLocation = load.FileName;
            }
        }

        private void btRaspoznat_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            MessageBox.Show(decoder.decode(new QRCodeBitmapImage(pbQRCode.Image as Bitmap)));
        }
    }
}
