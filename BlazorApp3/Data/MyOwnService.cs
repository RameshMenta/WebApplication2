using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Data
{
    public class MyOwnService
    {
        public async Task<string> GetMyOwnName()
        {
            //  Line 1
            //   Line 2
            //   Line 3

            await Task.CompletedTask;
            return "My Name Is Ramesh";
        }
    }
}
