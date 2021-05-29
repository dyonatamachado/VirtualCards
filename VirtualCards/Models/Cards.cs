using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualCards.Models
{
    public class Cards
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime DtCriacao { get; set; }
        public string Email { get; set; }
    }
}
