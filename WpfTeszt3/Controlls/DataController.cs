using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WpfTeszt3.Repository;

namespace WpfTeszt3.Controlls
{
    public class DataController : Controller
    {
        private IDataRepository _repository;
        public DataController(IDataRepository dataRepository)
        {
            if (dataRepository==null)
            {
                throw new ArgumentNullException(nameof(dataRepository));
            }
            else
            {
                _repository = dataRepository;
            }
        }
        public IActionResult Index()
        {
            return View(_repository.GetData());
        }
    }
}
