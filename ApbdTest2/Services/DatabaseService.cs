using System.Threading.Tasks;
using ApbdTest2.Models;
using ApbdTest2.Dto;
using System.Collections.Generic;

namespace ApbdTest2.Services
{
    public class DatabaseService : IDatabaseService
    {
        public Task<List<Action>> GetActionsForFireTruckAsync { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Task<bool> DoesActionHaveEndDateAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DoesFireTruckExistAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsActionDateCorrectAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateTheEndDateAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
