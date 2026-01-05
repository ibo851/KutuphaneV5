using KutuphaneV1.DataAccess;

namespace KutuphaneV1
{
    internal class frmYazarGuncelle
    {
        private YazarDAL yazarDAL;
        private int id;
        private string adi;
        private string soyadi;

        public frmYazarGuncelle(YazarDAL yazarDAL, int id, string adi, string soyadi)
        {
            this.yazarDAL = yazarDAL;
            this.id = id;
            this.adi = adi;
            this.soyadi = soyadi;
        }
    }
}