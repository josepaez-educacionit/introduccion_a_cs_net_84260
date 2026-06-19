using InterfazGraficaMVC.Data;
using InterfazGraficaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterfazGraficaMVC.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            var personas = PersonaRepository.ObtenerTodas();

            return View(personas);
        }

        public IActionResult Details(int id)
        {
            var persona = PersonaRepository.ObtenerPorId(id);

            if (persona is null)
            {
                return NotFound();
            }

            return View(persona);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Persona persona)
        {
            if (PersonaRepository.ExisteEmail(persona.Email))
            {
                ModelState.AddModelError(nameof(Persona.Email), "Ya existe una persona con ese email.");
            }

            if (!ModelState.IsValid)
            {
                return View(persona);
            }

            PersonaRepository.Crear(persona);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var persona = PersonaRepository.ObtenerPorId(id);

            if (persona is null)
            {
                return NotFound();
            }

            return View(persona);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Persona persona)
        {
            if (id != persona.Id)
            {
                return BadRequest();
            }

            if (PersonaRepository.ExisteEmail(persona.Email, persona.Id))
            {
                ModelState.AddModelError(nameof(Persona.Email), "Ya existe otra persona con ese email.");
            }

            if (!ModelState.IsValid)
            {
                return View(persona);
            }

            var actualizado = PersonaRepository.Actualizar(persona);

            if (!actualizado)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var persona = PersonaRepository.ObtenerPorId(id);

            if (persona is null)
            {
                return NotFound();
            }

            return View(persona);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var eliminado = PersonaRepository.Eliminar(id);

            if (!eliminado)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
