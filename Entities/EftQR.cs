using System;

public class PagoEftqr: Pago
{
    private double vuelto;

    public double Vuelto {get {return this.vuelto;} set{this.vuelto=value;}}
    

    public PagoEftqr (double monto, Cliente cliente, int idPago, double recargo, double vuelto):base(monto, cliente, idPago, recargo)
    {
        this.vuelto=vuelto;
    }

}