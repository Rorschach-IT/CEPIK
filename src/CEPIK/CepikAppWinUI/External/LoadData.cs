using System;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CepikAppWinUI.External
{
    public static class DbLoader
    {
        public static void LoadData<T>(ObservableCollection<T> collection, Func<DbContext> contextFactory) where T : class
        {
            try
            {
                using var db = contextFactory();
                var data = db.Set<T>().ToList();

                if (data.Count == 0)
                {
                    throw new Exception($"Brak danych: {typeof(T).Name}");
                }

                collection.Clear();
                foreach (var item in data)
                {
                    collection.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Błąd wczytywania danych typu {typeof(T).Name}: {ex.Message}");
            }
        }
    }
}
