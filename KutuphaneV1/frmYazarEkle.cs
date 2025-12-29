using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneV1.DataAccess;
using KutuphaneV1.Entity;

namespace KutuphaneV1
{
    public partial class frmYazarEkle : Form
    {

        YazarDAL yazarDal = new YazarDAL();

        public frmYazarEkle(YazarDAL yazarDAL)
        {
            InitializeComponent();
            yazarDal = yazarDAL;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnYazarKaydet_Click(object sender, EventArgs e)
        {
            Yazar yazar=new Yazar()
            {
                Adi = txtYazarAdi.Text,
                Soyadi = txtYazarSoyadi.Text
            };

            yazarDal.Ekle(yazar);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmYazarEkle_Load(object sender, EventArgs e)
        {
           
        }
    }
}
