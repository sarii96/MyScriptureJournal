using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyScriptureJournal.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "Alma",
                        Chapter = "12",
                        Verses = "1-4",
                        Notes = "Nothing",
                        CreatedDate = DateTime.Parse("1989-2-12")
                    },

                    new Scripture
                    {
                        Book = " 1 Nephi",
                        Chapter = "6",
                        Verses = "10-17",
                        Notes = "Nothing",
                        CreatedDate = DateTime.Parse("1989-2-12")
                
                    },

                    new Scripture
                    {
                        Book = "Alma",
                        Chapter = "22",
                        Verses = "1-10",
                        Notes = "Nothing",
                        CreatedDate = DateTime.Parse("1989-2-12")

                    },

                    new Scripture
                    {
                        Book = "Alma",
                        Chapter = "30",
                        Verses = "22-30",
                        Notes = "Nothing",
                        CreatedDate = DateTime.Parse("1989-2-12")

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
