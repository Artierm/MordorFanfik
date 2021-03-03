using Microsoft.EntityFrameworkCore;
using MordorFanfik.WEB.Data;
using MordorFanfik.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MordorFanfik.WEB.Repositories
{
    public class ChapterRepository : IChapterRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ChapterRepository()
        {
            dbContext = new ApplicationDbContext();
        }
        public void Create(Chapter item)
        {
            dbContext.Chapters.Add(item);
            dbContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var chapter = dbContext.Chapters.Find(id);
            if (chapter != null)
            {
                dbContext.Chapters.Remove(chapter);
                dbContext.SaveChanges();
            }
        }

        public void DeleteByName(string name)
        {
            var chapter = dbContext.Chapters.FirstOrDefault(cr => cr.NameChapter == name);
            if (chapter != null)
            {
                dbContext.Chapters.Remove(chapter);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Chapter> GetAllChapters(Creation creation)
        {
            return dbContext.Chapters.Where(cr => cr.CreationId == creation);
        }

        public Chapter GetChapterById(int id)
        {
            return dbContext.Chapters.FirstOrDefault(cr => cr.Id == id);
        }

        public Chapter GetChapterByName(string name)
        {
            return dbContext.Chapters.FirstOrDefault(cr => cr.NameChapter == name);
        }

        public Chapter GetChapterByNumber(int number)
        {
            return dbContext.Chapters.FirstOrDefault(cr => cr.NumberChapter == number);
        }

        public void Update(Chapter chapter)
        {
            dbContext.Chapters.Update(chapter);
            dbContext.SaveChanges();
        }
    }
}
