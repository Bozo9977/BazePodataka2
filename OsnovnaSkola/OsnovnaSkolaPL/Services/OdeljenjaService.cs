using OsnovnaSkola;
using OsnovnaSkola.DataAccess;
using OsnovnaSkolaPL.Interfaces;
using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OsnovnaSkolaPL.Services
{
    public class OdeljenjaService : IOdeljenja
    {
        private static OdeljenjeDAO dao = new OdeljenjeDAO();
        //private static ZaposleniciDAO zDao= new ZaposleniciDAO();

       

        public bool AddOdeljenje(OdeljenjeIM odeljenje)
        {
            Odeljenje newOdeljenje = new Odeljenje()
            {
                razred = odeljenje.razred
            };
            return dao.Insert(newOdeljenje);
        }

        public bool AddRazredni(OdeljenjeIM odeljenje, ZaposleniIM zaposleni)
        {
            

            using(var db = new ModelOsnovnaSkolaContainer())
            {
                Zaposleni z = db.Zaposlenici.Find(zaposleni.Id_zaposlenog);
                Odeljenje o = db.Odeljenja.Find(odeljenje.Id_odeljenja);


                if (o.NastavnikOdeljenjes.SingleOrDefault(x=>x.Razredni==true)==null || o.Ucitelj == null)
                {
                    o.NastavnikOdeljenjes.Add(new NastavnikOdeljenje() { Nastavnik = z as Nastavnik, Odeljenje = o, NastavnikId_zaposlenog = z.Id_zaposlenog, OdeljenjeId_odeljenja = o.Id_odeljenja, Razredni = true });
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                //return true;
            }
        }

       

        public bool AddNastavnik(OdeljenjeIM odeljenje, ZaposleniIM zaposleni)
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                Zaposleni z = db.Zaposlenici.Find(zaposleni.Id_zaposlenog);
                Odeljenje o = db.Odeljenja.Find(odeljenje.Id_odeljenja);

                if(z is Ucitelj)
                {
                    o.Ucitelj = (z as Ucitelj);
                    //dodati logiku u add nastavnik za proveru ako je ucitelj i postoji vec jedan da se on prepise!!!!
                }
                else
                {
                    if (o.NastavnikOdeljenjes.SingleOrDefault(x => x.NastavnikId_zaposlenog == z.Id_zaposlenog) != null)
                        return false;
                    o.NastavnikOdeljenjes.Add(new NastavnikOdeljenje() { Nastavnik = z as Nastavnik, Odeljenje = o, NastavnikId_zaposlenog = z.Id_zaposlenog, OdeljenjeId_odeljenja = o.Id_odeljenja, Razredni = false });
                    
                }

                db.SaveChanges();
                return true;
            }
        }
        public bool ChangeOdeljenje(OdeljenjeIM odeljenje)
        {
            Odeljenje o = dao.FindById(odeljenje.Id_odeljenja);
            o.razred = odeljenje.razred;
            return dao.Update(o);
        }

        public Odeljenje FindById(int id)
        {
            return dao.FindById(id);
        }

        public List<OdeljenjeIM> GetOdeljenja()
        {
            List<Odeljenje> list = dao.GetAll();
            List<OdeljenjeIM> retVal = new List<OdeljenjeIM>();

            foreach(var item in list)
            {
                if(item.Ucitelj != null)
                    retVal.Add(new OdeljenjeIM() { razred = item.razred, Id_odeljenja = item.Id_odeljenja, Razredni = item.Ucitelj.ime});
                else if(item.NastavnikOdeljenjes.Count != 0)
                {
                    if(item.NastavnikOdeljenjes.Any(x=>x.Razredni == true))
                        retVal.Add(new OdeljenjeIM() { razred = item.razred, Id_odeljenja = item.Id_odeljenja, Razredni = item.NastavnikOdeljenjes.ToList().Find(n => n.Razredni == true).Nastavnik.ime });
                    else
                        retVal.Add(new OdeljenjeIM() { razred = item.razred, Id_odeljenja = item.Id_odeljenja });
                }
                else
                    retVal.Add(new OdeljenjeIM() { razred = item.razred, Id_odeljenja = item.Id_odeljenja, Razredni = ""});
            }
            return retVal;
        }

        public bool DeleteOdeljenje(OdeljenjeIM odeljenje)
        {
            return dao.Delete(odeljenje.Id_odeljenja);
        }

        public bool ValidateUciteljExistance(int id)
        {
            return dao.ValidateUciteljExistance(id);
        }

        public List<OdeljenjeIM> GetOdeljenjeByRazred(short razred)
        {
            List<Odeljenje> lista = dao.GetAll().Where(x=>x.razred == razred).ToList();
            List<OdeljenjeIM> retVal = new List<OdeljenjeIM>();
            foreach(var item in lista)
            {
                if (item.Ucitelj != null)
                    retVal.Add(new OdeljenjeIM() { razred = item.razred, Id_odeljenja = item.Id_odeljenja, Razredni = item.Ucitelj.ime });
                else if (item.NastavnikOdeljenjes.Count != 0)
                    retVal.Add(new OdeljenjeIM() { razred = item.razred, Id_odeljenja = item.Id_odeljenja, Razredni = item.NastavnikOdeljenjes.ToList().Find(n => n.Razredni == true).Nastavnik.ime });
                else
                    retVal.Add(new OdeljenjeIM() { razred = item.razred, Id_odeljenja = item.Id_odeljenja, Razredni = "" });
            }
            return retVal;
        }

        public List<OdeljenjeIM> GetOdeljenjaForZaposleni(int zaposleniID)
        {
            List<Odeljenje> lista = dao.GetOdeljenjaForZaposleni(zaposleniID);
            List<OdeljenjeIM> retVal = new List<OdeljenjeIM>();

            foreach (var item in lista)
            {
                if (item.Ucitelj != null)
                    retVal.Add(new OdeljenjeIM() { razred = item.razred, Id_odeljenja = item.Id_odeljenja, Razredni = item.Ucitelj.ime });
                else if (item.NastavnikOdeljenjes.Count != 0)
                    retVal.Add(new OdeljenjeIM() { razred = item.razred, Id_odeljenja = item.Id_odeljenja, Razredni = item.NastavnikOdeljenjes.ToList().Find(n => n.Razredni == true).Nastavnik.ime });
                else
                    retVal.Add(new OdeljenjeIM() { razred = item.razred, Id_odeljenja = item.Id_odeljenja, Razredni = "" });
            }

            return retVal;
        }
    }
}
