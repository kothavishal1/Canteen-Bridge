using System;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace Brings_Canteen.DAL
{
    public class CanteenInterceptorTransientErrors : DbCommandInterceptor
    {
       
        private int _counter = 0;
        private ILogger _logger = new Logger();
        public override void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            // There is no need to throw any transient error

            //bool throwTransientErrors = true;

            //if (command.Parameters.Count > 0 /* && any other Condition to throw Transient Errors*/)
            //{
            //    throwTransientErrors = true;
               
            //}

            //if (throwTransientErrors && _counter < 4)
            //{
            //    _logger.Information($"Counter is {_counter}");
            //    _logger.Information("Returning transient error for command: {0}", command.CommandText);
            //    _counter++;
            //    interceptionContext.Exception = CreateDummySqlException();
            //}
        }
        //private SqlException CreateDummySqlException()
        //{
        //    // The instance of SQL Server you attempted to connect to does not support encryption
        //    var sqlErrorNumber = 20;
        //    var sqlErrorConstructor = typeof(SqlError).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic)
        //        .Where(cInfo => cInfo.GetParameters().Count() == 7).Single();
        //    // cInfo is Constructor info

        //    //Instantiates the sqlError Object
        //    var sqlError = sqlErrorConstructor.Invoke(new object[] { sqlErrorNumber, (byte)0, (byte)0, "", "", "", 1 });

        //    // Activator helps create the SqlErrorCollection
        //    var errorCollection = Activator.CreateInstance(typeof(SqlErrorCollection), true);


        //    var addMethod = typeof(SqlErrorCollection).GetMethod("Add", BindingFlags.Instance | BindingFlags.NonPublic);

        //    addMethod.Invoke(errorCollection, new[] { sqlError });

        //    var sqlExceptionCtor = typeof(SqlException).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic)
        //        .Where(c => c.GetParameters().Count() == 4).Single();

        //    var sqlException = (SqlException)sqlExceptionCtor.Invoke(new object[] { "Dummy", errorCollection, null, Guid.NewGuid() });

        //    return sqlException;
        //}
    }
}