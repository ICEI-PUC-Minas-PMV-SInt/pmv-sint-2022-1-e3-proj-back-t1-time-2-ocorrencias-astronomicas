using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AstroCal.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace AstroCal.Controllers
{
    [Authorize]
    public class GaleriaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private string _filePath;

        public GaleriaController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _filePath = env.WebRootPath;
            _context = context;
        }

        // GET: Galeria
        public async Task<IActionResult> Index()
        {
            return View(await _context.Galeria.ToListAsync());
        }

        // GET: Galeria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galeria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galeria == null)
            {
                return NotFound();
            }

            return View(galeria);
        }

        // GET: Galeria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Galeria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Foto")] Galeria galeria, IFormFile anexo)
        {
            if (ModelState.IsValid)
            {
                if (!ValidaImagem(anexo))
                    return View(galeria);

                var nome = SalvarArquivo(anexo);
                galeria.Foto = nome;

                _context.Add(galeria);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(galeria);

        }

        public string SalvarArquivo(IFormFile anexo)
        {
            var nome = Guid.NewGuid().ToString() + anexo.FileName;

            var filePath = _filePath + "\\fotos";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            using (var stream = System.IO.File.Create(filePath + "\\" + nome))
            {
                anexo.CopyToAsync(stream);
            }
            return nome;

        }

        public bool ValidaImagem(IFormFile anexo)
        {
            switch (anexo.ContentType)
            {

                case "image/jpeg":
                    return true;

                case "image/bpm":
                    return true;

                case "image/gif":
                    return true;

                case "image/png":
                    return true;

                default:
                    return false;
                    break;
            }

        }

        // GET: Galeria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galeria.FindAsync(id);
            if (galeria == null)
            {
                return NotFound();
            }
            return View(galeria);
        }

        // POST: Galeria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Foto")] Galeria galeria)
        {
            if (id != galeria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(galeria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GaleriaExists(galeria.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(galeria);
        }

        // GET: Galeria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galeria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galeria == null)
            {
                return NotFound();
            }

            return View(galeria);
        }

        // POST: Galeria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var galeria = await _context.Galeria.FindAsync(id);
            string filePathName = _filePath + "\\fotos\\" + galeria.Foto;

            if(System.IO.File.Exists(filePathName))
                System.IO.File.Delete(filePathName);    

            _context.Galeria.Remove(galeria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GaleriaExists(int id)
        {
            return _context.Galeria.Any(e => e.Id == id);
        }
    }
}
