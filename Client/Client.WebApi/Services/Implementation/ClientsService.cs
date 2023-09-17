using Client.WebApi.Models;
using Client.WebApi.Services.Contract;
using Microsoft.EntityFrameworkCore;

namespace Client.WebApi.Services.Implementation
{
    public class ClientsService : IClientService
    {
        private DbcustomerContext _dbContex;

        public ClientsService(DbcustomerContext dbContex)
        {
            _dbContex = dbContex;
        }

        public async Task<List<Clients>> GetList()
        {
            try
            {
                List<Clients> list = new List<Clients>();
                list = await _dbContex.Clients.ToListAsync();

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Clients> Get(int idClient)
        {
            try
            {

                return await _dbContex.Clients.FirstOrDefaultAsync(x => x.IdClient == idClient);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
