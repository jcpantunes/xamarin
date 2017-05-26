using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Teste.App.Data
{
    public class TodoItemManager
    {
        IRestService<TodoItem> restService;

        public TodoItemManager(IRestService<TodoItem> service)
        {
            restService = service;
        }

        public Task<List<TodoItem>> GetTasksAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveTaskAsync(TodoItem item, bool isNewItem = false)
        {
            return restService.SaveTodoItemAsync(item, isNewItem);
        }

        public Task DeleteTaskAsync(TodoItem item)
        {
            return restService.DeleteTodoItemAsync(item.ID.ToString());
        }
    }
}