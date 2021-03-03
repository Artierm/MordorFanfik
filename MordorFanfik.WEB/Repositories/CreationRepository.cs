using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MordorFanfik.WEB.Data;
using MordorFanfik.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MordorFanfik.WEB.Repositories
{
    public class CreationRepository : ICreationRepository
    {

        private readonly ApplicationDbContext dbContext;

        public CreationRepository()
        {
            dbContext = new ApplicationDbContext();
        }
        public void Create(Creation item)
        {
            dbContext.Creations.Add(item);
            dbContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var creation  = dbContext.Creations.Find(id);
            if (creation != null)
            {
                dbContext.Creations.Remove(creation);
                dbContext.SaveChanges();
            }       
        }

        public void DeleteByName(string name)
        {
            var creation = dbContext.Creations.FirstOrDefault(cr => cr.NameCreation == name);
            if (creation != null)
            {
                dbContext.Creations.Remove(creation);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Creation> GetAllCreationByAuthor(IdentityUser identityUser)
        {
           return dbContext.Creations.Where(cr => cr.UserId == identityUser);
        }

        public IEnumerable<Creation> GetAllCreations()
        {
            return dbContext.Creations;
        }

        public Creation GetCreationById(int id)
        {
            return dbContext.Creations.FirstOrDefault(cr => cr.Id == id);
        }

        public Creation GetCreationByName(string name)
        {
            return dbContext.Creations.FirstOrDefault(cr => cr.NameCreation == name);
        }

        public void Update(Creation creation)
        {
            dbContext.Creations.Update(creation);
            dbContext.SaveChanges();
        }
    }
}
