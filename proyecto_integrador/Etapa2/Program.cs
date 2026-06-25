namespace Etapa2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bienvenidos al proyecto integrador Etapa 2");

			string Nombre;
			string Apellido;
			int Edad;
			string Email;

			string Respuesta;

			// Ingreso de datos del alumno
			Console.WriteLine("Ingrese su nombre: ");
			Nombre = Console.ReadLine();
			Console.WriteLine("");

			Console.WriteLine("Ingrese su apellido: ");
			Apellido = Console.ReadLine();
			Console.WriteLine("");

			Console.WriteLine("Ingrese su edad: ");
			Edad = int.Parse(Console.ReadLine());
			Console.WriteLine("");

			Console.WriteLine("Ingrese su email: ");
			Email = Console.ReadLine();
			Console.WriteLine("");

			Console.Clear();

			// Mostrar los datos ingresados
			Console.WriteLine("<<<< Datos del alumno >>>>");
			Console.WriteLine($"Nombre: {Nombre}");
			Console.WriteLine($"Apellido: {Apellido}");
			Console.WriteLine($"Edad: {Edad}");
			Console.WriteLine($"Email: {Email}");

			Console.WriteLine("¿Los datos son correctos? - 'S' para confirmar 'N' para cancelar");
			Respuesta = Console.ReadLine();

			if (Respuesta == "S")
			{
				// Mostrar carreras
				Console.Clear();
				Console.WriteLine("<<<< Seleccioná el código de la carrera elegida: >>>>");
				Console.WriteLine("1. Programación .Net");
				Console.WriteLine("2. Programación Java");
				Console.WriteLine("3. Programación PHP");

				// Solicitar código de carrera
				string carreraSeleccionada = "";

				int codigoCarrera = int.Parse(Console.ReadLine());
				if (codigoCarrera >= 1 && codigoCarrera <= 3)
				{
					switch (codigoCarrera)
					{
						case 1:
							carreraSeleccionada = "Programación .Net";
							break;
						case 2:
							carreraSeleccionada = "Programación Java";
							break;
						case 3:
							carreraSeleccionada = "Programación PHP";
							break;
					}
					// Mostrar datos del alumno + Carrera seleccionada
					Console.WriteLine("<<<< Constancia de Inscripción >>>>");
					Console.WriteLine($"Alumno: {Nombre} {Apellido}");
					Console.WriteLine($"Correo electrónico: {Email}");
					Console.WriteLine($"Carrera: {carreraSeleccionada}");
				}
				else
				{
					Console.WriteLine("Código de carrera inválido. Por favor, intente nuevamente.");
				}
			}
		}
	}
}
