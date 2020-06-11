using OsnovnaSkola;
using OsnovnaSkola.DataAccess;
using OsnovnaSkolaPL.Interfaces;
using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.Services
{
    public class ZaposleniService : IZaposleni
    {
        ZaposleniciDAO dao = new ZaposleniciDAO();

        string adminIme = "admin";
        string adminPrezime = "admin";

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
            return dao.Delete(idZaposlenog);
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
                        Ucitelj = (item is Ucitelj)
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
    }
}
