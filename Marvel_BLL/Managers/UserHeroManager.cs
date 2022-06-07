using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Marvel.BLL.Interfaces.Managers;
using Marvel.DAL.Interfaces.Repositories;
using Marvel.Entities;

namespace Marvel.BLL.Managers
{
    public class UserHeroManager : IUserHeroManager
    {
        private readonly IUserHeroRepository _currentRepository;

        public UserHeroManager(IUserHeroRepository userHeroRepository)
        {
            _currentRepository = userHeroRepository;
        }

        public async Task<User_Hero> Add(User_Hero ItemToAdd)
        {
            return await _currentRepository.Add(ItemToAdd);
        }

        public async Task<User_Hero> Delete(Guid id)
        {
            return await _currentRepository.Delete(id);
        }

        public async Task<IEnumerable<User_Hero>> GetAll()
        {
            return await _currentRepository.GetAll();
        }

        public async Task<User_Hero> GetById(Guid id)
        {
            return await _currentRepository.GetById(id);
        }

        public async Task<User_Hero> Update(User_Hero ItemToUpdate)
        {
            return await _currentRepository.Update(ItemToUpdate);
        }
    }
}
