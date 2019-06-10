using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class DatabaseContext: DbContext
    {
        public static DatabaseContext instance;
        public static DatabaseContext getInstance()
        {
            return instance;
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            instance = this;
        }

    }
}
