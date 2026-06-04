namespace Arreglos_Multidimensionales
{
    internal class Program
    {
        // =============================
        // ARREGLOS MULTIDIMENSIONALES
        // =============================
        // Un arreglo multidimensional es una estructura que almacena datos en más de una dimensión (filas y columnas).
        // Ejemplo clásico: una matriz (tabla de números).
        // En C#, se declara usando int[,], donde cada coma representa una dimensión.

        static void Main(string[] args)
        {
            // =============================
            // DECLARACIÓN DE ARREGLO MULTIDIMENSIONAL
            // =============================
            // Se crea una matriz de 3x3 (3 filas, 3 columnas), inicializada con ceros por defecto.
            int[,] matriz = new int[3, 3];


            // =============================
            // ASIGNACIÓN DE VALORES
            // =============================
            // Se asignan valores a la primera columna de cada fila.
            matriz[0, 0] = 1; // Fila 0, Columna 0
            matriz[1, 0] = 2; // Fila 1, Columna 0
            matriz[2, 0] = 3; // Fila 2, Columna 0


            // =============================
            // LECTURA DE VALORES
            // =============================
            // Se leen los valores asignados anteriormente.
            int dato1 = matriz[0, 0]; // 1
            int dato2 = matriz[1, 0]; // 2
            int dato3 = matriz[2, 0]; // 3


            // =============================
            // DECLARACIÓN E INICIALIZACIÓN
            // =============================
            // Se puede declarar e inicializar una matriz en una sola línea.
            int[,] matriz2 = new int[3, 3]
            {
                { 1, 2, 3 },   // Fila 0
				{ 4, 546, 6 }, // Fila 1
				{ 7, 8, 9 }    // Fila 2
			};

            // =============================
            // IMPRESIÓN DE LA MATRIZ COMPLETA
            // =============================
            Console.WriteLine("Contenido de la matriz:");
            // Recorre todas las filas y columnas usando dos bucles anidados
            for (int i = 0; i < matriz2.GetLength(0); i++) // Recorre filas
            {
                for (int j = 0; j < matriz2.GetLength(1); j++) // Recorre columnas
                {
                    Console.Write(matriz2[i, j] + " "); // Imprime cada elemento
                }
                Console.WriteLine(); // Salto de línea al terminar cada fila
            }

            // =============================
            // BÚSQUEDA DEL MAYOR VALOR
            // =============================
            // Se recorre toda la matriz para encontrar el valor máximo.
            int mayor = matriz2[0, 0]; // Se parte del primer elemento
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    if (matriz2[i, j] > mayor)
                    {
                        mayor = matriz2[i, j]; // Se actualiza si se encuentra uno mayor
                    }
                }
            }
            Console.WriteLine("El mayor valor es: " + mayor); // Muestra el resultado
        }
    }
}
