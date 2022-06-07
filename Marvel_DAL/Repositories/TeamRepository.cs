using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Marvel.DAL.Data;
using Marvel.DAL.Interfaces.Repositories;
using Marvel.Entities;
using Microsoft.EntityFrameworkCore;

namespace Marvel.DAL.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDataContext _db;

        public TeamRepository(ApplicationDataContext db)
        {
            _db = db;
        }

        public async Task<Team> Add(Team ItemToAdd)
        {
            _db.Add(ItemToAdd);
            await _db.SaveChangesAsync();

            return ItemToAdd;
        }

        public async Task<Team> Delete(Guid id)
        {
            var result = await _db.Teams.FirstOrDefaultAsync(item => item.Id == id);
            _db.Teams.Remove(result);
            await _db.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<Team>> GetAll()
        {
            return await _db.Teams.ToListAsync();
        }

        public async Task<Team> GetById(Guid id)
        {
            var result = await _db.Teams.FirstOrDefaultAsync(item => item.Id == id);
            return result;
        }

        public async Task<Team> Update(Team ItemToUpdate)
        {
            var result = await _db.Teams.FirstOrDefaultAsync(item => item.Id == ItemToUpdate.Id);
            _db.Teams.Update(ItemToUpdate);
            await _db.SaveChangesAsync();

            return ItemToUpdate;
        }
    }
}
