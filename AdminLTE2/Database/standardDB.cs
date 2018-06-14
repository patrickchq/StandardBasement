using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AdminLTE2.Models;

namespace AdminLTE2.Database
{
    public class standardDB:DbContext
    {
        public standardDB() : base("mainDB")
        {

        }
        public DbSet<ULStandard> ULstandards { get; set; }
        public DbSet<IECStandard> IECStandards { get; set; }
    }
}