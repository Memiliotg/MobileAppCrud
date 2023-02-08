using PruebaOrionTek.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOrionTek.Helpers
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Cliente>().Wait();
            db.CreateTableAsync<Empresa>().Wait();
        }

        public Task<List<Cliente>> GetClientesAsync()
        {
            return db.Table<Cliente>().ToListAsync();
        }

        public Task<List<Empresa>> GetEmpresaAsync()
        {
            return db.Table<Empresa>().ToListAsync();
        }


    }
}
