using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Marvel.BLL.Interfaces.Managers;
using Marvel.DAL.Interfaces.Repositories;
using Marvel.Entities;

namespace Marvel.BLL.Managers
{
    public class TeamManager : ITeamManager
    {
        private readonly ITeamRepository _currentRepository;

        public TeamManager(ITeamRepository teamRepository)
        {
            _currentRepository = teamRepository;
        }

        public async Task<Team> Add(Team ItemToAdd)
        {
            return await _currentRepository.Add(ItemToAdd);
        }

        public async Task<Team> Delete(Guid id)
        {
            return await _currentRepository.Delete(id);
        }

        public async Task<IEnumerable<Team>> GetAll()
        {
            return await _currentRepository.GetAll();
        }

        public async Task<Team> GetById(Guid id)
        {
            return await _currentRepository.GetById(id);
        }

        public async Task<Team> Update(Team ItemToUpdate)
        {
            return await _currentRepository.Update(ItemToUpdate);
        }
    }
}
