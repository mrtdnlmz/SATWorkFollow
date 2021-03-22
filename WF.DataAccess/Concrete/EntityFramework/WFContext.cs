using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFEntities.Concrete;

namespace WF.DataAccess.Concrete.EntityFramework
{
    public class WFContext:DbContext
    {
        public DbSet<Personel> Personels { get; set;}
        public DbSet<Takip> isEmris { get; set; }


    }
}
