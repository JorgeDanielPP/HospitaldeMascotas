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

        [HttpGet]
        public IActionResult Nuevo()
        {
           return View();
        }

        [HttpPost]
        public async Task<IActionResult> Nuevo(Mascota mascota)
        {
            await _appDbContext.Mascota.AddAsync(mascota);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Lista));
        }

    }
}
