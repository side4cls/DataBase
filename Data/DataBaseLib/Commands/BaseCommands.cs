using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class BaseCommands
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public DataTable GetDataTable(string tableName)
        {
            string query = $"SELECT * FROM [{tableName}]";
            return controller.GetDataTable(query);
        }
    }
}
