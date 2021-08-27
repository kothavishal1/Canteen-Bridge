using Brings_Canteen.DAL;
using Brings_Canteen.Models;
using Microsoft.Owin;
using Owin;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

[assembly: OwinStartupAttribute(typeof(Brings_Canteen.Startup))]
namespace Brings_Canteen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
