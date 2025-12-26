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
using Trafico.BusinessObjects.Transporte;
using Trafico.DataObjects.Transporte;

namespace Trafico.Facade.Transporte
{
    
    
    [DataObject(true)]
    public partial class MaterialFacade
    {
        
        private MaterialDao material;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public MaterialFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: material = new MaterialDao();
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
        public virtual bool Grabar(CMaterial oMaterial)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oMaterial.IDMaterial<=0)
            {
            	Error = "IDMaterial no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return material.Grabar(oMaterial);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CMaterial oMaterial, out string error)
        {
            bool rpta = Grabar(oMaterial);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 IDMaterial)
        {
            return material.Eliminar(IDMaterial);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CMaterial Recuperar(Int32 IDMaterial)
        {
            return material.Recuperar(IDMaterial);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 IDMaterial)
        {
            return material.Existe(IDMaterial);
        }
        
        public virtual bool Existe(Int32 IDMaterial, out CMaterial oMaterial)
        {
            return material.Existe(IDMaterial, out oMaterial);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CMaterial> Listar()
        {
            return material.Listar();
        }
        #endregion
    }
}
