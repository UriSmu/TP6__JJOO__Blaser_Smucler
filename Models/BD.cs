using System.Data.SqlClient;
using Dapper;

namespace TP6__JJOO__Blaser_Smucler.Models;

static public class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=Tp6_JJOO; Trusted_Connection=True;";
    
    public static void AgregarDeportista(Deportista dep)
    {
        string sql = "INSERT INTO Deportistas(Apellido, Nombre, FechaNacimiento, Foto, IdPais, IdDeporte) VALUES (@pApellido, @pNombre, @pFecha, @pFoto, @pPais, @pDeporte)";
	    using(SqlConnection db = new SqlConnection(_connectionString))
	    {
		    db.Execute(sql, new {pApellido = dep.Apellido, pNombre = dep.Nombre, pFecha = dep.FechaNacimiento, pFoto = dep.Foto, pPais = dep.IdPais, pDeporte = dep.IdDeporte});
	    }
    }
}