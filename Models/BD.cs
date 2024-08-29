using System;
using System.Data.SqlClient;
using Dapper;

namespace TP6__JJOO__Blaser_Smucler.Models;

static public class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=Tp6_JJOO; Trusted_Connection=true;";
    
    public static void AgregarDeportista(Deportista dep)
    {
        string sql = "INSERT INTO Deportistas(Apellido, Nombre, FechaNacimiento, Foto, IdPais, IdDeportes) VALUES (@pApellido, @pNombre, @pFecha, @pFoto, @pPais, @pDeporte)";
	    using(SqlConnection db = new SqlConnection(_connectionString))
	    {
		    db.Execute(sql, new {pApellido = dep.Apellido, pNombre = dep.Nombre, pFecha = dep.FechaNacimiento, pFoto = dep.Foto, pPais = dep.IdPais, pDeporte = dep.IdDeportes});
	    }
    }
 
    public static Deporte VerInfoDeporte(int idDeporte)
    {
        Deporte MiDeporte = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Deportes WHERE IdDeportes = @pId";
            MiDeporte = db.QueryFirstOrDefault<Deporte>(sql, new {pId = idDeporte});
        }
        return MiDeporte;
    }

    public static Pais VerInfoPais(int idPais)
    {
        Pais MiPais = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Paises WHERE IdPais = @pId";
            MiPais = db.QueryFirstOrDefault<Pais>(sql, new {pId = idPais});
        }
        return MiPais;
    }

    public static Deportista VerInfoDeportista(int idDeportista)
    {
        Deportista MiDeportista = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Deportistas WHERE IdDeportistas = @pId";
            MiDeportista = db.QueryFirstOrDefault<Deportista>(sql, new {pId = idDeportista});
        }
        return MiDeportista;
    }

    public static List<Pais> ListarPaises()
    {
        List<Pais> ListaPaises = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            ListaPaises = db.Query<Pais>("SELECT * FROM Paises").ToList();
        }       
        return ListaPaises;
    }

    public static List<Deportista> ListarDeportistasPorDeporte(int idDeporte)
    {
        List<Deportista> ListaDeportistas = null;
        string sql = "SELECT * FROM Deportistas WHERE IdDeportes = @pidDeporte";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            ListaDeportistas = db.Query<Deportista>(sql, new{pidDeporte = idDeporte}).ToList();
        }       
        return ListaDeportistas;
    }

    public static List<Deportista> ListarDeportistasPorPais(int idPais)
    {
        List<Deportista> ListaDeportistas = null;
        string sql = "SELECT * FROM Deportistas WHERE IdPais = @pidPais";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            ListaDeportistas = db.Query<Deportista>(sql, new{pidPais = idPais}).ToList();
        }       
        return ListaDeportistas;
    }

    public static List<Deporte> ListarDeportes()
    {
        List<Deporte> ListaDeportes = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            ListaDeportes = db.Query<Deporte>("SELECT * FROM Deportes").ToList();
        }       
        return ListaDeportes;
    }
    public static int EliminarDeportista (int IdDeportista)
    {
        int DeportistasEliminados = 0;
        string sql = "DELETE FROM Deportistas WHERE IdDeportistas = @IdsDeportistas";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            DeportistasEliminados = db.Execute(sql, new {IdsDeportistas = IdDeportista});
        }
        return DeportistasEliminados;
    }

    public static List<Pais> ListarPaisesBusqueda(string busqueda)
    {
        List<Pais> ListaPaises = null;
        string sql = "SELECT * FROM Paises WHERE Nombre LIKE '%' + @pBusqueda + '%'";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            ListaPaises = db.Query<Pais>(sql, new {pBusqueda = busqueda}).ToList();
        }       
        return ListaPaises;
    }

    public static List<Deporte> ListarDeportesBusqueda(string busqueda)
    {
        List<Deporte> ListaDeportes = null;
        string sql = "SELECT * FROM Deportes WHERE Nombre LIKE '%' + @pBusqueda + '%'";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            ListaDeportes = db.Query<Deporte>(sql, new {pBusqueda = busqueda}).ToList();
        }       
        return ListaDeportes;
    }

    public static List<Deportista> ListarDeportistaBusqueda(string busqueda)
    {
        List<Deportista> ListaDeportistas = null;
        string sql = "SELECT * FROM Deportistas WHERE Nombre LIKE '%' + @pBusqueda + '%'";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            ListaDeportistas = db.Query<Deportista>(sql, new {pBusqueda = busqueda}).ToList();
        }       
        return ListaDeportistas;
    }
}