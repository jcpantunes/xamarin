using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace Xamarin.Teste.App.Infra
{
    public interface IDataAzure<TEntity>
    {
        Task<ObservableCollection<TEntity>> Get();

        Task<TEntity> Insert(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<TEntity> Delete(TEntity entity);
    }
}
