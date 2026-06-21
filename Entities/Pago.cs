using System;

public abstract class Pago
{
    
    private double monto;

    private Cliente cliente; 

    private int idPago;

    private double recargo;


    public double Monto {get {return this.monto;} set{this.monto=value;}}

    public Cliente Cliente {get {return this.cliente;} set{this.cliente=value;}}

    public int IdPago {get {return this.idPago;} set{this.idPago=value;}}

    public double Recargo {get {return this.recargo;} set{this.recargo=value;}}


    public Pago (double monto, Cliente cliente, int IdPago,double Recargo)
    {
        
        this.monto=monto;
        this.cliente=cliente;
        this.idPago=IdPago;
        this.recargo=Recargo;

    }

}