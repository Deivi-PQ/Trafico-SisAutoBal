//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using LibreriaBSNetCore;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Trafico.BusinessObjects.Global;
using Trafico.BusinessObjects.Seguridad;

namespace Trafico.DataObjects.Global
{
    
    
    public partial class VehiculoDao : DataAccessBase
    {
        
        public virtual CVehiculo getVehiculo(DataRow dr)
        {
            return new CVehiculo(Convert.ToString(dr["Nro_Placa"]),Convert.ToString(dr["IDProveedor"]),Convert.ToString(dr["Cod_Interno"]),Convert.ToString(dr["Marca"]),Convert.ToString(dr["Modelo"]),Convert.ToString(dr["Obs_Vehiculo"]),Convert.ToString(dr["Nro_Certif_Inscripcion"]),Convert.ToInt32(dr["Año"]),Convert.ToInt16(dr["Nro_Ejes"]),Convert.ToChar(dr["Estado"]),Convert.ToDouble(dr["Largo"]),Convert.ToDouble(dr["Ancho"]),Convert.ToDouble(dr["Alto"]),Convert.ToString(dr["Conf_Vehicular"]),Convert.ToDouble(dr["Peso"]), Convert.ToChar(dr["Tipo_Unidad"]));
        }
        
        public virtual CVehiculo getVehiculo(IDataReader dr)
        {
            return new CVehiculo(Convert.ToString(dr["Nro_Placa"]),Convert.ToString(dr["IDProveedor"]),Convert.ToString(dr["Cod_Interno"]),Convert.ToString(dr["Marca"]),Convert.ToString(dr["Modelo"]),Convert.ToString(dr["Obs_Vehiculo"]),Convert.ToString(dr["Nro_Certif_Inscripcion"]),Convert.ToInt32(dr["Año"]),Convert.ToInt16(dr["Nro_Ejes"]),Convert.ToChar(dr["Estado"]),Convert.ToDouble(dr["Largo"]),Convert.ToDouble(dr["Ancho"]),Convert.ToDouble(dr["Alto"]),Convert.ToString(dr["Conf_Vehicular"]),Convert.ToDouble(dr["Peso"]), Convert.ToChar(dr["Tipo_Unidad"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CVehiculo oVehiculo)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Vehiculo_Guardar")){
            Db.AddInParameter(dbCmd, "Nro_Placa", DbType.String, oVehiculo.Nro_Placa);
            Db.AddInParameter(dbCmd, "IDProveedor", DbType.String, oVehiculo.IDProveedor);
            Db.AddInParameter(dbCmd, "Cod_Interno", DbType.String, oVehiculo.Cod_Interno);
            Db.AddInParameter(dbCmd, "Marca", DbType.String, oVehiculo.Marca);
            Db.AddInParameter(dbCmd, "Modelo", DbType.String, oVehiculo.Modelo);
            Db.AddInParameter(dbCmd, "Obs_Vehiculo", DbType.String, oVehiculo.Obs_Vehiculo);
            Db.AddInParameter(dbCmd, "Nro_Certif_Inscripcion", DbType.String, oVehiculo.Nro_Certif_Inscripcion);
            Db.AddInParameter(dbCmd, "Año", DbType.Int32, oVehiculo.Año);
            Db.AddInParameter(dbCmd, "Nro_Ejes", DbType.Int16, oVehiculo.Nro_Ejes);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oVehiculo.Estado);
            Db.AddInParameter(dbCmd, "Largo", DbType.Double, oVehiculo.Largo);
            Db.AddInParameter(dbCmd, "Ancho", DbType.Double, oVehiculo.Ancho);
            Db.AddInParameter(dbCmd, "Alto", DbType.Double, oVehiculo.Alto);
            Db.AddInParameter(dbCmd, "Conf_Vehicular", DbType.String, oVehiculo.Conf_Vehicular);
            Db.AddInParameter(dbCmd, "Peso", DbType.Double, oVehiculo.Peso);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Nro_Placa)
        {
            return Db.ExecuteNonQuery("Global.spu_Vehiculo_Eliminar",Nro_Placa);
        }
        
        public virtual CVehiculo Recuperar(String Nro_Placa)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Vehiculo_Recuperar",Nro_Placa).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getVehiculo(dtDatos.Rows[0]);
            else
            return new CVehiculo();
        }
        
        public virtual bool Existe(String Nro_Placa)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Vehiculo_Recuperar",Nro_Placa).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Nro_Placa, out CVehiculo oVehiculo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Vehiculo_Recuperar",Nro_Placa).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oVehiculo = getVehiculo(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oVehiculo = new CVehiculo();
                return false;
            }
        }
        
        public virtual IList<CVehiculo> Listar(String Nro_Placa, String IDProveedor, Int16 Año, Int16 Nro_Ejes, String Estado, String Tipo_Unidad)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Vehiculo_Listar"))
            {
                Db.AddInParameter(dbCmd, "Nro_Placa", DbType.String, Nro_Placa == "*" ? DBNull.Value : Nro_Placa);
                Db.AddInParameter(dbCmd, "IDProveedor", DbType.String, IDProveedor == "*" ? DBNull.Value : IDProveedor);
                Db.AddInParameter(dbCmd, "Año", DbType.Int64, Año == 0 ? DBNull.Value : Año);
                Db.AddInParameter(dbCmd, "Nro_Ejes", DbType.Int16, Nro_Ejes == 0 ? DBNull.Value : Nro_Ejes);
                Db.AddInParameter(dbCmd, "Estado", DbType.String, Estado == "*" ? DBNull.Value : Estado);
                Db.AddInParameter(dbCmd, "Tipo_Unidad", DbType.String, Tipo_Unidad == "*" ? DBNull.Value : Tipo_Unidad);
                using (IDataReader dr = Db.ExecuteReader(dbCmd))
                {
                    IList<CVehiculo> list = new List<CVehiculo>();
                    while (dr.Read())
                        list.Add(getVehiculo(dr));
                    return list;
                }
            }
        }
        #endregion
    }
}
