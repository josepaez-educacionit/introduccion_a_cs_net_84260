namespace Arreglos
{
    internal class Program
    {
        // Qué es un arreglo
        // Un arreglo es una colección de variables del mismo tipo que se acceden con un índice numérico.
        // Los arreglos son útiles para almacenar y manipular conjuntos de datos relacionados.
        // Un arreglo se declara especificando el tipo de datos, seguido de corchetes y un nombre.
        static void Main(string[] args)
        {
            // La declaración de un arreglo
            // tipo[] nombreArreglo;
            // nombreArreglo = new tipo[tamaño];

            // declaración
            int[] numeros;
            numeros = new int[5];

            // Escritura de un dato
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            // Lectura de un dato
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);

            // Declaración e inicialización
            int[] arrayNumeros = { 999, 11, 2, 93, 42, 185, 25, 8, 100, 5, 45 };

            Console.Clear();
            Console.WriteLine("Recorriendo el arreglo con un bucle for:");

            // Recorrer un arreglo
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine(arrayNumeros[i]);
            }


            // Encontrar el valor máximo en un arreglo
            Console.Clear();
            Console.WriteLine("Encontrando el valor máximo en el arreglo:");

            int maximo = arrayNumeros[0];
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] > maximo)
                {
                    maximo = arrayNumeros[i];
                }
            }
            Console.WriteLine($"El valor máximo en el arreglo es: {maximo}");

            // Invertir los elementos de un arreglo

            Console.Clear();
            Console.WriteLine("Invertir los elementos de un arreglo");

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine(arrayNumeros[i]);
            }

            // Invertir los elementos de un arreglo
            Array.Reverse(arrayNumeros);

            Console.WriteLine("Arreglo invertido:");
            foreach (int numero in arrayNumeros)
            {
                Console.WriteLine(numero);
            }

            // Totalizar el contenido de un arreglo numérico y calcular el promedio
            Console.Clear();
            Console.WriteLine("Totalizar el contenido de un arreglo numérico y calcular el promedio");

            int[] numerosParaPromedio = { 10, 20, 30, 40, 50 };
            int total = 0;

            //for (int i = 0; i < numerosParaPromedio.Length; i++)
            //{
            //    // total = total + numerosParaPromedio[i];
            //    total += numerosParaPromedio[i];
            //}

            // Alternativa usando foreach
            foreach (var numero in numerosParaPromedio)
            {
                total += numero;
            }

            double promedio = total / numerosParaPromedio.Length;
            Console.WriteLine($"El total es: {total}");
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
}
