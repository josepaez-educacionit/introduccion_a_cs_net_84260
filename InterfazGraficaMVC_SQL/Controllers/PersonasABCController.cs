using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InterfazGraficaMVC_SQL.Entities;

public class PersonasABCController : Controller
{
    private readonly DemoNET_84260Context _context;

    public PersonasABCController(DemoNET_84260Context context)
    {
        _context = context;
    }

    // GET: PERSONASABC
    public async Task<IActionResult> Index()
    {
        return View(await _context.Personas.ToListAsync());
    }

    // GET: PERSONASABC/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var persona = await _context.Personas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (persona == null)
        {
            return NotFound();
        }

        return View(persona);
    }

    // GET: PERSONASABC/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: PERSONASABC/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Edad,Email")] Persona persona)
    {
        if (ModelState.IsValid)
        {
            _context.Add(persona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(persona);
    }

    // GET: PERSONASABC/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var persona = await _context.Personas.FindAsync(id);
        if (persona == null)
        {
            return NotFound();
        }
        return View(persona);
    }

    // POST: PERSONASABC/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Nombre,Apellido,Edad,Email")] Persona persona)
    {
        if (id != persona.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(persona);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(persona.Id))
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
        return View(persona);
    }

    // GET: PERSONASABC/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var persona = await _context.Personas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (persona == null)
        {
            return NotFound();
        }

        return View(persona);
    }

    // POST: PERSONASABC/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var persona = await _context.Personas.FindAsync(id);
        if (persona != null)
        {
            _context.Personas.Remove(persona);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PersonaExists(int? id)
    {
        return _context.Personas.Any(e => e.Id == id);
    }
}
