using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trafico.WebApi.Authorization
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AllowAnonymousAttribute: Attribute
    {
    }
}
