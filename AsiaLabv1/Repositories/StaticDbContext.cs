using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsiaLabv1.Repositories
{
    public class StaticDbContext
    {
        protected static AsiaLabDb3Entities Context = new AsiaLabDb3Entities();
        public static AsiaLabDb3Entities context
        {
            get
            {
                return Context;
            }
        }
    }
}