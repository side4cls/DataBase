using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table5Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [Отель] " +
                    $"([Код отеля], [Адрес отеля], [Название отеля]) " +
                    $"VALUES ({args[0]}, '{args[1]}', '{args[2]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Отель]
                    SET [Адрес отеля] = '{args[1]}', [Название отеля] = '{args[2]}'
                    WHERE [Код отеля] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Отель] " +
                    $"WHERE [Код отеля] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
