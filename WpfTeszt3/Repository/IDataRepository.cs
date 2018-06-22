using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WpfTeszt3.Models;

namespace WpfTeszt3.Repository
{
    public interface IDataRepository
    {
        IEnumerable<DataModel> GetData();
    }
}
