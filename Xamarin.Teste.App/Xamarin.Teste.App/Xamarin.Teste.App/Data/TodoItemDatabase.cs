using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Teste.App.Model;

namespace Xamarin.Teste.App.Data
{
    public class TodoItemDatabase : DataServiceBase<TodoItem>, IDataServiceBase<TodoItem>
    {

        public TodoItemDatabase()
        {
        }

    }
}