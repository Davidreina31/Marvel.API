using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Marvel.DAL.Data;
using Marvel.DAL.Interfaces.Repositories;
using Marvel.Entities;
using Microsoft.EntityFrameworkCore;

namespace Marvel.DAL.Repositories
{
    public class HeroRepository : IHeroRepository
    {
        private readonly ApplicationDataContext _db;

        public HeroRepository(ApplicationDataContext db)
        {
            _db = db;
        }

        public async Task<Hero> Add(Hero ItemToAdd)
        {
            _db.Add(ItemToAdd);
            await _db.SaveChangesAsync();

            return ItemToAdd;
        }

        public async Task<Hero> Delete(Guid id)
        {
            var result = await _db.Heroes.FirstOrDefaultAsync(item => item.Id == id);
            _db.Heroes.Remove(result);
            await _db.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<Hero>> GetAll()
        {
            return await _db.Heroes.ToListAsync();
        }

        public async Task<Hero> GetById(Guid id)
        {
            var result = await _db.Heroes.FirstOrDefaultAsync(item => item.Id == id);
            return result;
        }

        public async Task<Hero> Update(Hero ItemToUpdate)
        {
            var result = await _db.Heroes.FirstOrDefaultAsync(item => item.Id == ItemToUpdate.Id);
            _db.Heroes.Update(ItemToUpdate);
            await _db.SaveChangesAsync();

            return ItemToUpdate;
        }
    }
}
