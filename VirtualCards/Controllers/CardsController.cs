using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VirtualCards.Data;
using VirtualCards.DTO;
using VirtualCards.Models;

namespace VirtualCards.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly VirtualCardsContext _context;

        public CardsController(VirtualCardsContext context)
        {
            _context = context;
        }


        [HttpGet("get-by-email")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Cards>> GetCardsByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return NotFound();
            }

            var cards = await _context.Cards
                .Where(x => x.Email == email)
                .OrderBy(x => x.DtCriacao)
                .ToListAsync();

            if (cards == null)
            {
                return NotFound();
            }

            return base.Ok(cards);
        }

 
        [HttpPost("post-cards")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<Cards>> PostCards(CardsDTO cards)
        {
            Random numero = new Random();
            Cards card = new Cards();

            card.DtCriacao = DateTime.Now;
            card.Email = cards.Email;
            card.Numero = numero.Next(1000, 9999).ToString();

            _context.Cards.Add(card);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostCards", new { Id = card.Id }, card.Numero);


        }
    }
}
