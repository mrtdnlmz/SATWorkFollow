using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF.DataAccess.Abstract;
using WFEntities.Concrete;

namespace WF.DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : IPersonelDal
    {
        public List<Personel> GetAll()
        {
            using (WFContext context = new WFContext())
            {
                return context.Personels.ToList();
            }
        }

        public Personel Get(int id)
        {
            using (WFContext context = new WFContext())
            {
                return context.Personels.SingleOrDefault(s => s.ID == id);
            }
        }

        public void Add(Personel personel)
        {
            using (WFContext context = new WFContext())
            {
                context.Personels.Add(personel);
                context.SaveChanges();
            }

        }

        public void Update(Personel personel)
        {
            using (WFContext context = new WFContext())
            {
                //context.Personels.Add(personel);
                context.SaveChanges();
            }

        }

        public void Delete(Personel personel)
        {
            using (WFContext context = new WFContext())
            {
                context.Personels.Add(personel);
                context.SaveChanges();
            }

        }
    }
}