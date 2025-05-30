/*
 * Escribe un programa que sea capaz de generar contraseñas de forma aleatoria.
 * Podrás configurar generar contraseñas con los siguientes parámetros:
 * - Longitud: Entre 8 y 16.
 * - Con o sin letras mayúsculas.
 * - Con o sin números.
 * - Con o sin símbolos.
 * (Pudiendo combinar todos estos parámetros entre ellos)
 */



using Microsoft.VisualBasic;

public class Program
{

    public static void Main()
    {
        List<char> contraseña = new List<char>();
        Random rand = new Random();
        int numero = rand.Next(8, 16);
        
        for (int i = 0; i <numero ; i++)
        {
            var randomnum = rand.Next(8, 300);
            var clave = Convert.ToChar(randomnum);
            contraseña.Add(clave);

        }
        var final=String.Concat(contraseña);
        Console.WriteLine(final);

    }
}
