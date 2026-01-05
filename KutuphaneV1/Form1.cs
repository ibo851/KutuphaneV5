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
    public partial class Form1 : Form
    {

        YazarDAL yazarDal = new YazarDAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
           KitapEkle kitapEkleForm = new KitapEkle();
            kitapEkleForm.ShowDialog();

        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            frmYazarEkle  frmYzrEkle= new frmYazarEkle(new Yazar());
            if (frmYzrEkle.ShowDialog() == DialogResult.OK)
            {
                dtgYazarlar.DataSource = yazarDal.YazarListele();
            }
        }

        private void dtgKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgYazarlar.DataSource = yazarDal.YazarListele();
        }

        private void dtgYazarlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnYazarGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgYazarlar.CurrentRow.Cells["Id"].Value);
            string adi = dtgYazarlar.CurrentRow.Cells["Adi"].Value.ToString();
            string soyadi = dtgYazarlar.CurrentRow.Cells["Soyadi"].Value.ToString();

            frmYazarEkle frmYzrEkle = new frmYazarEkle(new Yazar{Id = id, Adi = adi, Soyadi = soyadi});



        }
        }
    }

