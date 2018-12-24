using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FirmaKayit.Hangar
{
    class mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj, "yeni kayıt giris", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Secili Olan Kayıt Guncellenecektir. \n Guncelleme islemini onaylıyor musunuz?", "Guncelleme İslemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Secili kayıt silinecektir.","Silme islemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

        }
        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt güncellenmistir.", "Kayıt güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message,"Hata olustu.",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
