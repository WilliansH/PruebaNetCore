using System;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Microsoft.IdentityModel.Protocols;

namespace CarCenter.Core.API.Datos
{
    public class Conexion
    {
        private readonly string conexionString;

        public Conexion(IConfiguration configuration) 
        {
            conexionString = configuration.GetConnectionString("CarCenterConnection");
        }

        #region DataRow
        public  DataRow ConsultaDr(string carcenter)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    using (SqlCommand cmd = new SqlCommand(carcenter, conexion))
                    {
                        using (SqlDataAdapter dataadapter = new SqlDataAdapter())
                        {
                            using (DataSet dataset = new DataSet())
                            {
                                try
                                {
                                    conexion.Open();
                                    {
                                        var withBlock = dataadapter;
                                        withBlock.SelectCommand = cmd;
                                        withBlock.Fill(dataset);
                                    }
                                }
                                catch (Exception Ex)
                                {                                   
                                    ;
                                }
                                finally
                                {
                                    conexion.Close();
                                }
                                return dataset.Tables[0].Rows[0];
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        #endregion

        #region DataTable
        public DataTable ConsultaDt(string carcenter)
        { 
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    using (SqlCommand cmd = new SqlCommand(carcenter, conexion))
                    {
                        using (SqlDataAdapter dataadapter = new SqlDataAdapter())
                        {
                            using (DataSet dataset = new DataSet())
                            {
                                try
                                {
                                    conexion.Open();
                                    {
                                        var withBlock = dataadapter;
                                        withBlock.SelectCommand = cmd;
                                        withBlock.Fill(dataset);
                                    }
                                }
                                catch (Exception Ex)
                                {
                                    ;
                                }
                                finally
                                {
                                    conexion.Close();
                                }
                                return dataset.Tables[0];
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        #endregion

        #region DataSet
        public DataSet ConsultaDs(string carcenter)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    using (SqlCommand cmd = new SqlCommand(carcenter, conexion))
                    {
                        using (SqlDataAdapter dataadapter = new SqlDataAdapter())
                        {
                            using (DataSet dataset = new DataSet())
                            {
                                try
                                {
                                    conexion.Open();
                                    {
                                        var withBlock = dataadapter;
                                        withBlock.SelectCommand = cmd;
                                        withBlock.Fill(dataset);
                                    }
                                }
                                catch (Exception Ex)
                                {
                                    ;
                                }
                                finally
                                {
                                    conexion.Close();
                                }
                                return dataset;
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        #endregion

        #region Metodos Publicos
        public string ConsultaScalar(string carcenter)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    using (SqlCommand cmd = new SqlCommand(carcenter, conexion))
                    {
                        try
                        {
                            conexion.Open();
                            return Convert.ToString(cmd.ExecuteScalar());
                        }
                        catch (Exception Ex)
                        {
                            return "";
                        }
                        finally
                        {
                            conexion.Close();
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                return "";
            }
        }
        public string ConsultaScalarCarCenter(string carcenter)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    using (SqlCommand cmd = new SqlCommand(carcenter, conexion))
                    {
                        try
                        {
                            conexion.Open();
                            return Convert.ToString(cmd.ExecuteScalar());
                        }
                        catch (Exception Ex)
                        {
                            return "";
                        }
                        finally
                        {
                            conexion.Close();
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        public bool Obtiene(string carcenter)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    using (SqlCommand cmd = new SqlCommand(carcenter, conexion))
                    {
                        try
                        {
                            conexion.Open();
                            cmd.ExecuteNonQuery();
                            return true;
                        }
                        catch (Exception Ex)
                        {
                            return false;
                        }
                        finally
                        {
                            conexion.Close();
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                return default(Boolean);
            }
        }
        #endregion

    }
}