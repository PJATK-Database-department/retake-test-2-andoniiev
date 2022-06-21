using ApbdTest2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApbdTest2.Services
{
    public interface IDatabaseService
    {
        public Task<List<Action>> GetActionsForFireTruckAsync { get; set; }
        public Task<bool> DoesFireTruckExistAsync(int id);
        public Task<bool> DoesActionHaveEndDateAsync(int id);
        public Task<bool> IsActionDateCorrectAsync(int id);

        public Task UpdateTheEndDateAsync(int id);
    }
}
