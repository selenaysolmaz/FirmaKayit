using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmaKayit.Bilgi;
using System.Windows.Forms;



namespace FirmaKayit.Hangar
{
    class Formlar
    {
        
        #region Firma Islemleri

        public void FrmGir()
        {
            frmFirmaGiris frm = new frmFirmaGiris();
            frm.MdiParent = Form.ActiveForm;   //Application.OpenForms["ana sayfa"] as AnaSayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        public int FrmListe(bool secim = false)
        {
            frmFirmaListe fl = new frmFirmaListe();
            if (secim)
            {
                fl.Secim = true;
                fl.ShowDialog();
            }
            else
            {
                fl.MdiParent = Form.ActiveForm;
                fl.Show();
            }
            return AnaSayfa.Aktarma;
        }
        

        #endregion
    }
}
