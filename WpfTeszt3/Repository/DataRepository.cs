using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WpfTeszt3.Models;

namespace WpfTeszt3.Repository
{
    public class DataRepository : IDataRepository
    {
        public IEnumerable<DataModel> GetData()
        {
            return new List<DataModel>{
                new DataModel { numbers = 1, description = "q" },
                new DataModel { numbers = 2, description = "w" },
                new DataModel { numbers = 3, description = "e" },
                new DataModel { numbers = 4, description = "r" },
                new DataModel { numbers = 5, description = "f" },
                new DataModel { numbers = 6, description = "g" },
                new DataModel { numbers = 7, description = "c" },
                new DataModel { numbers = 8, description = "v" },
                new DataModel { numbers = 9, description = "x" },
             };
        }
    }
}
