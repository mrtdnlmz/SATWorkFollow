using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFEntities.Concrete;

namespace WF.DataAccess.Abstract
{
    public interface IPersonelDal
    {
        List<Personel> GetAll();
        Personel Get(int id);
        void Add(Personel personel);
        void Update(Personel personel);
        void Delete(Personel personel);


    }
}
