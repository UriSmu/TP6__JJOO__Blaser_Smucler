namespace TP6__JJOO__Blaser_Smucler.Models;

public class Deportista
{

    public string Apellido {get; set;}
    
    public string Nombre {get; set;}

    public datetime FechaNacimiento {get; set;}

    public string Foto {get; set;}

public Deportista () {}

public Deportista (string apellido, string nombre, datetime fechanacimiento, string foto )
{
   Apellido = apellido;
   Nombre = nombre;
   FechaNacimiento = fechanacimiento;
   Foto = foto; 
}
}