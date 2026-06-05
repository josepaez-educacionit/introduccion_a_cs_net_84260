namespace Estructuras
{
    // Que es una estructura (struct) en C#?
    // Una estructura (struct) es un tipo de dato que permite agrupar variables relacionadas bajo un mismo nombre. 
    // Es similar a una clase, pero es un tipo de valor en lugar de un tipo de referencia.
    // Las estructuras son útiles para modelar entidades simples que no requieren la complejidad de una clase, como personas, clientes o vehículos.
    // Se declaran usando la palabra clave "struct" seguida del nombre de la estructura y


    internal class Program
    {

        // Estructura que representa una persona con datos personales básicos.
          struct Persona
        {
            public string Nombre;           // Nombre de la persona
            public string Apellido;         // Apellido de la persona
            public string TipoDocumento;    // Tipo de documento (DNI, Pasaporte, etc.)
            public int NumeroDocumento;     // Número de documento
            public DateTime FechaNacimiento;// Fecha de nacimiento (no se utiliza en este ejemplo)
            public string Sexo;             // Sexo de la persona (no se utiliza en este ejemplo)
            public string Telefono;         // Teléfono de contacto (no se utiliza en este ejemplo)
            public string Domicilio;        // Domicilio o dirección
        }

        // Estructura que representa un cliente con información fiscal y de contacto.
        public struct Cliente
        {
            public int Codigo;              // Código único del cliente
            public string Nombre;           // Nombre del cliente
            public string Apellido;         // Apellido del cliente
            public string CUIT;             // CUIT (identificación fiscal)
            public string Domicilio;        // Domicilio del cliente
        }

        // Estructura que representa un vehículo con sus características principales.
        public struct Vehiculo
        {
            public string Marca;            // Marca del vehículo
            public string Modelo;           // Modelo del vehículo
            public int Año;                 // Año de fabricación
            public double Precio;           // Precio del vehículo
        }

        static void Main(string[] args)
        {
            Persona unaPersona;
            Persona otraPersona;

            // Asignación de datos a la primera persona
            unaPersona.Nombre = "Juan";
            unaPersona.Apellido = "Perez";
            unaPersona.TipoDocumento = "DNI";
            unaPersona.NumeroDocumento = 50123976;
            unaPersona.Domicilio = "";

            // Asignación de datos a la segunda persona
            otraPersona.Nombre = "Maria";
            otraPersona.Apellido = "Sanchez";
            otraPersona.TipoDocumento = "dni"; // Asignación correcta del tipo de documento


            // Mostrar datos de la primera persona
            Console.WriteLine("-- Datos de unaPersona --");
            Console.WriteLine($" Nombre: {unaPersona.Nombre}");
            Console.WriteLine($" Apellido: {unaPersona.Apellido}");
            Console.WriteLine($" Numero Documento: {unaPersona.NumeroDocumento}");
            Console.WriteLine($" Domicilio: {unaPersona.Domicilio}");

            // Mostrar datos de la otra persona
            Console.WriteLine("-- Datos de otraPersona --");
            Console.WriteLine($" Nombre: {otraPersona.Nombre}");
            Console.WriteLine($" Apellido: {otraPersona.Apellido}");


            // Ejemplo 2: Uso de un arreglo de estructuras Persona
            // Declaración e inicialización del arreglo
            Persona[] personas = new Persona[3];

            // Asignación de valores a los elementos del arreglo
            personas[0].Apellido = "Perez";
            personas[0].Nombre = "Juan";
            personas[0].TipoDocumento = "DNI";
            personas[0].NumeroDocumento = 50123976;

            personas[1].Apellido = "Sanchez";
            personas[1].Nombre = "Maria";
            personas[1].TipoDocumento = "";
            personas[1].NumeroDocumento = 12345678;

            personas[2].Apellido = "Rodriguez";
            personas[2].Nombre = "Alberto";
            personas[2].TipoDocumento = "zzz";
            personas[2].NumeroDocumento = 45123987;


            // Mostrar datos de la tercera persona del arreglo
            Console.WriteLine("-- Datos de la tercera persona en el arreglo --");
            Console.WriteLine($" Nombre: {personas[2].Nombre}");
            Console.WriteLine($" Apellido: {personas[2].Apellido}");
            Console.WriteLine($" Numero Documento: {personas[2].NumeroDocumento}");


            Console.Clear();
            
            // Recorrer y mostrar todos los datos del arreglo de personas
            Console.WriteLine("-- Datos en el Arreglo Personas --");
            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine($" Nombre: {personas[i].Nombre}");
                Console.WriteLine($" Apellido: {personas[i].Apellido}");
                Console.WriteLine($" Numero Documento: {personas[i].NumeroDocumento}");
            }

            // Ejemplo 3: Uso de un arreglo de estructuras Vehiculo
            // Declaración e inicialización del arreglo
            Vehiculo[] vehiculos = new Vehiculo[3];

            // Asignación de valores a los elementos del arreglo
            vehiculos[0].Marca = "Toyota";
            vehiculos[0].Modelo = "Corolla";
            vehiculos[0].Año = 2020;
            vehiculos[0].Precio = 20000;

            vehiculos[1].Marca = "Ford";
            vehiculos[1].Modelo = "Fiesta";
            vehiculos[1].Año = 2019;
            vehiculos[1].Precio = 12000;

            vehiculos[2].Marca = "Honda";
            vehiculos[2].Modelo = "Civic";
            vehiculos[2].Año = 2021;
            vehiculos[2].Precio = 24000;

            // Recorrer y mostrar todos los datos del arreglo de vehículos
            Console.WriteLine("-- Datos en el Arreglo Vehiculos --");
            for (int i = 0; i < vehiculos.Length; i++)
            {
                Console.WriteLine($" Marca: {vehiculos[i].Marca}, Modelo: {vehiculos[i].Modelo}, Año: {vehiculos[i].Año}, Precio: {vehiculos[i].Precio}");
            }
        }
    }
}
