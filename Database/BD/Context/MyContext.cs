using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Context
{
    class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> data) : base(data) { }
    }
}
