using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Services
{
    public class ServiceResponse<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public IList<string> Items { get; set; }
        public DateTime Time { get; set; }
        public T Data { get; set; }

        public ServiceResponse()
        {
            Items = null;
        }
    }
}
