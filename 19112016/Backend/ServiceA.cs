using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend
{
    public class ServiceA:IServiceA
    {
        public ServiceA(IServiceC serviceC, IRepoA repoA, ServiceASettings settings)
        {

        }
    }
}