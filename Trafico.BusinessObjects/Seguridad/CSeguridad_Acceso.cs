using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Trafico.BusinessObjects.Seguridad
{
    public class CSeguridad_Acceso
    {
        // --- Atributos
        #region Atributos

        int _IDUsuario;
        DataView _dvMenu;

        #endregion Atributos

        // --- Constructores
        #region Constructores
        public CSeguridad_Acceso()
        {
        }

        public CSeguridad_Acceso(int iDUsuario)
        {
            _IDUsuario = iDUsuario;            
        }
        #endregion Constructores

        // --- Propiedades
        #region Propiedades
        public int IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        public DataView dvMenu
        {
            get { return _dvMenu; }
            set { _dvMenu = value; }
        }
        #endregion Propiedades


    }
}
