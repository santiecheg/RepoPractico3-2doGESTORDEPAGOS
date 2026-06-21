using System;


public class Cliente
{
    
    private string nombre;
    
    public string Nombre {get {return this.nombre;} set {this.nombre=value;}}

    public Cliente (string nombre)
    {
        this.nombre=nombre;
    }

}