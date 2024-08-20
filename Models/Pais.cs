namespace TP6__JJOO__Blaser_Smucler.Models;

public class Pais
{
    public string Nombre {get; set;}

    public datetime FechaFundacion {get; set;}

    public string Bandera {get; set;}

public Deportista () {}

public Deportista (string nombre, datetime fechafundacion, string bandera )
{
   Nombre = nombre;
   FechaFundacion = fechafundacion;
   Bandera = bandera; 
}

}