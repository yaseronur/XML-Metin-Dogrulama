using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;

namespace Metin_Doğrulama_Yedek5
{
    public partial class AnaSayfa : Form
    {
        public static string dosyaYoluDegiskeni;
        public AnaSayfa()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
        }

       
        

        private void AnaSayfa_Load(object sender, EventArgs e)
        {


        }

        private void btnara_Click(object sender, EventArgs e)
        {
            // Dosya açma penceresi oluşturma
            OpenFileDialog dosya = new OpenFileDialog();

            // Dosya uzantısı filtresi ekleme
            dosya.Filter = "XML dosyaları (*.xml)|*.xml";

            // Dosya açma penceresini gösterme
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                // Açılan dosyayı okuma
                string dosyaYolu = dosya.FileName;

                // Dosya yolunu bir değişkene kaydetme
                string dosyaYoluDegiskeni = dosyaYolu;
                label4.Text = dosyaYoluDegiskeni;
            }
            
        }

       

       

        private void btnirsaliye_Click_1(object sender, EventArgs e)
        {
            dosyaYoluDegiskeni = label4.Text;
            Form2 f = new Form2();
            f.Show();
        }
        
        private void btnfatura_Click(object sender, EventArgs e)
        {
            dosyaYoluDegiskeni = label4.Text;
            Form1 f = new Form1();
            f.Show();
        }
    }
}
