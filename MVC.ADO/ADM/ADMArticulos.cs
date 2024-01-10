using MVC.ADO.Models;
using System.Data;
using System.Data.SqlClient;

namespace MVC.ADO.ADM
{
    public class ADMArticulos : BaseADM
    {

        
        public int Alta(Articulo pArticulo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("insert into articulos(Codigo, Descripcion, Precio)  values(@codigo, @descripcion, @precio)", conexion);
            sentencia.Parameters.Add("@codigo", SqlDbType.VarChar);
            sentencia.Parameters.Add("@descripcion", SqlDbType.VarChar);
            sentencia.Parameters.Add("@precio", SqlDbType.Decimal);
            sentencia.Parameters["@codigo"].Value = pArticulo.Codigo;
            sentencia.Parameters["@descripcion"].Value = pArticulo.Descripcion;
            sentencia.Parameters["@precio"].Value = pArticulo.Precio;
            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }

        public List<Articulo> TraerTodos()
        {
            Conectar();
            List<Articulo> articulos = new List<Articulo>();
            SqlCommand sentencia = new SqlCommand("select Id,codigo, descripcion, precio from articulos",
            conexion);
            conexion.Open();
            SqlDataReader registros = sentencia.ExecuteReader();
            while (registros.Read())
            {
                Articulo articulo = new Articulo
                {
                    Codigo =  registros["codigo"].ToString() ,
                    Descripcion = registros["descripcion"].ToString(),
                    Precio = decimal.Parse(registros["precio"].ToString()) ,
                    Id = int.Parse(registros["Id"].ToString())
                };
                articulos.Add(articulo);
            }

            conexion.Close();
            return articulos;
        }
        public Articulo TraerArticulo(int  id)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("select Id,codigo, descripcion, precio  from articulos where Id = @Id", conexion);
            sentencia.Parameters.Add("@Id", SqlDbType.VarChar);
            sentencia.Parameters["@Id"].Value = id;
            conexion.Open();
            SqlDataReader registros = sentencia.ExecuteReader();
            Articulo articulo = new Articulo();
            if (registros.Read())
            {
                articulo.Codigo =  registros["codigo"].ToString() ;
                articulo.Descripcion = registros["descripcion"].ToString();
                articulo.Precio = decimal.Parse(registros["precio"].ToString());
                articulo.Id = int.Parse(registros["Id"].ToString());
            }

            conexion.Close();
            return articulo;
        }
        public int Modificar(Articulo pArticulo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("update articulos set  descripcion = @descripcion, precio = @precio, codigo = @codigo where Id = @Id  ", conexion);
            sentencia.Parameters.Add("@descripcion", SqlDbType.VarChar);
            sentencia.Parameters["@descripcion"].Value = pArticulo.Descripcion;
            sentencia.Parameters.Add("@precio", SqlDbType.Money);
            sentencia.Parameters["@precio"].Value = pArticulo.Precio;
            sentencia.Parameters.Add("@codigo", SqlDbType.VarChar);
            sentencia.Parameters["@codigo"].Value = pArticulo.Codigo;
            sentencia.Parameters.Add("@Id", SqlDbType.Int);
            sentencia.Parameters["@Id"].Value = pArticulo.Id;
            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }

        public int Borrar(int pCodigo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("delete from articulos where Id=@codigo", conexion);
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;
            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }

    }
}
