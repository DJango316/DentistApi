using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.DbFactory
{
    public interface IDbFactory
    {
        IDatabase GetConnection();
    }
}
