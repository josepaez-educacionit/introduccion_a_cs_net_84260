using InterfazGraficaMVC.Models;

namespace InterfazGraficaMVC.Data
{
    public class PersonaRepository
    {
        private static readonly List<Persona> Personas =
    [
        new Persona
        {
            Id = 1,
            Nombre = "Ana",
            Apellido = "Gómez",
            Edad = 28,
            Email = "ana.gomez@email.com"
        },
        new Persona
        {
            Id = 2,
            Nombre = "Luis",
            Apellido = "Pérez",
            Edad = 35,
            Email = "luis.perez@email.com"
        }
    ];

        private static int _ultimoId = Personas.Max(p => p.Id);

        public static List<Persona> ObtenerTodas()
        {
            return Personas;
        }

        public static Persona? ObtenerPorId(int id)
        {
            return Personas.FirstOrDefault(p => p.Id == id);
        }


        public static void Crear(Persona persona)
        {
            _ultimoId++;
            persona.Id = _ultimoId;
            Personas.Add(persona);
        }

        public static bool Actualizar(Persona persona)
        {
            var personaExistente = ObtenerPorId(persona.Id);

            if (personaExistente is null)
            {
                return false;
            }

            personaExistente.Nombre = persona.Nombre;
            personaExistente.Apellido = persona.Apellido;
            personaExistente.Edad = persona.Edad;
            personaExistente.Email = persona.Email;

            return true;
        }

        public static bool Eliminar(int id)
        {
            var persona = ObtenerPorId(id);

            if (persona is null)
            {
                return false;
            }

            Personas.Remove(persona);
            return true;
        }

        public static bool ExisteEmail(string email, int? idExcluir = null)
        {
            return Personas.Any(p =>
                p.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                && (!idExcluir.HasValue || p.Id != idExcluir.Value));
        }
    }
}

