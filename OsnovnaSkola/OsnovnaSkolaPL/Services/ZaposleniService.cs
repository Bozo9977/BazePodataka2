using OsnovnaSkola;
using OsnovnaSkola.DataAccess;
using OsnovnaSkolaPL.Interfaces;
using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OsnovnaSkolaPL.Services
{
    public class ZaposleniService : IZaposleni
    {
        ZaposleniciDAO dao = new ZaposleniciDAO();

        string adminIme = "admin";
        string adminPrezime = "admin";

        public bool AddPredmetToZaposleni(ZaposleniIM zaposleni, PredmetIM predmet)
        {
            return dao.AddPredmetToZaposleni(zaposleni.Id_zaposlenog, predmet.Id_predmeta);
        }

        public bool AddZaposleni(ZaposleniIM zaposleni)
        {
            Zaposleni z = null;
            if (zaposleni.Ucitelj)
            {
                z = new Ucitelj()
                {
                    ime = zaposleni.ime,
                    prezime = zaposleni.prezime,
                    zvanje = zaposleni.zvanje
                };
            }
            else
            {
                z = new Nastavnik()
                {
                    ime = zaposleni.ime,
                    prezime = zaposleni.prezime,
                    zvanje = zaposleni.zvanje
                };
            }
            
            return dao.Insert(z);
        }

        public bool ChangeZaposleni(ZaposleniIM zaposleniToChange)
        {
            Zaposleni z = dao.FindById(zaposleniToChange.Id_zaposlenog);
            z.ime = zaposleniToChange.ime;
            z.prezime = zaposleniToChange.prezime;
            z.zvanje = zaposleniToChange.zvanje;
            return dao.Update(z);
        }

        public bool DeleteZaposleni(int idZaposlenog)
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                Zaposleni z = db.Zaposlenici.Find(idZaposlenog);
                if(z is Ucitelj)
                {
                    List<Cas> casovi = db.Cas.Where(x => x.ZaposleniId_zaposlenog == idZaposlenog).ToList();
                   
                    foreach(var c in casovi)
                    {
                        db.Entry(c).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    List<Predavanje> predavanja = db.Predavanja.Where(x => x.ZaposleniId_zaposlenog == idZaposlenog).ToList();

                    foreach(var p in predavanja)
                    {
                        db.Entry(p).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    List<Radi> radovi = db.Rade.Where(x => x.ZaposleniId_zaposlenog == idZaposlenog).ToList();

                    foreach (var item in radovi)
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    List<Kontrolna_tacka> kts = db.Kontrolna_tacka.Where(x => x.ZaposleniId_zaposlenog == idZaposlenog).ToList();

                    foreach(var kt in kts)
                    {
                        db.Entry(kt).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    List<Prisustvo> prisustva = db.Prisustva.Where(x => x.ZaposleniId_zaposlenog == idZaposlenog).ToList();

                    foreach(var item in prisustva)
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    

                    db.Entry(z).State = EntityState.Deleted;
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    List<NastavnikOdeljenje> no = db.NastavnikOdeljenjes.Where(x => x.NastavnikId_zaposlenog == idZaposlenog).ToList();

                    foreach(var item in no)
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    List<Cas> casovi = db.Cas.Where(x => x.ZaposleniId_zaposlenog == idZaposlenog).ToList();
                    foreach (var c in casovi)
                    {
                        db.Entry(c).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    List<Predavanje> predavanja = db.Predavanja.Where(x => x.ZaposleniId_zaposlenog == idZaposlenog).ToList();

                    foreach (var p in predavanja)
                    {
                        db.Entry(p).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    List<Radi> radovi = db.Rade.Where(x => x.ZaposleniId_zaposlenog == idZaposlenog).ToList();
                    foreach (var item in radovi)
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    List<Kontrolna_tacka> kts = db.Kontrolna_tacka.Where(x => x.ZaposleniId_zaposlenog == idZaposlenog).ToList();
                    foreach (var kt in kts)
                    {
                        db.Entry(kt).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    List<Prisustvo> prisustva = db.Prisustva.Where(x => x.ZaposleniId_zaposlenog == idZaposlenog).ToList();

                    foreach (var item in prisustva)
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    

                   

                    db.Entry(z).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public bool DodeliKontrolneTackeUcenicima(int idZaposlenog, int idOdeljenja, short ocena)
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                Odeljenje o = db.Odeljenja.Include(s => s.Ucenici).SingleOrDefault(x => x.Id_odeljenja == idOdeljenja);
                Kontrolna_tacka k = db.Kontrolna_tacka.ToList().LastOrDefault();
                int idKontrolneTacke = k.Id_kontrolne_tacke;

                if (o != null)
                {
                    foreach(var item in o.Ucenici)
                    {
                        dao.DodajKontrolnuTackuUcenicima(item.Id_ucenika, idZaposlenog, idKontrolneTacke, ocena);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<ZaposleniIM> GetZaposleni()
        {
            try
            {
                List<Zaposleni> zaposleni = dao.GetAll();
                List<ZaposleniIM> retVal = new List<ZaposleniIM>();
                foreach(var item in zaposleni)
                {
                    retVal.Add(new ZaposleniIM()
                    {
                        ime = item.ime,
                        zvanje = item.zvanje,
                        prezime = item.prezime,
                        Id_zaposlenog = item.Id_zaposlenog,
                        Ucitelj = (item is Ucitelj),
                        Nastavnik = !(item is Ucitelj)
                    }) ;
                }
                return retVal;
            }catch(Exception e)
            {
                Console.WriteLine("Msssage: "+e.Message + "\n\nTrace:\n"+e.StackTrace);
                return new List<ZaposleniIM>();
            }
            
        }

        public ZaposleniIM Login(string ime, string prezime)
        {
            
            if (ime != adminIme || prezime != adminPrezime)
            {
                List<Zaposleni> zaposleni = dao.GetAll();
                Zaposleni existing = zaposleni.SingleOrDefault(x => x.ime.ToLower() == ime.ToLower() && x.prezime.ToLower() == prezime.ToLower());
                if(existing != null)
                {
                    if(existing is Ucitelj)
                    {
                        return new ZaposleniIM()
                        {
                            ime = existing.ime,
                            prezime = existing.prezime,
                            zvanje = existing.zvanje,
                            Id_zaposlenog = existing.Id_zaposlenog,
                            Ucitelj = true
                        };
                    }
                    else
                    {
                        return new ZaposleniIM()
                        {
                            ime = existing.ime,
                            prezime = existing.prezime,
                            zvanje = existing.zvanje,
                            Id_zaposlenog = existing.Id_zaposlenog,
                            Ucitelj = false
                        };
                    }
                }
                else
                {
                    return new ZaposleniIM();
                }
                
            }
            else
            {
                ZaposleniIM admin = new ZaposleniIM() {
                    ime = adminIme,
                    prezime = adminPrezime,
                    zvanje = "administratorSistema",
                    Id_zaposlenog = 0 };
                return admin;
            }
                
        }

        public bool ValidatePredmetAdding(int nastavnikID)
        {
            return dao.ValidatePredmetAdding(nastavnikID);
        }
    }
}
