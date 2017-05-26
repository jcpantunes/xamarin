using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Xamarin.Teste.App.Infra
{
    public class AzureServiceBase<TEntity>
    {
        protected IMobileServiceClient _client;
        protected IMobileServiceTable<TEntity> _table;
        protected const string serviceUrl = "http://serpro-aula01.azurewebsites.net";

        public AzureServiceBase()
        {
            _client = new MobileServiceClient(serviceUrl);
            _table = _client.GetTable<TEntity>();
        }
    }
}
