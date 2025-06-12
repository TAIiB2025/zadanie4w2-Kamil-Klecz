using BLL;
using BLL.Model;
using BLL_Memory.Extensions;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Memory
{
    public class UslugiService : IUslugiService
    {
        private static int IdGen = 1;
        private static readonly List<UslugaEntity> osobyDbSet = [
            new UslugaEntity(){
                        numer = IdGen++,
                        nazwa = "Usluga1",
                        wykonawca = "Kowalski",
                        rodzaj = "ekonomia",
                        rok = 2024
                    },
                  new UslugaEntity(){
                        numer = IdGen++,
                        nazwa = "Usluga2",
                        wykonawca = "Nowak",
                        rodzaj = "ekonomia",
                        rok = 2024
                    },
            new UslugaEntity(){
                        numer = IdGen++,
                        nazwa = "Usluga3",
                        wykonawca = "Ryba",
                        rodzaj = "doradztwo",
                        rok = 2024
                    },
            ];

        public IEnumerable<UslugaEntity> Get()
        {
            //return osobyDbSet.Select(os => os.ToUslugaBody()); //używamy extention
            return osobyDbSet.ToList();
        }

        public UslugaBody GetById(int id)
        {
            UslugaEntity? osobaEntity = osobyDbSet.Find(os => os.numer == id);  //.Single = kontrola czy na pewno 1 instancja.

            //if (osobaEntity is null)
            //{
            //    throw new ApplicationException($"Nie można znaleźćsoby o Id = {id}");
            //}

            return osobaEntity.ToUslugaBody();
        }

        public void Delete(int id)
        {
            UslugaEntity? osobaEntity = osobyDbSet.Find(os => os.numer == id);

            //if (osobaEntity is null)
            //{
            //    throw new ApplicationException($"Nie można znaleźć usługi o Id = {id}");
            //}

            osobyDbSet.Remove(osobaEntity);

        }

        public void Put(int id, UslugaBody osoba)
        {
            UslugaEntity? osobaEntity = osobyDbSet.Find(os => os.numer == id);

            osobaEntity.nazwa = osoba.nazwa;
            osobaEntity.rodzaj = osoba.rodzaj;
            osobaEntity.wykonawca = osoba.wykonawca;
            osobaEntity.rok = osoba.rok;
        }

        public void post(UslugaBody osoba)
        {
            UslugaEntity osobaEntity = new UslugaEntity()
            {
                nazwa = osoba.nazwa,
                rodzaj = osoba.rodzaj,
                wykonawca = osoba.wykonawca,
                rok = osoba.rok,
                numer = IdGen++
            };
            osobyDbSet.Add(osobaEntity);
        }
    }
}
