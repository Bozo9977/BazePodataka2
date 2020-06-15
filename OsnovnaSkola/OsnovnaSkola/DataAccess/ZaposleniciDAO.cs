using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace OsnovnaSkola.DataAccess
{
    public class ZaposleniciDAO: RepoAccess<Zaposleni>
    {
        public bool AddPredmetToZaposleni(int zaposleniID, int predmetID)
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                try
                {
                    Nastavnik n = db.Zaposlenici.Find(zaposleniID) as Nastavnik;
                    Predmet p = db.Predmeti.Find(predmetID);

                    n.Predmet = p;

                    db.Entry(n).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Message:\n" + e.Message + "\n\nTrace:\n" + e.StackTrace + "\n\nInner:\n" + e.InnerException);
                    return false;
                }
                
            }
        }

        public bool ValidatePredmetAdding(int zaposleniID)
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                Nastavnik n = (db.Zaposlenici.Find(zaposleniID) as Nastavnik);
                return (db.Zaposlenici.Find(zaposleniID) as Nastavnik).Predmet != null;
            }
        }


        public bool DodajKontrolnuTackuUcenicima(int idUcenika, int idZaposlenog, int idKontrolneTacke, short ocena)
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                Zaposleni z = db.Zaposlenici.Find(idZaposlenog);
                Kontrolna_tacka k = db.Kontrolna_tacka.Find(idKontrolneTacke);
                Ucenik u = db.Ucenici.Find(idUcenika);

                ObjectParameter success = new ObjectParameter("success", typeof(bool));

                if(u!=null && k!=null && z!=null )
                {
                    z.Radovi.Add(new Radi() { Kontrolna_tackaId_kontrolne_tacke = idKontrolneTacke, ocena = ocena, UcenikId_ucenika = idUcenika, ZaposleniId_zaposlenog = z.Id_zaposlenog });
                    db.Entry(z).State = EntityState.Modified;
                    db.SaveChanges();

                    db.DodajKontrolnuTackuUceniku(idUcenika, idKontrolneTacke, idZaposlenog, ocena, success);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        
    }
}
