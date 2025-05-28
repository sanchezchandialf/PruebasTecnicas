/*
 * EJERCICIO:
 * Utilizando tu lenguaje, crea un programa capaz de ejecutar de manera
 * asíncrona una función que tardará en finalizar un número concreto de
 * segundos parametrizables. También debes poder asignarle un nombre.
 * La función imprime su nombre, cuándo empieza, el tiempo que durará
 * su ejecución y cuando finaliza.
 *
 * DIFICULTAD EXTRA (opcional):
 * Utilizando el concepto de asincronía y la función anterior, crea
 * el siguiente programa que ejecuta en este orden:
 * - Una función C que dura 3 segundos.
 * - Una función B que dura 2 segundos.
 * - Una función A que dura 1 segundo.
 * - Una función D que dura 1 segundo.
 * - Las funciones C, B y A se ejecutan en paralelo.
 * - La función D comienza su ejecución cuando las 3 anteriores han finalizado.
 */

public class ProgramaAsincrono
{
    
    async static Task EjecutarFuncionAsincrona(string nombre, int duracionSegundos)
    {
        Console.WriteLine($"[{DateTime.Now}] Iniciando {nombre}, durará {duracionSegundos} segundos.");
        await Task.Delay(duracionSegundos * 1000);
        Console.WriteLine($"[{DateTime.Now}] Finalizando {nombre}.");
    }

    public static async Task Main(string[] args)
    {
        int[] duraciones = { 3000, 2000, 1000, 1000 };
        string[] nombres = { "Funcion C", "Funcion B", "Funcion A", "Funcion D" };
        

        Task tareaA = EjecutarFuncionAsincrona(nombres[2], duraciones[2]);
        Task tareaB = EjecutarFuncionAsincrona(nombres[1], duraciones[1]);
        Task tareaC = EjecutarFuncionAsincrona(nombres[0], duraciones[0]);
        

        
         await Task.WhenAll(tareaA, tareaB, tareaC);
         await EjecutarFuncionAsincrona(nombres[3], duraciones[3]);
       

    }

}
