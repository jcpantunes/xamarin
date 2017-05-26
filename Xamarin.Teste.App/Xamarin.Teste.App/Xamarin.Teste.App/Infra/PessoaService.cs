using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Linq;

namespace Xamarin.Teste.App.Infra
{
    public class PessoaService : DataAzure<Pessoa>
    {
        public async Task<ObservableCollection<Pessoa>> GetOrdered()
        {
            IEnumerable<Pessoa> lista = await _table.ToEnumerableAsync();

            return new ObservableCollection<Pessoa>(lista.OrderBy(p => p.Nome));
        }
    }
}
