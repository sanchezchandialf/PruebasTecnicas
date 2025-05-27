/*
 * Simula el funcionamiento de una máquina expendedora creando una operación
 * que reciba dinero (array de monedas) y un número que indique la selección
 * del producto.
 * - El programa retornará el nombre del producto y un array con el dinero
 *   de vuelta (con el menor número de monedas).
 * - Si el dinero es insuficiente o el número de producto no existe,
 *   deberá indicarse con un mensaje y retornar todas las monedas.
 * - Si no hay dinero de vuelta, el array se retornará vacío.
 * - Para que resulte más simple, trabajaremos en céntimos con monedas
 *   de 5, 10, 50, 100 y 200.
 * - Debemos controlar que las monedas enviadas estén dentro de las soportadas.
 */

int[] monedasSoportadas = { 5, 10, 50, 100, 200 };

static void Menu()
{
    Console.WriteLine("Bienvenido a la máquina expendedora");
    Console.WriteLine("Seleccione un producto:");
    Console.WriteLine("1. Agua (100 céntimos)");
    Console.WriteLine("2. Refresco (150 céntimos)");
    Console.WriteLine("3. Snack (200 céntimos)");
    Console.WriteLine("4. Salir");
}


static void MaquinaExpendedora(int cantidad, int[]monedas,int seleccion)
{

}


