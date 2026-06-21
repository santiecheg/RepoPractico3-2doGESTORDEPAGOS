using System;
using System.Diagnostics;


public class Program{

    static List<Pago> listaDePagos = new List<Pago>();
    static List<Cliente> listaDeClientes = new List<Cliente>();
    static void Main(){

        MostrarMenu();

    }

    static void MostrarMenu(){

        int opcion=1;

        while (opcion!=0){

            int opcionUsuario =10;
            Console.WriteLine("Bienvenido al sistema de Pagos");
            Console.WriteLine("Opcion 1 Registrar Cliente");
            Console.WriteLine("Opcion 2 Registrar pago");
            Console.WriteLine("Opcion 3 Ver pagos registrados");
            Console.WriteLine("Opcion 4 Salir");

            Console.WriteLine("\n Ingrese opción seleccionada");
            opcionUsuario=int.Parse(Console.ReadLine());

            switch (opcionUsuario){

                case 1:
                    RegistrarCliente();
                    break;
                
                case 2:
                    RegistrarPago();
                    break;
                
                case 3:
                    VerPagos();
                    break;
                
                case 4:
                    opcionUsuario=0;
                    Console.WriteLine("Gracias por usar pasarelas de pago gatito");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;

            }
        }

    }

    static void RegistrarCliente(){

        Console.Clear();
        Console.WriteLine("Elegiste la opción de registrar nuevo cliente");

        Console.WriteLine("\n Ingrese nombre de cliente");
        string nombreCliente = Console.ReadLine();

        listaDeClientes.Add(new Cliente(nombreCliente));
    }

    static void RegistrarPago(){



    }

    static void VerPagos(){



    }

}