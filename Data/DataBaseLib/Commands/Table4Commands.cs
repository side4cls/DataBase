using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table4Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [Номера] " +
                    $"([Код номера], [Название], [Комплектация номера], [Номер], [Цена]) " +
                    $"VALUES ({args[0]}, '{args[1]}', '{args[2]}', '{args[3]}', {args[4]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Номера]
                    SET [Название] = '{args[1]}',[Комплектация номера] = '{args[2]}',[Номер] = '{args[3]}',[Цена] = '{args[4]}'
                    WHERE [Код номера] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Номера] " +
                    $"WHERE [Код номера] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
