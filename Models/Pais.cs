namespace TP6__JJOO__Blaser_Smucler.Models;

public class Pais
{
    public string Nombre {get; set;}

    public DateTime FechaFundacion {get; set;}

    public string Bandera {get; set;}

public Pais () {}

public Pais (string nombre, DateTime fechafundacion, string bandera )
{
   Nombre = nombre;
   FechaFundacion = fechafundacion;
   Bandera = bandera; 
}

}