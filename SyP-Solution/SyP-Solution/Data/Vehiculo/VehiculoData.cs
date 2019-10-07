using SyP_Solution.Models;
using SyP_Solution.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SyP_Solution.Data.Vehiculo
{
    public class VehiculoData
    {
        DBPruebaEntities cadenaC = new DBPruebaEntities();

        public bool AgregarVehiculo(VehiculoEntity vehiculo)
        {
            bool agregar = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaC.Database.Connection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CrearVehiculo", con))
                    {
                        //Le indicas al SqlCommando que lo que va a ejecutar es Tipo Procedimiento Almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Aquí agregas los parámetros de tu procedimiento
                        cmd.Parameters.Add("@strPlaca", SqlDbType.VarChar);
                        cmd.Parameters.Add("@intIdLinea", SqlDbType.Int);
                        cmd.Parameters.Add("@strModelo", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strNumeroMotor", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strColor", SqlDbType.VarChar);
                        cmd.Parameters.Add("@intIdClase", SqlDbType.Int);
                        cmd.Parameters.Add("@intIdTipoServicio", SqlDbType.Int);
                        //asignamos el valor de los textbox a los parametros
                        cmd.Parameters["@strPlaca"].Value = vehiculo.strPlaca;
                        cmd.Parameters["@intIdLinea"].Value = vehiculo.intIdLinea;
                        cmd.Parameters["@strModelo"].Value = vehiculo.strModelo;
                        cmd.Parameters["@strNumeroMotor"].Value = vehiculo.strNumeroMotor;
                        cmd.Parameters["@strColor"].Value = vehiculo.strColor;
                        cmd.Parameters["@intIdClase"].Value = vehiculo.intIdClase;
                        cmd.Parameters["@intIdTipoServicio"].Value = vehiculo.intIdTipoServicio;
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

        public bool EditarVehiculo(VehiculoEntity vehiculo)
        {
            bool Editar = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaC.Database.Connection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_EditarVehiculo", con))
                    {
                        //Le indicas al SqlCommando que lo que va a ejecutar es Tipo Procedimiento Almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Aquí agregas los parámetros de tu procedimiento
                        cmd.Parameters.Add("@intId", SqlDbType.Int);
                        cmd.Parameters.Add("@strPlaca", SqlDbType.VarChar);
                        cmd.Parameters.Add("@intIdLinea", SqlDbType.Int);
                        cmd.Parameters.Add("@strModelo", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strNumeroMotor", SqlDbType.VarChar);
                        cmd.Parameters.Add("@strColor", SqlDbType.VarChar);
                        cmd.Parameters.Add("@intIdClase", SqlDbType.Int);
                        cmd.Parameters.Add("@intIdTipoServicio", SqlDbType.Int);
                        //asignamos el valor de los textbox a los parametros
                        cmd.Parameters["@intId"].Value = vehiculo.intId;
                        cmd.Parameters["@strPlaca"].Value = vehiculo.strPlaca;
                        cmd.Parameters["@intIdLinea"].Value = vehiculo.intIdLinea;
                        cmd.Parameters["@strModelo"].Value = vehiculo.strModelo;
                        cmd.Parameters["@strNumeroMotor"].Value = vehiculo.strNumeroMotor;
                        cmd.Parameters["@strColor"].Value = vehiculo.strColor;
                        cmd.Parameters["@intIdClase"].Value = vehiculo.intIdClase;
                        cmd.Parameters["@intIdTipoServicio"].Value = vehiculo.intIdTipoServicio;
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

        public bool EliminarVehiculo(VehiculoEntity vehiculo)
        {
            bool Eliminar = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaC.Database.Connection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_EliminarVehiculo", con))
                    {
                        //Le indicas al SqlCommando que lo que va a ejecutar es Tipo Procedimiento Almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Aquí agregas los parámetros de tu procedimiento
                        cmd.Parameters.Add("@intId", SqlDbType.Int);
                        //asignamos el valor obtenido de los parametros
                        cmd.Parameters["@intId"].Value = vehiculo.intId;
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