//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Trafico.BusinessObjects.Global;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;

namespace Trafico.DataObjects.Global
{
    
    
    public partial class CarretaDao : DataAccessBase
    {
        
        public virtual CCarreta getCarreta(DataRow dr)
        {
            return new CCarreta(Convert.ToString(dr["Nro_Placa_Carreta"]),Convert.ToString(dr["Descripcion"]),Convert.ToString(dr["Nro_Certificado_Inscripcion"]),Convert.ToString(dr["IDProveedor"]),Convert.ToDouble(dr["Largo"]),Convert.ToDouble(dr["Ancho"]),Convert.ToDouble(dr["Alto"]),Convert.ToString(dr["Conf_Vehicular"]),Convert.ToDouble(dr["Peso"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToString(dr["Nro_Placa_Hist"]),Convert.ToDateTime(dr["Fecha_Ini"]),Convert.ToDateTime(dr["Fecha_Fin"]),Convert.ToString(dr["Obs_Carreta"]),Convert.ToBoolean(dr["Flag_Peso_Modif"]),Convert.ToDouble(dr["PesoMaxCjtoEje1"]),Convert.ToDouble(dr["PesoMaxCjtoEje2"]),Convert.ToString(dr["Modelo"]),Convert.ToString(dr["Color"]),Convert.ToInt32(dr["Anio"]),Convert.ToInt16(dr["NroEjes"]),Convert.ToString(dr["Tipo_Carroceria"]),Convert.ToString(dr["Tipo"]),Convert.ToString(dr["Clasificacion"]),Convert.ToDateTime(dr["Vcto_Bonificacion"]),Convert.ToDouble(dr["Porc_Bonif"]),Convert.ToString(dr["Precinto1"]),Convert.ToString(dr["Precinto2"]),Convert.ToChar(dr["Status"]),Convert.ToString(dr["IDCarreta"]));
        }
        
        public virtual CCarreta getCarreta(IDataReader dr)
        {
            return new CCarreta(Convert.ToString(dr["Nro_Placa_Carreta"]),Convert.ToString(dr["Descripcion"]),Convert.ToString(dr["Nro_Certificado_Inscripcion"]),Convert.ToString(dr["IDProveedor"]),Convert.ToDouble(dr["Largo"]),Convert.ToDouble(dr["Ancho"]),Convert.ToDouble(dr["Alto"]),Convert.ToString(dr["Conf_Vehicular"]),Convert.ToDouble(dr["Peso"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToString(dr["Nro_Placa_Hist"]),Convert.ToDateTime(dr["Fecha_Ini"]),Convert.ToDateTime(dr["Fecha_Fin"]),Convert.ToString(dr["Obs_Carreta"]),Convert.ToBoolean(dr["Flag_Peso_Modif"]),Convert.ToDouble(dr["PesoMaxCjtoEje1"]),Convert.ToDouble(dr["PesoMaxCjtoEje2"]),Convert.ToString(dr["Modelo"]),Convert.ToString(dr["Color"]),Convert.ToInt32(dr["Anio"]),Convert.ToInt16(dr["NroEjes"]),Convert.ToString(dr["Tipo_Carroceria"]),Convert.ToString(dr["Tipo"]),Convert.ToString(dr["Clasificacion"]),Convert.ToDateTime(dr["Vcto_Bonificacion"]),Convert.ToDouble(dr["Porc_Bonif"]),Convert.ToString(dr["Precinto1"]),Convert.ToString(dr["Precinto2"]),Convert.ToChar(dr["Status"]),Convert.ToString(dr["IDCarreta"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CCarreta oCarreta)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Carreta_Guardar")){
            Db.AddInParameter(dbCmd, "Nro_Placa_Carreta", DbType.String, oCarreta.Nro_Placa_Carreta);
            Db.AddInParameter(dbCmd, "Descripcion", DbType.String, oCarreta.Descripcion);
            Db.AddInParameter(dbCmd, "Nro_Certificado_Inscripcion", DbType.String, oCarreta.Nro_Certificado_Inscripcion);
            Db.AddInParameter(dbCmd, "IDProveedor", DbType.String, oCarreta.IDProveedor);
            Db.AddInParameter(dbCmd, "Largo", DbType.Double, oCarreta.Largo);
            Db.AddInParameter(dbCmd, "Ancho", DbType.Double, oCarreta.Ancho);
            Db.AddInParameter(dbCmd, "Alto", DbType.Double, oCarreta.Alto);
            Db.AddInParameter(dbCmd, "Conf_Vehicular", DbType.String, oCarreta.Conf_Vehicular);
            Db.AddInParameter(dbCmd, "Peso", DbType.Double, oCarreta.Peso);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oCarreta.UserNew);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oCarreta.DateNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oCarreta.UserEdit);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oCarreta.DateEdit);
            Db.AddInParameter(dbCmd, "Nro_Placa_Hist", DbType.String, oCarreta.Nro_Placa_Hist);
            Db.AddInParameter(dbCmd, "Fecha_Ini", DbType.DateTime, oCarreta.Fecha_Ini);
            Db.AddInParameter(dbCmd, "Fecha_Fin", DbType.DateTime, oCarreta.Fecha_Fin);
            Db.AddInParameter(dbCmd, "Obs_Carreta", DbType.String, oCarreta.Obs_Carreta);
            Db.AddInParameter(dbCmd, "Flag_Peso_Modif", DbType.Boolean, oCarreta.Flag_Peso_Modif);
            Db.AddInParameter(dbCmd, "PesoMaxCjtoEje1", DbType.Double, oCarreta.PesoMaxCjtoEje1);
            Db.AddInParameter(dbCmd, "PesoMaxCjtoEje2", DbType.Double, oCarreta.PesoMaxCjtoEje2);
            Db.AddInParameter(dbCmd, "Modelo", DbType.String, oCarreta.Modelo);
            Db.AddInParameter(dbCmd, "Color", DbType.String, oCarreta.Color);
            Db.AddInParameter(dbCmd, "Anio", DbType.Int32, oCarreta.Anio);
            Db.AddInParameter(dbCmd, "NroEjes", DbType.Int16, oCarreta.NroEjes);
            Db.AddInParameter(dbCmd, "Tipo_Carroceria", DbType.String, oCarreta.Tipo_Carroceria);
            Db.AddInParameter(dbCmd, "Tipo", DbType.String, oCarreta.Tipo);
            Db.AddInParameter(dbCmd, "Clasificacion", DbType.String, oCarreta.Clasificacion);
            Db.AddInParameter(dbCmd, "Vcto_Bonificacion", DbType.DateTime, oCarreta.Vcto_Bonificacion);
            Db.AddInParameter(dbCmd, "Porc_Bonif", DbType.Double, oCarreta.Porc_Bonif);
            Db.AddInParameter(dbCmd, "Precinto1", DbType.String, oCarreta.Precinto1);
            Db.AddInParameter(dbCmd, "Precinto2", DbType.String, oCarreta.Precinto2);
            Db.AddInParameter(dbCmd, "Status", DbType.String, oCarreta.Status);
            Db.AddInParameter(dbCmd, "IDCarreta", DbType.String, oCarreta.IDCarreta);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String IDCarreta)
        {
            return Db.ExecuteNonQuery("Global.spu_Carreta_Eliminar",IDCarreta);
        }
        
        public virtual CCarreta Recuperar(String IDCarreta)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Carreta_Recuperar",IDCarreta).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getCarreta(dtDatos.Rows[0]);
            else
            return new CCarreta();
        }
        
        public virtual bool Existe(String IDCarreta)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Carreta_Recuperar",IDCarreta).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String IDCarreta, out CCarreta oCarreta)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Carreta_Recuperar",IDCarreta).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oCarreta = getCarreta(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oCarreta = new CCarreta();
            return false;
            }
        }
        
        public virtual IList<CCarreta> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.spu_Carreta_Listar")){
            IList<CCarreta> list = new List<CCarreta>();
            while (dr.Read())
            list.Add(getCarreta(dr));
            return list;
            }
        }
        #endregion
    }
}
