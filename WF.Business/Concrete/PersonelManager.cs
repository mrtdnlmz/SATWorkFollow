using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF.Business.Abstract;
using WF.DataAccess.Abstract;
using WF.DataAccess.Concrete;
using WF.DataAccess.Concrete.EntityFramework;
using WFEntities.Concrete;

namespace WF.Business.Concrete
{
    public class PersonelManager:IPersonelServis
    {
        private IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public List<Personel> GetAll()
        {

            return _personelDal.GetAll();
        }
    }
}
