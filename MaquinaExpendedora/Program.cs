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



using System.ComponentModel;
using System.Diagnostics;

class Program
{

   
    
    static int[] monedasSoportadas = { 5, 10, 50, 100, 200 };
   
    
    static void Maquina(string name,int n,Dictionary<string,int> producto)
    {
        
        foreach (var item in producto) {
            if (name.Equals(item.Key)) {
                if (n >= item.Value) {
                   int total = n - item.Value;
                   List<int>vuelto=devolucion(total);
                   Console.WriteLine("su vuelto es " + total );
                    foreach (var v in vuelto)
                    {
                        Console.WriteLine("sera devuelto en "+v);
                    }

                }
            
            }
        }
     
    } 

    static List<int> devolucion(int monto)
    {
        List<int> list = new List<int>();
        foreach (var moneda in monedasSoportadas.OrderByDescending(x=>x))
        {
            while (monto >= moneda) {
                list.Add(moneda);
                monto -= moneda;
            }
        }
        return list;
    }

    static void Main(string[] args)
    {
        Dictionary<string, int> productos = new Dictionary<string, int>()
    {
        {"Cockie",50 },
        {"Agua",100 },
        {"Snack",200 }

    };
        Maquina("Cockie", 500, productos);
    }

}



