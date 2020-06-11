using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OsnovnaSkola.DataAccess
{
    public class PredavanjeDAO: RepoAccess<Predavanje>
    {
        //public Predavanje FindById(int id)
        //{
        //    using(var db = new ModelOsnovnaSkolaContainer())
        //    {
        //        return db.Predavanja.Find(id);
        //    }
        //}

        //public List<Predavanje> GetAll()
        //{
        //    using(var db = new ModelOsnovnaSkolaContainer())
        //    {
        //        return db.Predavanja.ToList();
        //    }
        //}


        //public void Insert(Predavanje predavanje)
        //{
        //    using (var db = new ModelOsnovnaSkolaContainer())
        //    {
        //        db.Predavanja.Add(predavanje);
        //        db.SaveChanges();
        //    } 
        //}

        //public void Delete(int id)
        //{
        //    using (var db = new ModelOsnovnaSkolaContainer())
        //    {
        //        Predavanje predavanje = db.Predavanja.Find(id);
        //        db.Entry(predavanje).State = EntityState.Deleted;
        //        db.SaveChanges();
        //    }
        //}

        //public void Update(Predavanje predavanje)
        //{
        //    using (var db = new ModelOsnovnaSkolaContainer())
        //    {
        //        db.Entry(predavanje).State = EntityState.Modified;
        //        db.SaveChanges();
        //    }
        //}

        public List<Predavanje> FindByZaposleniId(int idZaposlenog)
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                Zaposleni zaposleni = db.Zaposlenici.Find(idZaposlenog);
                if(zaposleni != null)
                {
                    return zaposleni.Predavanja.ToList();
                }
                return new List<Predavanje>();
            }
        }
    }
}
