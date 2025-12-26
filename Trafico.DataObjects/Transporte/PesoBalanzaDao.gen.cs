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
using System.Text.RegularExpressions;
using Trafico.BusinessObjects.Transporte;
using Trafico.BusinessObjects.Utils;

namespace Trafico.DataObjects.Transporte
{
    
    
    public partial class PesoBalanzaDao : DataAccessBase
    {

        public virtual CPesoBalanza getPesoBalanza(DataRow dr)
        {
            return new CPesoBalanza(
                dr["IDPesaje"] == DBNull.Value ? 0 : Convert.ToInt32(dr["IDPesaje"]),
                dr["Tipo_Mov"] == DBNull.Value || string.IsNullOrEmpty(dr["Tipo_Mov"].ToString()) ? '\0' : Convert.ToChar(dr["Tipo_Mov"]),
                dr["Nro_Placa"] == DBNull.Value ? "" : Convert.ToString(dr["Nro_Placa"]),
                dr["DNI_Conductor"] == DBNull.Value ? "" : Convert.ToString(dr["DNI_Conductor"]),
                dr["IDBalanza"] == DBNull.Value ? "" : Convert.ToString(dr["IDBalanza"]),
                dr["Peso"] == DBNull.Value ? 0.0 : Convert.ToDouble(dr["Peso"]),
                dr["FechaHora"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["FechaHora"]),
                dr["Status"] == DBNull.Value || string.IsNullOrEmpty(dr["Status"].ToString()) ? '\0' : Convert.ToChar(dr["Status"]),
                dr["IDMaterial"] == DBNull.Value ? 0 : Convert.ToInt32(dr["IDMaterial"]),
                dr["IDPesajeEnt"] == DBNull.Value ? 0 : Convert.ToInt32(dr["IDPesajeEnt"]),
                dr["UserNew"] == DBNull.Value ? "" : Convert.ToString(dr["UserNew"]),
                dr["UserEdit"] == DBNull.Value ? "" : Convert.ToString(dr["UserEdit"]),
                dr["DateNew"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateNew"]),
                dr["DateEdit"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateEdit"]),
                dr["Turno"] == DBNull.Value || string.IsNullOrEmpty(dr["Turno"].ToString()) ? '\0' : Convert.ToChar(dr["Turno"]),
                dr["Tipo_Unidad"] == DBNull.Value ? "" : Convert.ToString(dr["Tipo_Unidad"]),
                dr["Destinatario"] == DBNull.Value ? "" : Convert.ToString(dr["Destinatario"]),
                dr["Lugar_Carga"] == DBNull.Value ? "" : Convert.ToString(dr["Lugar_Carga"])
            );
        }

        public virtual CPesoBalanza getPesoBalanza(IDataReader dr)
        {
            return new CPesoBalanza(
                dr["IDPesaje"] == DBNull.Value ? 0 : Convert.ToInt32(dr["IDPesaje"]),
                dr["Tipo_Mov"] == DBNull.Value || string.IsNullOrEmpty(dr["Tipo_Mov"].ToString()) ? '\0' : Convert.ToChar(dr["Tipo_Mov"]),
                dr["Nro_Placa"] == DBNull.Value ? "" : Convert.ToString(dr["Nro_Placa"]),
                dr["DNI_Conductor"] == DBNull.Value ? "" : Convert.ToString(dr["DNI_Conductor"]),
                dr["IDBalanza"] == DBNull.Value ? "" : Convert.ToString(dr["IDBalanza"]),
                dr["Peso"] == DBNull.Value ? 0.0 : Convert.ToDouble(dr["Peso"]),
                dr["FechaHora"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["FechaHora"]),
                dr["Status"] == DBNull.Value || string.IsNullOrEmpty(dr["Status"].ToString()) ? '\0' : Convert.ToChar(dr["Status"]),
                dr["IDMaterial"] == DBNull.Value ? 0 : Convert.ToInt32(dr["IDMaterial"]),
                dr["IDPesajeEnt"] == DBNull.Value ? 0 : Convert.ToInt32(dr["IDPesajeEnt"]),
                dr["UserNew"] == DBNull.Value ? "" : Convert.ToString(dr["UserNew"]),
                dr["UserEdit"] == DBNull.Value ? "" : Convert.ToString(dr["UserEdit"]),
                dr["DateNew"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateNew"]),
                dr["DateEdit"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["DateEdit"]),
                dr["Turno"] == DBNull.Value || string.IsNullOrEmpty(dr["Turno"].ToString()) ? '\0' : Convert.ToChar(dr["Turno"]),
                dr["Tipo_Unidad"] == DBNull.Value ? "" : Convert.ToString(dr["Tipo_Unidad"]),
                dr["Destinatario"] == DBNull.Value ? "" : Convert.ToString(dr["Destinatario"]),
                dr["Lugar_Carga"] == DBNull.Value ? "" : Convert.ToString(dr["Lugar_Carga"])
            );
        }

        #region Metodos Principales
        public virtual bool Grabar(CPesoBalanza oPesoBalanza)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Transporte.PesoBalanza_Guardar"))
            {
                Db.AddInParameter(dbCmd, "IDPesaje", DbType.Int32, oPesoBalanza.IDPesaje);
                Db.AddInParameter(dbCmd, "Tipo_Mov", DbType.String, oPesoBalanza.Tipo_Mov);
                Db.AddInParameter(dbCmd, "Nro_Placa", DbType.String, oPesoBalanza.Nro_Placa);
                Db.AddInParameter(dbCmd, "DNI_Conductor", DbType.String, oPesoBalanza.DNI_Conductor);
                Db.AddInParameter(dbCmd, "IDBalanza", DbType.String, oPesoBalanza.IDBalanza);
                Db.AddInParameter(dbCmd, "Peso", DbType.Double, oPesoBalanza.Peso);
                Db.AddInParameter(dbCmd, "FechaHora", DbType.DateTime, oPesoBalanza.FechaHora);
                Db.AddInParameter(dbCmd, "Status", DbType.String, oPesoBalanza.Status);
                Db.AddInParameter(dbCmd, "IDMaterial", DbType.Int32, oPesoBalanza.IDMaterial);
                Db.AddInParameter(dbCmd, "IDPesajeEnt", DbType.Int32, oPesoBalanza.IDPesajeEnt);
                Db.AddInParameter(dbCmd, "UserNew", DbType.String, oPesoBalanza.UserNew);
                Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oPesoBalanza.UserEdit);
                Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oPesoBalanza.DateNew);
                Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oPesoBalanza.DateEdit);
                Db.AddInParameter(dbCmd, "Turno", DbType.String, oPesoBalanza.Turno);
                Db.AddInParameter(dbCmd, "Tipo_Unidad", DbType.String, oPesoBalanza.Tipo_Unidad);
                Db.AddInParameter(dbCmd, "Destinatario", DbType.String, oPesoBalanza.Destinatario);
                Db.AddInParameter(dbCmd, "Lugar_Carga", DbType.String, oPesoBalanza.Lugar_Carga);
                // --- Ejecutando procedimiento almacenado
                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }

