﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Laboratorio_ASP.NET.Startup))]
namespace Laboratorio_ASP.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
