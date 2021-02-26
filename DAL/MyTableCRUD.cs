using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyTableCRUD
    {
        private readonly WebApplication2Context _context;

        public MyTableCRUD()
        {
            _context = new WebApplication2Context();
        }

        public async Task<IEnumerable<MyTable>> GetMyTables()
        {
            return await _context.MyTables.ToListAsync();
        }

        public async Task<MyTable> GetMyTable(int id)
        {
            var myTable = await _context.MyTables.FindAsync(id);

            return myTable;
        }

        public async Task<int> PutMyTable(int id, MyTable myTable)
        {
            if (id != myTable.id)
            {
                return -1; // Bad Request
            }

            _context.Entry(myTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyTableExists(id))
                {
                    return -2; // Not Found
                }
                else
                {
                    throw;
                }
            }

            return 0;
        }
        public async Task<int> PostMyTable(MyTable myTable)
        {
            _context.MyTables.Add(myTable);
            await _context.SaveChangesAsync();

            return myTable.id;
        }

        public async Task<int> DeleteMyTable(int id)
        {
            var myTable = await _context.MyTables.FindAsync(id);
            if (myTable == null)
            {
                return -2;
            }

            _context.MyTables.Remove(myTable);
            await _context.SaveChangesAsync();

            return 0;
        }

        private bool MyTableExists(int id)
        {
            return _context.MyTables.Any(e => e.id == id);
        }
    }
}