        public virtual int Eliminar(Int32 IDPesaje)
        {
            return Db.ExecuteNonQuery("Transporte.spu_PesoBalanza_Eliminar",IDPesaje);
        }
        
        public virtual CPesoBalanza Recuperar(Int32 IDPesaje)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_PesoBalanza_Recuperar",IDPesaje).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getPesoBalanza(dtDatos.Rows[0]);
            else
            return new CPesoBalanza();
        }
        
        public virtual bool Existe(Int32 IDPesaje)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_PesoBalanza_Recuperar",IDPesaje).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int32 IDPesaje, out CPesoBalanza oPesoBalanza)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_PesoBalanza_Recuperar",IDPesaje).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oPesoBalanza = getPesoBalanza(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oPesoBalanza = new CPesoBalanza();
            return false;
            }
        }
        
        public virtual IList<CPesoBalanza> Listar(String IDBalanza, String ID, String Nro_Placa, DateTime fecha_Ini, DateTime fecha_Fin, int page_Number, int page_Size)
        {
            Util util = new Util();
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_PesoBalanza_Filtrar",
                util.DbNullIf(IDBalanza),
                util.DbNullIf(ID),
                util.DbNullIf(Nro_Placa),
                util.DbNullIf(fecha_Ini),
                util.DbNullIf(fecha_Fin),
                util.DbNullIf(page_Number),
                util.DbNullIf(page_Size)
            ).Tables[0];

            if (!Util.TablaVacia(dtDatos))
                return Util.ParseDataTable<CPesoBalanza>(dtDatos);
            else
                return new List<CPesoBalanza>();
        }
        public virtual DataTable ReportePesoBalanza(DateTime fecha_Ini, DateTime fecha_Fin, String Nro_Placa)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Transporte.spu_Rep_PesoBalanza", fecha_Ini, fecha_Fin,Nro_Placa).Tables[0];
            return dtDatos;
        }
        #endregion
    }
}
