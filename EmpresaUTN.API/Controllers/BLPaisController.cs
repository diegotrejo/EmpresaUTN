using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmpresaUTN.Modelos;

namespace EmpresaUTN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BLPaisController : ControllerBase
    {
        private readonly DataContext _context;

        public BLPaisController(DataContext context)
        {
            _context = context;
        }

        // GET: api/DALPais
        [Route("/BL/AreaTotal")]
        [HttpGet]
        public ActionResult<int> AreaTotal()
        {
          if (_context.Paises == null)
          {
              return NotFound();
          }
            return  _context.Provincias.Sum( p => p.Area );
        }

    }
}
