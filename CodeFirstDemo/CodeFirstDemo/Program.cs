using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace CodeFirstDemo
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address{ get; set; }
    }

    public class BlogDbContext :DbContext
    {
        public DbSet<Post> Posts { get; set; }
}

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
