using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Teste.App.Data
{
    public interface IRestService<T>
    {
        Task<List<T>> RefreshDataAsync();

        Task SaveTodoItemAsync(T item, bool isNewItem);

        Task DeleteTodoItemAsync(string id);
    }
}