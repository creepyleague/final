using Microsoft.Analytics.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

namespace final_project
{
    public class BookContext : DbContext

    {
        public BookContext() { }

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public Dbset<Book> books { get; set; }
        public Dbset<Review> Reviews { get; set; }

        protected override void Onconfiguring(DbcontextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Final; Integrated security=Ture"
                );
        }

        protected override void OnModelCreating(ModuleBuilder moduleBuilder)
        {
            moduleBuilder.Entity<Book>().HasData();
            new Book
            {
                Id = 1,
                Isbn = "9780140430721 ",
                AuthorName = "Jane Austen",
                BookName = "pride and Perjudice",
                PublishYear = 1831,
                img = ;
            },
              new Book
            {
                Id = 2,
                Isbn = "9780140430721 ",
                AuthorName = "Jane Austen",
                BookName = "Sense and sensibillty",
                PublishYear = 1811,
                img = ;
            },  new Book
            {
                Id = 3,
                Isbn = "9780140430721 ",
                AuthorName = "Jane Austen",
                BookName = "Emma",
                PublishYear = 1851,
                img = ;
            },
                  new Book
                  {
                      Id = 4,
                      Isbn = "9780140430721 ",
                      AuthorName = "Jane Austen",
                      BookName = "Persuasion",
                      PublishYear = 1831,
                      img = ;
            },


        }

        }

                }
        }
    }
}