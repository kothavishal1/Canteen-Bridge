using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;

namespace Brings_Canteen.DAL
{
    public class CanteenConfiguration : DbConfiguration
    {

        public CanteenConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
            DbInterception.Add(new CanteenInterceptorTransientErrors());
            DbInterception.Add(new CanteenInterceptorLogging());
        }
    }
}