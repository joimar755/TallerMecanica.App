using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


//using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{

    public class Ajax : RepositorioPersona
    {
        private readonly AppContext appContext;

        public Ajax(AppContext appContext) : base(appContext)
        {
            this.appContext = appContext;
        }
        
       
    }
    
}