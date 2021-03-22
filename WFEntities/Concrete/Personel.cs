using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFEntities.Concrete
{
   public class Personel
    {
        public int ID { get; set; }
        public string Sicil { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime iseGirisTarihi { get; set; }
        public Nullable<DateTime> istenCikisTarihi { get; set; }
        public string Departman { get; set; }
        public string Bolum { get; set; }
        public string Unvan { get; set; }
        public string DirektEndirekt { get; set; }
        public string Durumu { get; set; }
        public string Statu { get; set; }//Engelli,Diğer//
        public string Sendika { get; set; }
        public string Cinsiyet { get; set; }
        public string Pozisyon { get; set; }
        public string Gorev { get; set; }
        public string MedeniHal { get; set; }
        public string KanGrubu { get; set; }
        public string CepTel { get; set; }
        public string TC { get; set; }
        public Nullable<bool> Sil { get; set; }



    }
}
