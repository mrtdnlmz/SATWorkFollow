using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WFEntities.Concrete
{
   public class Takip
    {
        public int ID { get; set; }
        public string isNo { get; set; }
        public string TASicilNo { get; set; }
        public string TalepAcanAdi { get; set; }
        public string TalepAcanSoyadi { get; set; }
        public string SorumluSicilNo { get; set; }
        public string SorumluAdi { get; set; }
        public string SorumluSoyadi { get; set; }
        public string Konu { get; set; }

        public static object GetAll()
        {
            throw new NotImplementedException();
        }

        public string Aciklama { get; set; }
        public string Bolum { get; set; }
        public Nullable<DateTime> TalepTarihi { get; set; }
        public Nullable<DateTime> TerminTarihi { get; set; }
        public int TamamlanmaDurumu { get; set; }
        public string SurecBilgi { get; set; }
        public Nullable<DateTime> ErtelemeTarihi { get; set; }
        public string ErtelemeSebebi { get; set; }
        public string GuncellemeYapan { get; set; }
        public Nullable<DateTime> GuncellemeTarihi { get; set; }
        public Nullable<bool> isEmriKapat { get; set; }
        public Nullable<bool> isEmriSil { get; set; }





    }
}
