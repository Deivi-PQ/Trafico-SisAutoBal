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
using Trafico.BusinessObjects.Global;
using Trafico.DataObjects.Global;

namespace Trafico.Facade.Global
{
    
    
    [DataObject(true)]
    public partial class ArchivoFacade
    {
        
        private ArchivoDao archivo;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public ArchivoFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: archivo = new ArchivoDao();
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
        public virtual bool Grabar(CArchivo oArchivo)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oArchivo.Cod_Archivo.Trim() == "")
            {
            	Error = "Cod_Archivo no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return archivo.Grabar(oArchivo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CArchivo oArchivo, out string error)
        {
            bool rpta = Grabar(oArchivo);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_Archivo)
        {
            return archivo.Eliminar(Cod_Archivo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CArchivo Recuperar(String Cod_Archivo)
        {
            return archivo.Recuperar(Cod_Archivo);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_Archivo)
        {
            return archivo.Existe(Cod_Archivo);
        }
        
        public virtual bool Existe(String Cod_Archivo, out CArchivo oArchivo)
        {
            return archivo.Existe(Cod_Archivo, out oArchivo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CArchivo> Listar()
        {
            return archivo.Listar();
        }
        #endregion
    }
}
