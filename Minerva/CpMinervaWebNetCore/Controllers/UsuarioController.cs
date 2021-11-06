using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CpMinervaWebNetCore.Models;

namespace CpMinervaWebNetCore.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly MinervaContext _context;

        public UsuarioController(MinervaContext context)
        {
            _context = context;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            var minervaContext = _context.Usuarios.Include(u => u.IdEmpleadoNavigation);
            return View(await minervaContext.ToListAsync());
        }

        // GET: Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            var empleados = _context.Empleados.Select(x => new { Id = x.Id, NombreCompleto = $"{x.Nombres} {x.Paterno} {x.Materno}" }).ToList();
            ViewData["IdEmpleado"] = new SelectList(empleados, "Id", "NombreCompleto");
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Usuario1,Clave,IdEmpleado,UsuarioRegistro,FechaRegistro,RegistroActivo")] Usuario usuario)
        {
            usuario.Clave = Utils.Encrypt(usuario.Clave);
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var empleados = _context.Empleados.Select(x => new { Id = x.Id, NombreCompleto = $"{x.Nombres} {x.Paterno} {x.Materno}" }).ToList();
            ViewData["IdEmpleado"] = new SelectList(empleados, "Id", "NombreCompleto", usuario.IdEmpleado);
            return View(usuario);
        }

        // GET: Usuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            var empleados = _context.Empleados.Select(x => new { Id = x.Id, NombreCompleto = $"{x.Nombres} {x.Paterno} {x.Materno}" }).ToList();
            ViewData["IdEmpleado"] = new SelectList(empleados, "Id", "NombreCompleto", usuario.IdEmpleado);
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Usuario1,Clave,IdEmpleado,UsuarioRegistro,FechaRegistro,RegistroActivo")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
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
            var empleados = _context.Empleados.Select(x => new { Id = x.Id, NombreCompleto = $"{x.Nombres} {x.Paterno} {x.Materno}" }).ToList();
            ViewData["IdEmpleado"] = new SelectList(empleados, "Id", "NombreCompleto", usuario.IdEmpleado);
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
