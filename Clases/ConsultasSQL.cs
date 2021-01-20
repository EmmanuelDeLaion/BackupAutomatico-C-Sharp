using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ABCBackup.Clases
{
    class ConsultasSQL
    {
        private SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-P9VH1GC; Initial Catalog = AbcBackup; Integrated Security = true");
        private DataSet ds;



        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand sqlc = new SqlCommand("select * from usuarios",conexion);
            SqlDataAdapter da = new SqlDataAdapter(sqlc);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }


        public DataTable Buscar(string usuario)
        {
            conexion.Open();
            SqlCommand sqlc = new SqlCommand(string.Format("select * from usuarios where usuario like '%{0}%'",usuario), conexion);
            SqlDataAdapter da = new SqlDataAdapter(sqlc);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }


        public bool Insertar(string id, string nombre, string usuario, string correo, string contrasena)
        {
            conexion.Open();
            SqlCommand sqlc = new SqlCommand(string.Format("insert into usuarios values ({0}, '{1}', '{2}', '{3}', '{4}')", new string[] {id,nombre,usuario,correo,contrasena }),conexion);
            int filasafectadas = sqlc.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }



        public bool Eliminar(string id)
        {
            conexion.Open();
            SqlCommand sqlc = new SqlCommand(string.Format("delete from usuarios where id = {0}",id), conexion);
            int filasafectadas = sqlc.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }


        public bool Actualizar(string id, string nombre, string usuario, string correo, string contrasena)
        {
            conexion.Open();
            SqlCommand sqlc = new SqlCommand(string.Format("update usuarios set nombre = '{0}', usuario = '{1}', correo = '{2}', contrasena = '{3}' where id = {4}", new string[] {nombre,usuario,correo,contrasena,id}), conexion);
            int filasafectadas = sqlc.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }




    }
}
