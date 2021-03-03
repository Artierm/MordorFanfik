using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MordorFanfik.WEB.Models
{
    public interface ICreationRepository
    {
        public void Create(Creation item);
        public Creation GetCreationById(int id);
        public Creation GetCreationByName(string name);

        public IEnumerable<Creation> GetAllCreationByAuthor(IdentityUser identityUser);
        public void Update(Creation creation);
        public void DeleteById(int id);

        public void DeleteByName(string name);

        public IEnumerable<Creation> GetAllCreations();
    }
}
