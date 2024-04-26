using Empresa.Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Proyecto.Core.Specifications
{
    /// <summary>
    /// Ejemplo clase de especificacion. Se crean las especificaciones necesarias para 
    /// las diferentes consultas necesarias
    /// </summary>
    public class SimpleEntityAlphabeticalOrderSpecification : BaseSpecification<SimpleEntity>
    {
        /// <summary>
        /// Esta especificacion recibe un parametro y aplica un filtro. 
        /// Tambine se definen configuraciones auxiliares como Includes, orders y paginacion
        /// </summary>
        public SimpleEntityAlphabeticalOrderSpecification(int skip, int take) 
        {
            ApplyOrderBy(c => c.Name);
            ApplyPaging(skip, take);
        }
    }
}
