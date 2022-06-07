using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Marvel.BLL.Interfaces.Managers;
using Marvel.DAL.Interfaces.Repositories;
using Marvel.Entities;

namespace Marvel.BLL.Managers
{
    public class HeroManager : IHeroManager
    {
        private readonly IHeroRepository _currentRepository;

        public HeroManager(IHeroRepository heroRepository)
        {
            _currentRepository = heroRepository;
        }

        public async Task<Hero> Add(Hero ItemToAdd)
        {
            return await _currentRepository.Add(ItemToAdd);
        }

        public async Task<Hero> Delete(Guid id)
        {
            return await _currentRepository.Delete(id);
        }

        public async Task<IEnumerable<Hero>> GetAll()
        {
            return await _currentRepository.GetAll();
        }

        public async Task<Hero> GetById(Guid id)
        {
            return await _currentRepository.GetById(id);
        }

        public async Task<Hero> Update(Hero ItemToUpdate)
        {
            return await _currentRepository.Update(ItemToUpdate);
        }
    }
}
