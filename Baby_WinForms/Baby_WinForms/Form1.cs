using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baby_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BabyList.Items.Add("İsim" + "\t" + "Soyisim" + "\t" + "Yaş");
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            Baby _baby = new Baby();
            _baby.Name = isimTxtBox.Text;
            _baby.Surname = soyisimTxtBox.Text;
            _baby.Age = Convert.ToByte(yasTxtBox.Text);

            BabyList.Items.Add(_baby);

            // Listeye ekledikten sonra TextBox lar siliniyor
            isimTxtBox.Text = "";
            soyisimTxtBox.Text = "";
            yasTxtBox.Text = "";

            EkleBtn.Text = "Ekle";
        }

        private void BabyList_DoubleClick(object sender, EventArgs e)
        {
            // sıfırıncı index başlık olduğu için
            if (BabyList.SelectedIndex != 0)
            {
                // yeni nesne oluşturduk
                Baby _baby = new Baby();

                // seçili item _baby nesneine atanıyor ve nesne listeden siliniyor
                _baby = (Baby)BabyList.SelectedItem;
                BabyList.Items.RemoveAt(BabyList.SelectedIndex);

                // textbox değerlerine nesneden atama yapılıyor
                isimTxtBox.Text = _baby.Name;
                soyisimTxtBox.Text = _baby.Surname;
                yasTxtBox.Text = _baby.Age.ToString();

                // Ekle butonu texti güncelleme yapılacağı için değiştirilyor
                EkleBtn.Text = "Güncelle";
            }
        }
    }
}
