using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNetCore;
using System.Data;

namespace Trafico.DataObjects.Reportes
{

    public class RptTranspMaterialDao
    {
             
        #region Atributos
        private Database Db;
        #endregion
        
        #region Constructores
        
        public RptTranspMaterialDao()
        {
            Db = DatabaseFactory.CreateDatabase(DataAccessFactory.getVarConexion());
        }
        #endregion
        public DataTable rptRegTransporte_Material(int IDTransp_Material)
        {
             return Db.ExecuteDataSet(CommandType.Text, "exec spu_rptRegTransporte_Material '"  + IDTransp_Material+ "'").Tables[0];
        }
    }
}
