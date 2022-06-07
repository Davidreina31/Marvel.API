using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Marvel.DAL.Data;
using Marvel.DAL.Interfaces.Repositories;
using Marvel.Entities;
using Microsoft.EntityFrameworkCore;

namespace Marvel.DAL.Repositories
{
    public class UserHeroRepository : IUserHeroRepository
    {
        private readonly ApplicationDataContext _db;

        public UserHeroRepository(ApplicationDataContext db)
        {
            _db = db;
        }

        public async Task<User_Hero> Add(User_Hero ItemToAdd)
        {
            _db.Add(ItemToAdd);
            await _db.SaveChangesAsync();

            return ItemToAdd;
        }

        public async Task<User_Hero> Delete(Guid id)
        {
            var result = await _db.UsersHeroes.FirstOrDefaultAsync(item => item.Id == id);
            _db.UsersHeroes.Remove(result);
            await _db.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<User_Hero>> GetAll()
        {
            return await _db.UsersHeroes.ToListAsync();
        }

        public async Task<User_Hero> GetById(Guid id)
        {
            var result = await _db.UsersHeroes.FirstOrDefaultAsync(item => item.Id == id);
            return result;
        }

        public async Task<User_Hero> Update(User_Hero ItemToUpdate)
        {
            var result = await _db.UsersHeroes.FirstOrDefaultAsync(item => item.Id == ItemToUpdate.Id);
            _db.UsersHeroes.Update(ItemToUpdate);
            await _db.SaveChangesAsync();

            return ItemToUpdate;
        }
    }
}
