using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Marvel.DAL.Data;
using Marvel.DAL.Interfaces.Repositories;
using Marvel.Entities;
using Microsoft.EntityFrameworkCore;

namespace Marvel.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDataContext _db;

        public UserRepository(ApplicationDataContext db)
        {
            _db = db;
        }

        public async Task<User> Add(User ItemToAdd)
        {
            _db.Add(ItemToAdd);
            await _db.SaveChangesAsync();

            return ItemToAdd;
        }

        public async Task<User> Delete(Guid id)
        {
            var result = await _db.Users.FirstOrDefaultAsync(item => item.Id == id);
            _db.Users.Remove(result);
            await _db.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task<User> GetById(Guid id)
        {
            var result = await _db.Users.FirstOrDefaultAsync(item => item.Id == id);
            return result;
        }

        public async Task<User> Update(User ItemToUpdate)
        {
            var result = await _db.Users.FirstOrDefaultAsync(item => item.Id == ItemToUpdate.Id);
            _db.Users.Update(ItemToUpdate);
            await _db.SaveChangesAsync();

            return ItemToUpdate;
        }
    }
}
