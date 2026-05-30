namespace FuncionesProcedimientos
{
    internal class Program
    {
        // =============================
        // FUNCIONES Y PROCEDIMIENTOS
        // =============================
        // Las funciones y procedimientos son bloques de código reutilizables que realizan tareas específicas.
        // - FUNCIONES: Devuelven un valor al ser llamadas.
        // - PROCEDIMIENTOS: No devuelven valor (en C#, son métodos void).
        // Ventajas: Organización, reutilización, mantenimiento y legibilidad del código.

        static void Main(string[] args)
        {
            // Ejemplo de uso de una función que suma dos números y devuelve el resultado
            int suma;
            suma = Sumar( 658, 7964 );
            Console.WriteLine($"La suma es: {suma}");
            ImprimirMensaje($"La suma es: {suma}");
        }

        // =============================
        // FUNCIÓN Sumar
        // =============================
        // Recibe dos parámetros por valor, los suma y devuelve el resultado.
        // Los parámetros por valor NO modifican las variables originales.
        static int Sumar(int num1, int num2)
        {
            int suma = num1 + num2; // Suma los dos números
            return suma; // Devuelve el resultado
        }

        // =============================
        // PROCEDIMIENTO ImprimirMensaje
        // =============================
        // Procedimiento (método void): muestra un mensaje en consola.
        // No devuelve ningún valor.
        static void ImprimirMensaje(string mensaje)
        {
            Console.WriteLine(mensaje); // Imprime el mensaje recibido
        }
    }
}
