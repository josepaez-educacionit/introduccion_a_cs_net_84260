namespace poo
{
    internal class Program
    {
        //Programación orientada a objetos (OOP)
        // La orientación a objetos (OOP) es un paradigma de programación que se basa en el concepto de "objetos", 
        // que son instancias de clases. 
        // En C#, la OOP permite organizar el código en torno a objetos que encapsulan datos y comportamientos relacionados. 
        // Los objetos interactúan entre sí a través de métodos y propiedades, lo que facilita la modularidad, reutilización y mantenimiento del código. 
        // La OOP se fundamenta en cuatro pilares principales: encapsulamiento, herencia, polimorfismo y abstracción.


        // Que son objetos? 
        // Los objetos son instancias de clases que representan entidades del mundo real o conceptos abstractos en un programa. 
        // Un objeto tiene un estado (representado por sus atributos o campos) y un comportamiento (representado por sus métodos).
        // Los objetos interactúan entre sí a través de mensajes, lo que permite la comunicación y colaboración entre diferentes partes de un programa orientado a objetos. 
        // En C#, los objetos se crean a partir de clases utilizando el operador "new" y pueden tener propiedades, métodos y eventos que definen su funcionalidad y características.

        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Juan";
            persona1.Apellido = "Perez";
            persona1.Edad = 30;

            persona1.MostrarInformacion();
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Apellido: {Apellido}");
                Console.WriteLine($"Edad: {Edad}");
            }
        }
    }
}
