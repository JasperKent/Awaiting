using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awaiting
{
    public class MockServiceAccess : IServiceAccess
    {
        public Task<string> GetDataAsync()
        {
            return Task.FromResult("Dummy data");
        }

        public Task NoReturn()
        {
            return Task.CompletedTask;
        }
    }
}
