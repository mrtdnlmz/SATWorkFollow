using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFEntities.Concrete;

namespace WF.Business.Abstract
{
    public interface IisEmriService
    {
        List<Takip> GetAll();
    }
}
