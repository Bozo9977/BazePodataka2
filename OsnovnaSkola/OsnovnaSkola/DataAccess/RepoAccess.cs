using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkola.DataAccess
{
    public abstract class RepoAccess<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public RepoAccess()
        {

        }

        public virtual bool Delete(object id)
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                try
                {
                    DbSet<TEntity> dbSet = db.Set<TEntity>();
                    TEntity entityToDelete = db.Set<TEntity>().Find(id);
                    db.Entry(entityToDelete).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Message:\n"+e.Message + "\n\nTrace:\n"+e.StackTrace+"\n\nInner:\n"+e.InnerException);
                    return false;
                }
                
            }
        }

        public virtual TEntity FindById(object id)
        {
            
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                return db.Set<TEntity>().Find(id);
            }
        }

        public virtual List<TEntity> GetAll()
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                return db.Set<TEntity>().ToList();
            }
        }

        public bool Insert(TEntity entity)
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                try
                {
                    db.Set<TEntity>().Add(entity);
                    db.SaveChanges();
                    return true;
                }catch(Exception e)
                {
                    Console.WriteLine("Message:\n" + e.Message + "\n\nTrace:\n" + e.StackTrace + "\n\nInner:\n" + e.InnerException);
                    return false;
                }
                
            }
            //return true;
        }

        public bool Update(TEntity entityToUpdate)
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                try
                {
                    db.Set<TEntity>().Attach(entityToUpdate);
                    db.Entry(entityToUpdate).State = EntityState.Modified;
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
    }
}
