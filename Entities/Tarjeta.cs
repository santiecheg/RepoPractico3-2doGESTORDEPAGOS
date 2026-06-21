using System;

public class Tarjeta : Pago
{
    
    private string numero;

    private string tipo;

    public string Numero {get {return this.numero;} set {this.numero=value;}}

    public string Tipo {get {return this.tipo;} set {this.tipo=value;}}

}