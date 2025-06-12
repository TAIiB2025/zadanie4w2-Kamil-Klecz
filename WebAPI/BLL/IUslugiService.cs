using BLL.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IUslugiService
    {

        public IEnumerable<UslugaEntity> Get();
        public UslugaBody GetById(int id);
        public void Delete(int id);
        public void Put(int id, UslugaBody osoba);
        public void post(UslugaBody osoba);

    }
}
