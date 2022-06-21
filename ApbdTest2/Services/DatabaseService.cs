using System.Threading.Tasks;
using ApbdTest2.Models;
using ApbdTest2.Dto;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ApbdTest2.Services
{
    public class DatabaseService : IDatabaseService
    {

        private readonly s23005Context _dbContext;

        public DatabaseService(s23005Context dbContext) { 
            _dbContext = dbContext; 
        }
       /* public async  Task<ICollection<ActionDto>> GetActionsForFireTruckAsync(int id)
        {
            FireTruck firetruck = await _dbContext.FireTrucks.FirstAsync(x => x.IdFireTruck == id);

            return await _dbContext.FireTruckActions.Sele
                .
        }*/

        public async Task<FireTruckDto> GetFireTruckAsync(int id)
        {

            return (FireTruckDto)_dbContext.FireTrucks.Select(x => new FireTruckDto
            {
                IdFireTruck = x.IdFireTruck,
                OperationalNumber = x.OperationalNumber,
                SpecialEquipment = x.SpecialEquipment
            });
        }
        public async Task UpdateTheEndDateAsync(int idAction,DateTime newDate, ActionDto actionDto)
        {
            var action = await _dbContext.Actions.FirstAsync(x => x.IdAction == idAction);
            action.EndTime = newDate;
             _dbContext.Actions.Update(action);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<bool> DoesActionHaveEndDateAsync(int id)
        {
            Models.Action action = await _dbContext.Actions.FirstAsync(x => x.IdAction == id);
            if (action.EndTime == null)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DoesFireTruckExistAsync(int id)
        {
            return await _dbContext.FireTrucks.AnyAsync(x => x.IdFireTruck == id);
        }

        public async Task<bool> IsActionDateCorrectAsync(int idAction,DateTime newDate)
        {
            Models.Action action = await _dbContext.Actions.FirstAsync(x => x.IdAction == idAction);
            return action.EndTime >= newDate;
        }

       
    }
}
