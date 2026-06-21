using System;

public class Tarjeta : Pago
{
    
    private string numero;

    private string tipo;

    public string Numero {get {return this.numero;} set {this.numero=value;}}

    public string Tipo {get {return this.tipo;} set {this.tipo=value;}}

    public Tarjeta (double monto, Cliente cliente, int idPago, double recargo,string numero,string tipo):base(monto, cliente, idPago, recargo)
    {
        this.numero=numero;
        this.tipo=tipo;
    }
}