using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtualCards.Models;

namespace VirtualCards.Data
{
    public class VirtualCardsContext : DbContext
    {
        public VirtualCardsContext (DbContextOptions<VirtualCardsContext> options)
            : base(options)
        {
        }

        public DbSet<VirtualCards.Models.Cards> Cards { get; set; }
    }
}
