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
        ElegirMetodoDePago(clienteApagar);



    }

    static void VerPagos(){

        Console.WriteLine("\n Reporte de pagos realizados");

        foreach (Pago c in listaDePagos){

            Console.WriteLine("=====================================================");
            Console.WriteLine($"Cliente nombre: {c.Cliente.Nombre}");
            Console.WriteLine($"Monto a pagar original: {c.Monto}");
            Console.WriteLine($"Recargo por método de pago: {c.Recargo}");
            Console.WriteLine($"\n Monto total con recargo incluido: {(c.Monto+c.Recargo)}");

            Console.WriteLine("=====================================================");
            

        }

    }

    static void ElegirMetodoDePago(Cliente cliente){

        Console.WriteLine("Elija su método de pago");
        Console.WriteLine("Opción 1 Pago con efectivo");
        Console.WriteLine("Opcion 2 Pago con tarjeta (10% de recargo)");
        

        int metodoDepagoElegido = int.Parse(Console.ReadLine());

        switch (metodoDepagoElegido){

            case 1:
                PagoConEfectivo(cliente);
                break;


            case 2:
                PagoConTarjeta(cliente);
                break;

        }


    }

    static void PagoConEfectivo(Cliente cliente){

        Random random = new Random();
        double monto,conCuantoPaga,vuelto,recargo;
        int idPago=random.Next(0,999999);
        recargo =0; //Paga en efectivo es sin recargo

        Console.WriteLine("Usted ha elegido el pago con efectivo");
        Console.WriteLine("Ingrese importe del pago a realizar");
        monto=double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese con cuanto va a pagar?");
        conCuantoPaga=double.Parse(Console.ReadLine());
        vuelto=conCuantoPaga-monto;

        listaDePagos.Add(new PagoEftqr(monto,cliente,idPago,0,vuelto));

        Console.WriteLine("Pago agregado exitosamente");
        Console.WriteLine($"Vuelto para el cliente: {vuelto}");

    }


    static void PagoConTarjeta(Cliente cliente){

        Random random = new Random();
        double monto,recargo;

        Console.WriteLine("Usted ha elegido el pago con tarjeta, tiene un 10% de recargo");
        int idPago=random.Next(0,999999);
        
        Console.WriteLine("Ingrese importe del pago a realizar");
        monto=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese que tipo tarjeta es (crédito o débito)");
        string tipo=Console.ReadLine();

        Console.WriteLine("Ingrese los numeros de su tarjeta");
        string numero=Console.ReadLine();

        recargo = (monto*0.1);

        listaDePagos.Add(new Tarjeta(monto,cliente,idPago,recargo,numero,tipo));

        Console.WriteLine("Pago agregado exitosamente");

        

    }

    static Cliente ElegirCliente(){

        int indiceCliente=0;
        
        foreach (Cliente c in listaDeClientes){

            indiceCliente++;
            Console.WriteLine($"El cliente {c.Nombre} tiene el índice {(indiceCliente)}");

        }

        Console.WriteLine("Elija el índice de cliente");
        int seleccionCliente = int.Parse(Console.ReadLine());

        return listaDeClientes[(seleccionCliente-1)];

        
    }

}