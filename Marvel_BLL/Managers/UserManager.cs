using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Marvel.BLL.Interfaces.Managers;
using Marvel.DAL.Interfaces.Repositories;
using Marvel.Entities;

namespace Marvel.BLL.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _currentRepository;

        public UserManager(IUserRepository userRepository)
        {
            _currentRepository = userRepository;
        }

        public async Task<User> Add(User ItemToAdd)
        {
            return await _currentRepository.Add(ItemToAdd);
        }

        public async Task<User> Delete(Guid id)
        {
            return await _currentRepository.Delete(id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _currentRepository.GetAll();
        }

        public async Task<User> GetById(Guid id)
        {
            return await _currentRepository.GetById(id);
        }

        public async Task<User> Update(User ItemToUpdate)
        {
            return await _currentRepository.Update(ItemToUpdate);
        }
    }
}
