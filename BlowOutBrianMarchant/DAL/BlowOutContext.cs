using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlowOutBrianMarchant.Models;
using System.Data.Entity;

namespace BlowOutBrianMarchant.DAL
{
    public class BlowOutContext : DbContext
    {
        public BlowOutContext() : base("BlowOutContext")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Instrument> Instruments { get; set; } 


    }
}