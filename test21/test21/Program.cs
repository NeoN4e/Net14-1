using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace test21
{
    class Program
    {
        public class Blog
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }

            public virtual List<Post> Posts { get; set; }
        }

        public class Post
        {
            [Key]
            public int Id {get;set;}
            public string Title {get;set;}
            public string Content { get; set; }
            public DateTime Date { get; set; }

            public virtual Blog Blog { get; set; }
        }

        public class BlogContext: DbContext
        {
            public DbSet<Blog> Blogs{get;set;}
            public DbSet<Post> Posts { get; set; }
        }

        
        static void Main(string[] args)
        {
            BlogContext db = new BlogContext();

            db.Blogs.Add( new Blog() { Name = "123" });
            db.SaveChanges();

            foreach (var item in db.Blogs.ToList<Blog>())
            {
                Console.WriteLine(item.Name);
            }

            //Console.WriteLine(db.Blogs.Lo);
           // DbConnection db = new DbConnection(){ }
            //SqlConnection db = new SqlConnection(
            //"Server=localhost;Database=library;Trusted_Connection=True;"
            ////"Server=localhost;Database=library;User Id=sa;Password=qwerty;"
            //);
            //try
            //{
            //    db.Open();
            //    Console.WriteLine(db.State.ToString());

            //    SqlCommand cmd = db.CreateCommand();
            //    cmd.CommandText ="Select * from books";
            //    foreach (var item in cmd.ExecuteReader())
            //    {
            //        Console.WriteLine(item.GetType().GetProperty("Name") );
            //    }
                
            //}
            //catch (Exception ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(ex.Message);
            //}


        }
    }
}
