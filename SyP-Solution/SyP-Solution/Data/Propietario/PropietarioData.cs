using SyP_Solution.Models;
using SyP_Solution.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SyP_Solution.Data.Propietario
{
    public class PropietarioData
    {
        DBPruebaEntities cadenaC = new DBPruebaEntities();

        public bool AgegarPropietario(PropietarioEntity propietario)
        {
            bool agregar = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaC.Database.Connection.ConnectionString ))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CrearPropietario", con))
                    {
                        //Le indicas al SqlCommando que lo que va a ejecutar es Tipo Procedimiento Almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Aquí agregas los parámetros de tu procedimiento
                        cmd.Parameters.Add("@strNumeeroIdentificacion", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strNombre", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strApellido", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strDireccion", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strTelefono", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strCorreo", SqlDbType.VarChar);
                        //asignamos el valor de los textbox a los parametros
                        cmd.Parameters["@strNumeeroIdentificacion"].Value = propietario.strNumeeroIdentificacion;
                        cmd.Parameters["@strNombre"].Value = propietario.strNombre;
                        cmd.Parameters["@strApellido"].Value = propietario.strApellido ;
                        cmd.Parameters["@strDireccion"].Value = propietario.strDireccion;
                        cmd.Parameters["@strTelefono"].Value = propietario.strTelefono;
                        cmd.Parameters["@strCorreo"].Value = propietario.strCorreo;
                        //Abrimos la conexión 
                        con.Open();
                        //Ejecutas el procedimiento, y guardas en una variable tipo int el número de lineas afectadas en las tablas que se insertaron
                        //(ExecuteNonQuery devuelve un valor entero, en éste caso, devolverá el número de filas afectadas después del insert, si es mayor a > 0, entonces el insert se hizo con éxito)
                        int numero = cmd.ExecuteNonQuery();
                        //Cerramos la conexión
                        con.Close();
                        agregar = true;
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                agregar = false;
                
            }
            return agregar;
           
        }

     

        public bool EditarPropietario(PropietarioEntity propietario)
        {
            bool Editar = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaC.Database.Connection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_EditarPropietario", con))
                    {
                        //Le indicas al SqlCommando que lo que va a ejecutar es Tipo Procedimiento Almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Aquí agregas los parámetros de tu procedimiento
                        cmd.Parameters.Add("@intId", SqlDbType.Int);
                        cmd.Parameters.Add("@strNumeeroIdentificacion", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strNombre", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strApellido", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strDireccion", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strTelefono", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strCorreo", SqlDbType.VarChar);
                        //asignamos el valor de los textbox a los parametros
                        cmd.Parameters["@intId"].Value = propietario.intId ;
                        cmd.Parameters["@strNumeeroIdentificacion"].Value = propietario.strNumeeroIdentificacion;
                        cmd.Parameters["@strNombre"].Value = propietario.strNombre;
                        cmd.Parameters["@strApellido"].Value = propietario.strApellido;
                        cmd.Parameters["@strDireccion"].Value = propietario.strDireccion;
                        cmd.Parameters["@strTelefono"].Value = propietario.strTelefono;
                        cmd.Parameters["@strCorreo"].Value = propietario.strCorreo;
                        //Abrimos la conexión 
                        con.Open();
                        //Ejecutas el procedimiento, y guardas en una variable tipo int el número de lineas afectadas en las tablas que se insertaron
                        //(ExecuteNonQuery devuelve un valor entero, en éste caso, devolverá el número de filas afectadas después del insert, si es mayor a > 0, entonces el insert se hizo con éxito)
                        int numero = cmd.ExecuteNonQuery();
                        //cerramos la conexión
                        con.Close();
                        Editar = true;
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Editar = false;

            }
            return Editar;

        }

        public bool EliminarPropietario(PropietarioEntity propietario)
        {
            bool Eliminar = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaC.Database.Connection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_EliminarPropietario", con))
                    {
                        //Le indicas al SqlCommando que lo que va a ejecutar es Tipo Procedimiento Almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Aquí agregas los parámetros de tu procedimiento
                        cmd.Parameters.Add("@intId", SqlDbType.Int);
                        //asignamos el valor obtenido de los parametros
                        cmd.Parameters["@intId"].Value = propietario.intId;
                        //Abrimos la conexión 
                        con.Open();
                        int numero = cmd.ExecuteNonQuery();
                        //cerramos la conexión
                        con.Close();
                        Eliminar = true;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Eliminar = false;

            }
            return Eliminar;
        }

    }
}