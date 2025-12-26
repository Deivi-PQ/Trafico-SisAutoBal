//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 12 de noviembre de 2025
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNetCore.InfoApp;
using Trafico.BusinessObjects.Auditoria;
using Trafico.DataObjects.Auditoria;

namespace Trafico.Facade.Auditoria
{
    
    
    [DataObject(true)]
    public partial class Modificacion_TablaFacade
    {
        
        private Modificacion_TablaDao modificacion_Tabla;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Modificacion_TablaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: modificacion_Tabla = new Modificacion_TablaDao();
            break;
            }
        }
        #endregion
        
        #region Metodos de Control de Errores
        public virtual string getError()
        {
            return Error;
        }
        
        public virtual bool HayError()
        {
            return hayError;
        }
        #endregion
        
        #region Metodos Basicos
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CModificacion_Tabla oModificacion_Tabla)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oModificacion_Tabla.idModificacion<=0)
            {
            	Error = "idModificacion no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return modificacion_Tabla.Grabar(oModificacion_Tabla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CModificacion_Tabla oModificacion_Tabla, out string error)
        {
            bool rpta = Grabar(oModificacion_Tabla);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 idModificacion)
        {
            return modificacion_Tabla.Eliminar(idModificacion);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CModificacion_Tabla Recuperar(Int32 idModificacion)
        {
            return modificacion_Tabla.Recuperar(idModificacion);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 idModificacion)
        {
            return modificacion_Tabla.Existe(idModificacion);
        }
        
        public virtual bool Existe(Int32 idModificacion, out CModificacion_Tabla oModificacion_Tabla)
        {
            return modificacion_Tabla.Existe(idModificacion, out oModificacion_Tabla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CModificacion_Tabla> Listar()
        {
            return modificacion_Tabla.Listar();
        }
        #endregion
    }
}
