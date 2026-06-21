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

        Console.Clear();
        Console.WriteLine("Ha elegido registrar pago");

        Console.WriteLine("Elija primero a qué cliente registrar el pago");
        Cliente clienteApagar = ElegirCliente();

        Console.WriteLine("Elija su método de pago");
        ElegirMetodoDePago();



    }

    static void VerPagos(){



    }

    static void ElegirMetodoDePago(){

        Console.WriteLine("Elija su método de pago");
        Console.WriteLine("Opción 1 Pago con efectivo");
        Console.WriteLine("Opcion 2 Pago con tarjeta (10% de recargo)");
        

        int metodoDepagoElegido = int.Parse(Console.ReadLine());

        switch (metodoDepagoElegido){

            case 1:
                PagoConEfectivo();
                break;


            case 2:
                PagoConTarjeta();
                break;

        }


    }

    static void PagoConEfectivo(){



    }

    static void PagoConTarjeta(){

        

    }

    static Cliente ElegirCliente(){

        int indiceCliente=0;
        
        foreach (Cliente c in listaDeClientes){

            indiceCliente++;
            Console.WriteLine($"El cliente {c.Nombre} tiene el índice {indiceCliente}");

        }

        Console.WriteLine("Elija el índice de cliente");
        int seleccionCliente = int.Parse(Console.ReadLine());

        return listaDeClientes[seleccionCliente];

        
    }

}