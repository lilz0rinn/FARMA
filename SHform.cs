using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;
using ZXing.Windows.Compatibility;

namespace farma
{
    public partial class SHform : Form
    {
        public SHform()
        {
            InitializeComponent();

        }

        public SHform(string productName)
        {
            InitializeComponent();


            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Width = 200,
                    Height = 200,
                    Margin = 10,
                    PureBarcode = false,
                    GS1Format = false
                }
            };

            Bitmap barcodeBitmap = writer.Write(productName);
            pictureBox1.Image = barcodeBitmap;


        }

        private void SHform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
