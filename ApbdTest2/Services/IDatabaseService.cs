using ApbdTest2.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApbdTest2.Dto;

namespace ApbdTest2.Services
{
    public interface IDatabaseService
    {
        //public Task<ICollection<ActionDto>> GetActionsForFireTruckAsync(int id);
        public Task<bool> DoesFireTruckExistAsync(int id);
        public Task<bool> DoesActionHaveEndDateAsync(int id);
        public Task<bool> IsActionDateCorrectAsync(int idAction, DateTime newDate);
        public Task<FireTruckDto> GetFireTruckAsync(int id);
        public Task UpdateTheEndDateAsync(int idAction, DateTime newDate, ActionDto actionDto);
    }
}
