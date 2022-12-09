using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table1Commands : ITableEditorCommand
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {            
            string query = $"INSERT INTO [Аренда] " +
                    $"([Код аренды], [Код номера], [Код клиента], [Код отеля]) " +
                    $"VALUES ({args[0]}, {args[1]}, {args[2]}, {args[3]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Аренда]
                    SET [Код номера] = {args[1]}, [Код клиента] = {args[2]}, [Код отеля] = {args[3]}
                    WHERE [Код аренды] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Аренда] " +
                    $"WHERE [Код аренды] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
