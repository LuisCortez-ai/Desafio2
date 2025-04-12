using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class Program
    {
        //Decclaracion de arreglos de 10 espacios
       static string[] nombrePersonasR = new string[10];
static string[] nombre = new string[10];
static string[] especie = new string[10];
static int[] edad = new int[10];
static double[] peso = new double[10];
static int totalmascota = 0; //Variable para controlar la cantidad de registro 

static void Main(string[] args)
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.Clear();
    Console.Title = "Sistema de Gestion para Veterinaria MascotaFeliz";

    int opcion;
    do
    {
        Console.Clear();

        Console.WriteLine("\tBienvenido a la veterinaria");
        Console.WriteLine("\t     🐾MascotaFeliz🐾");

        Console.WriteLine("\n\t===>   Menu Principal   <===");
        Console.WriteLine("\t1. Registra tu Mascota");
        Console.WriteLine("\t2. Calculo promedio de peso");
        Console.WriteLine("\t3. Busca tu mascota");
        Console.WriteLine("\t4. Ordenar datos por edad");
        Console.WriteLine("\t5. Salir");
        Console.WriteLine("\t============================");
        Console.Write("\n\tSeleciona una opcion: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        opcion = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Gray;

        switch (opcion)
        {
            case 1:
                Registrarmascota();
                break;
            case 2:
                CalcularPromedioPeso();
                break;
            case 3:
                BuscarMascota();
                break;
            case 4:
                OrdenarMascotasPorEdad();
                break;
            case 5:
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\tSaliendo del Prograna...");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tOpcion invalida, intente de nuevo");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
        }
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n\tPresione (Enter) para continuar...");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ReadKey();
    }
    while (opcion != 5);
}
static void Registrarmascota()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n\t***REGISTRO DE MASCOTAS***");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.BackgroundColor = ConsoleColor.DarkYellow;

    if (totalmascota < 10)
    {
        
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("\n\tNombre del responsable:\t");
        Console.ForegroundColor = ConsoleColor.Gray;
        nombrePersonasR[totalmascota] = Console.ReadLine().Trim().ToLower();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("\tNombre de la mascota:\t");
        Console.ForegroundColor = ConsoleColor.Gray;
        nombre[totalmascota] = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("\tEspecie:\t\t");
        Console.ForegroundColor = ConsoleColor.Gray;
        especie[totalmascota] = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("\tEdad en años:\t\t");
        Console.ForegroundColor = ConsoleColor.Gray;
        edad[totalmascota] = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("\tPeso (kg):\t\t");
        Console.ForegroundColor = ConsoleColor.Gray;
        peso[totalmascota] = double.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Black;
        totalmascota++;

        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\tMascota registrada 🐶");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.BackgroundColor = ConsoleColor.DarkYellow;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\t¡Ya no quedan Espacios para Registar!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
static void CalcularPromedioPeso()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n\t***Promedio de Peso***");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.BackgroundColor = ConsoleColor.DarkYellow;

    if (totalmascota == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\tNo hay Mascotas Registradas");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    else
    {
        double suma = 0;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\tNombre\tEspecie\tPeso (kg)");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        for (int i = 0; i < totalmascota; i++)
        {
            suma += peso[i];
            Console.WriteLine($"\t{nombre[i]}\t{especie[i]}\t{peso[i]}");
        }
        double prom = suma / totalmascota;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n\t--------------------------------");
        Console.WriteLine("\tEl peso promedio total es de: " + Math.Round(prom, 2) + " kg");
        Console.WriteLine("\t--------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

}
static void BuscarMascota()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n\t*** Busca tu mascota ***");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    int encontrado = 1;
    int resp = 0;
    int i = 0;
    string EspecieMascota, NombreMascota, NombrePersonaR;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write("\n\tDigite los datos de la mascota a buscar");
    Console.WriteLine("\n");
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write("\tNombre del responsable:\t");
    Console.ForegroundColor = ConsoleColor.Gray;
    NombrePersonaR = Console.ReadLine().Trim().ToLower();
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write("\n\tNombre de la mascota:\t");
    Console.ForegroundColor = ConsoleColor.Gray;
    NombreMascota = Console.ReadLine().Trim().ToLower();
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write("\tEspecie:\t\t");
    Console.ForegroundColor = ConsoleColor.Gray;
    EspecieMascota = Console.ReadLine().Trim().ToLower();
    Console.ForegroundColor = ConsoleColor.Black;
    int MascotaEncontrada = -1;
    for (i = 0; i < totalmascota; i++)
    {
        if (NombreMascota == nombre[i].Trim().ToLower() && EspecieMascota == especie[i].Trim().ToLower() && NombrePersonaR == nombrePersonasR[i].Trim().ToLower())
        {
            resp = 1;
            MascotaEncontrada = i;
            break;
        }

    }
  if (MascotaEncontrada !=-1)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\n\tMostrando datos de {0}", NombreMascota);
        Console.WriteLine("\tNombre:\t" + NombreMascota);
        Console.WriteLine("\tEspecie:\t" + EspecieMascota);
        Console.WriteLine("\tEdad:\t" + edad[MascotaEncontrada] + " años");
        Console.WriteLine("\tPeso:\t" + peso[MascotaEncontrada] + " kg");

    }
    else
    {
        Console.WriteLine("\n\tLa mascota {0} de la especie {1} no fue encontrada", NombreMascota, EspecieMascota);
    }
}
static void OrdenarMascotasPorEdad()
{
    Console.Clear();
    int i, j;
    int auxYearOld;
    double auxWeight;
    string auxName, auxSpecie;
    for (i = 0; i < totalmascota - 1; i++)
    {
        for (j = 0; j < totalmascota - 1; j++)
        {
            if (edad[j] > edad[j + 1])
            {
                auxYearOld = edad[j];
                edad[j] = edad[j + 1];
                edad[j + 1] = auxYearOld;

                auxName = nombre[j];
                nombre[j] = nombre[j + 1];
                nombre[j + 1] = auxName;

                auxWeight = peso[j];
                peso[j] = peso[j + 1];
                peso[j + 1] = auxWeight;

                auxSpecie = especie[j];
                especie[j] = especie[j + 1];
                especie[j + 1] = auxSpecie;

            }
        }
    }
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n\t*** Mascotas ordenadas por edad ***");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n");
    for (i = 0; i < totalmascota; i++)
    {
        Console.WriteLine($"{"\t Nombre: ",-10}{nombre[i],-13} {"edad: ",-7}{edad[i],-10}{"años"}");
    }

}
    }
}
