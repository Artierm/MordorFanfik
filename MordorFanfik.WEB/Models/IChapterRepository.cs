using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MordorFanfik.WEB.Models
{
    interface IChapterRepository
    {
        public void Create(Chapter item);
        public Chapter GetChapterById(int id);
        public Chapter GetChapterByName(string name);
        public void Update(Chapter chapter);
        public void DeleteById(int id);

        public void DeleteByName(string name);

        public IEnumerable<Chapter> GetAllChapters(Creation creation);
    }
}
