using System;

public abstract class Pago
{
    
    private double monto;

    private Cliente cliente; 

    private int idPago;

    private int recargo;


    public double Monto {get {return this.monto;} set{this.monto=value;}}

    public Cliente Cliente {get {return this.cliente;} set{this.cliente=value;}}

    public int IdPago {get {return this.idPago;} set{this.idPago=value;}}

    public int Recargo {get {return this.recargo;} set{this.recargo=value;}}

}