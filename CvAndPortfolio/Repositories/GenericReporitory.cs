using CvAndPortfolio.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CvAndPortfolio.Repositories
{
    public class GenericReporitory<Table> where Table : class, new()
    {
        PortfolioAndCvEntities2 db = new PortfolioAndCvEntities2();

        public List<Table> List()
        {
            return db.Set<Table>().ToList();
        }

        public void Add(Table value)
        {
            db.Set<Table>().Add(value);
            db.SaveChanges();
        }

        public void Delete(Table value)
        {
            db.Set<Table>().Remove(value);
            db.SaveChanges();
        }

        public void Update(Table value)
        {
            db.SaveChanges();
        }

        public Table Get(int id)
        {
            return db.Set<Table>().Find(id);
            
        }
        public Table Find(Expression<Func<Table, bool>> where)
        {
            return db.Set<Table>().FirstOrDefault(where);
        }

        public List<Table> Take(int p)
        {
            return db.Set<Table>().Take(p).ToList();
        }

    }
}