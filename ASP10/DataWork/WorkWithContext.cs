﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DataWork
{
    public static class WorkWithContext
    {
        
        static public IEnumerable<Models.Respons> GetRespons()
        {
            Models.Context context = new Models.Context();
            return context.Respons.ToList();
        }
        static public void SendRespons(Models.Respons respons)
        {
            Models.Context context = new Models.Context();
            context.Respons.Add(respons);
            context.SaveChanges();
        }
        static public IEnumerable<Models.Form> GetForm()
        {
            Models.Context context = new Models.Context();
            return context.Forms.ToList();
        }
        static public void SendForm(Models.Form form)
        {
            Models.Context context = new Models.Context();
            context.Forms.Add(form);
            context.SaveChanges();
        }
        static public IEnumerable<Models.Article> GetSpliteArticles()
        {
            Models.Context context = new Models.Context();
            IList<Models.Article> articles = context.Articles.ToList();
            for(int i = 0; i < articles.Count; i++)
            {
                articles[i].Text = articles[i].Text.Remove(200);
            }
            return articles.ToArray();
        }
        static public Models.Article GetArticle(int Id)
        {
            Models.Context context = new Models.Context();
            var articles = context.Articles.Include(m => m.Tegs).FirstOrDefault(z => z.Id == Id);
            return articles;
        }
    }
}
