using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL;
using BLL;
using Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTablesController : ControllerBase
    {
        private readonly MyTableBLL _BLL;

        public MyTablesController()
        {
            _BLL = new MyTableBLL();
        }

        // GET: api/MyTables
        [HttpGet]
        public async Task<IEnumerable<MyTable>> GetMyTables()
        {
            return await _BLL.GetMyTables();
        }

        // GET: api/MyTables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MyTable>> GetMyTable(int id)
        {
            return await _BLL.GetMyTable(id);
        }

        // PUT: api/MyTables/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMyTable(int id, MyTable myTable)
        {
            var i = await _BLL.PutMyTable(id, myTable);

            return Ok(new { i });
        }

        // POST: api/MyTables
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MyTable>> PostMyTable(MyTable myTable)
        {
            var r = await _BLL.PostMyTable(myTable);

            return Ok(new { r });
        }

        // DELETE: api/MyTables/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMyTable(int id)
        {
            var r = await _BLL.DeleteMyTable(id);
            return Ok(new { r });
        }

    }
}
