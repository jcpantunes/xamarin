using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Teste.App.Data
{
    public interface IDataServiceBase<T> where T : ModelBase
    {

        Task<List<T>> GetItemsAsync();

        Task<List<T>> GetItemsNotDoneAsync();

        Task<T> GetItemAsync(int id);

        Task<int> SaveItemAsync(T item);

    }
}
