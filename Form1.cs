using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_İnceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //items.add kullanılarak değerler comboBoxa eklendi
            // comboBoxDoldurV1();
            comboBoxDoldurV2();
        }

        private void comboBoxDoldurV2()
        {
            cmbUrunListe.DataSource = database.UrunTablo;
        }

        void comboBoxDoldurV1()
        {
            foreach(var item in database.UrunTablo)
            {
                cmbUrunListe.Items.Add(item);
            }
        }

        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            object o1 = cmbUrunListe.SelectedItem;
            Urun u1 = (Urun)o1;


            //u1 = cmbUrunListe.SelectedItem == null ? null : cmbUrunListe.SelectedItem as Urun;

            // ComboBox secilenCombobox = sender as ComboBox;

            pictureBox1.Image = Image.FromFile(u1.urunResim);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            txtUrunAdi.Text = u1.urunAdi;
            txtKategori.Text = u1.urunKategori;
            txtStokAdet.Text = u1.stokAdet.ToString();
            txtYazar.Text = u1.yazar;
            txtUrunAciklama.Text = u1.aciklama;





        }
    }
}
