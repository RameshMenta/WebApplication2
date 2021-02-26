using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MyTableBLL
    {
        private readonly MyTableCRUD _DAL;

        public MyTableBLL()
        {
            _DAL = new MyTableCRUD();
        }

        public async Task<IEnumerable<MyTable>> GetMyTables()
        {
            return await _DAL.GetMyTables();
        }

        public async Task<MyTable> GetMyTable(int id)
        {
            return await _DAL.GetMyTable(id);
        }

        public async Task<int> PutMyTable(int id, MyTable myTable)
        {
            var i = await _DAL.PutMyTable(id, myTable);
            if (i == -1)
            {

            } else if (i == -2)
            {
                
            } else
            {

            }

            return 0;
        }
        public async Task<int> PostMyTable(MyTable myTable)
        {
            return await _DAL.PostMyTable(myTable);
        }

        public async Task<int> DeleteMyTable(int id)
        {
            return await _DAL.DeleteMyTable(id);
        }

    }
}
