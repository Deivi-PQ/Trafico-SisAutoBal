//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: viernes, 26 de septiembre de 2008
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;

namespace Trafico.BusinessObjects.Comun
{
    
    
    public class CParametroSP
    {
        
        #region Atributos
        // Atributos
        private string _Codigo_Parametro;
        
        private string _Valor_Parametro;

        private string _Tipo;

        #endregion
        
        #region Constructores
        // Constructores
        public CParametroSP()
        {
        }

        public CParametroSP(string Codigo_Parametro_, string Valor_Parametro_, string Tipo_)
        {
            _Codigo_Parametro = Codigo_Parametro_;
            _Valor_Parametro = Valor_Parametro_;
            _Tipo = Tipo_;
        }
        #endregion
        
        #region Propiedades
        // Propiedades
        public virtual string Codigo_Parametro
        {
            get
            {
                return this._Codigo_Parametro;
            }
            set
            {
                this._Codigo_Parametro = value;
            }
        }

        public virtual string Valor_Parametro
        {
            get
            {
                return this._Valor_Parametro;
            }
            set
            {
                this._Valor_Parametro = value;
            }
        }

        public virtual string Tipo
        {
            get
            {
                return this._Tipo;
            }
            set
            {
                this._Tipo = value;
            }
        }
        


        #endregion
    }
}
