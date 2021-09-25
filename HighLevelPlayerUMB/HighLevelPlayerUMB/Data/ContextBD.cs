using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HighLevelPlayerUMB.Models;

namespace HighLevelPlayerUMB.Data
{
    public class ContextBD : DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options) : base(options) 
        {
            
        }
        public DbSet<Jugadores> jugadores { get; set; }
    }
}
