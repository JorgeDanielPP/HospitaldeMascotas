using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using HospitaldeMascotas.Data;
using HospitaldeMascotas.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitaldeMascotas.Controllers
{
    public class MascotaController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public MascotaController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            List<Mascota> lista = await _appDbContext.Mascota.ToListAsync();  
          return View(lista);
        }
       
    }
}
