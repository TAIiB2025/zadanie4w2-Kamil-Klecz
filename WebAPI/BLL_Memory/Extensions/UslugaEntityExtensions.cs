using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.Model;
using DAL;
namespace BLL_Memory.Extensions
{
    internal static class UslugaEntityExtentions
    {
        public static UslugaBody ToUslugaBody(this UslugaEntity osobaEntity)
        {
            return new UslugaBody(osobaEntity.nazwa, osobaEntity.wykonawca, osobaEntity.rodzaj, osobaEntity.rok);
        }
    }
}
