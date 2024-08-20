using System;
namespace TP6__JJOO__Blaser_Smucler.Models;

public class Deportista
{

    public string Apellido {get; set;}
    
    public string Nombre {get; set;}

    public DateTime FechaNacimiento {get; set;}

    public string Foto {get; set;}

    public int IdPais {get; set;}
    
    public int IdDeporte {get; set;}
    public Deportista () {}

    public Deportista (string apellido, string nombre, DateTime fechanacimiento, string foto, int pais, int deporte)
    {
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = fechanacimiento;
        Foto = foto; 
        IdPais = pais;
        IdDeporte = deporte;
    }
}