using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion =0;

            while (opcion <=6)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("¿Qué ejercicio desea realizar?");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("[1] Leer un número por teclado y definir si es par o impar");
                Console.WriteLine("[2] Generar la tabla de multiplicar del 1 al 10");
                Console.WriteLine("[3] Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10");
                Console.WriteLine("[4] Imprimir un número y verficar si es un número primo o no");
                Console.WriteLine("[5] Ordenar vector");
                Console.WriteLine("[6] Leer un nombre por teclado y definir si existe");
                Console.WriteLine("[7] Salir");
                Console.WriteLine("------------------------------------------");
                opcion = Convert.ToInt32(Console.ReadLine());

           

            switch (opcion)
            {
                case 1:
                        int num,cal;
                    Console.WriteLine("Digite un número");

                    num = Convert.ToInt32(Console.ReadLine());
                    cal = num % 2;

                    if (cal == 0 )
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Es un número par");
                        Console.WriteLine("------------------------------------------");
                    }
                    else { 

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Es un número impar");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;
                case 2:
                        int nume;

                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(" TABLA DE MULTIPLICAR ");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Digite un número");
                    nume = Convert.ToInt32(Console.ReadLine());
            

                    for(int m = 1; m <= 10; m++)
                    {

                        Console.WriteLine(nume + "x" + m + "=" + nume*m);
                    }
                    break;
                case 3:
                        for (int s = 2; s <= 9; s++)
                    {
                        Console.WriteLine("<----------------------------------------------->");
                        Console.WriteLine("Tabla del " + s);
                        Console.WriteLine("<----------------------------------------------->");
                        for (int j = 1; j <= 10; j++)
                        {

                            Console.WriteLine(s + "x" + j + "=" + s * j);
                        }
                    }
                        break;
                case 4:
                    int numero;

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Ingrese un número entero mayor a 1");
                        Console.WriteLine("------------------------------------------");
                        numero = Convert.ToInt32(Console.ReadLine());

                        if (numero != 0)
                        {
                            if (numero % 1 == 0)
                            {
                                Console.WriteLine("Este número  es primo");
                            }
                            else
                            {
                                Console.WriteLine("Este número no es primo");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número inválido");
                        }
                        break;
                    case 5:

                        int[] n = { 25, 63, 8, 12, 11, 5 };
                        int i, temp;
                        int t = n.Length;
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Arreglo original");
                        Console.WriteLine("------------------------------------------");

                        Console.WriteLine("Tamaño del vector " + t);
                        Console.WriteLine("----------------------------------------------------");
                        foreach (int elemento in n)
                        {
                            Console.WriteLine(elemento);
                        }

                        for (int j = 1; j < t; j++)
                        {




                            for (i = 0; i < t - j; i++)
                            {
                                if (n[i] > n[i + 1])
                                {
                                    temp = n[i];
                                    n[i] = n[i + 1];
                                    n[i + 1] = temp;
                                }
                            }

                        }
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Arreglo Ordenado ");

                        foreach (int elemento in n)
                        {
                            Console.WriteLine(elemento);
                        }

                        break;
                    case 6:
                        Console.WriteLine("BUSCAR PERSONA Y MOSTRAR SU EDAD");
                        Console.WriteLine("--------------------------------");

                        int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                        string nombreBuscar;
                        Boolean existe = false;
                        int indice = 0; // posicion donde existe el usuario
                        int perMayor = 0, edadMayor = 0;

                        Console.WriteLine("Imprimir array de nombres");
                        Console.WriteLine("--------------------------------");

                        foreach (string nombre in nombres)
                        {
                            Console.WriteLine(nombre);
                        }

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Digite el nombre a buscar");
                        nombreBuscar = Console.ReadLine();

                        //recorrer el vector para ver si existe y posicion

                        for (int l = 0; l < nombres.Length; l++)
                        {
                            if (nombreBuscar == nombres[l])
                            {
                                existe = true;
                                indice = l;

                            }


                        }
                        if (existe)
                        {
                            Console.WriteLine("El usuario " + nombreBuscar + " tiene " + edad[indice] + " años");
                        }
                        else
                            Console.WriteLine("El usuario " + nombreBuscar + " " +
                                "No existe");
                        for (int c = 0; c < edad.Length; c++)
                        {
                            if (edad[c] > edadMayor)
                            {
                                edadMayor = edad[c];
                                perMayor = c;
                            }
                        }

                        Console.WriteLine("El mayor es: " + nombres[perMayor] + " y su edad es: " + edad[perMayor] + " años");
                        break;
                    


                    
            }

            }
            Console.ReadKey();
        }
    }
}
