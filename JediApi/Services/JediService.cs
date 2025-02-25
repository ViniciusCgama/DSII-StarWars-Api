﻿using JediApi.Models;
using JediApi.Repositories;

namespace JediApi.Services
{
    public class JediService(IJediRepository jediRepository)
    {
        private readonly IJediRepository _jediRepository = jediRepository;

        public Task<jedi> GetByIdAsync(int id)
        {
            return _jediRepository.GetByIdAsync(id);
        }

        public Task<List<jedi>> GetAllAsync()
        {
            return _jediRepository.GetAllAsync();
        }

        public Task<jedi> AddAsync(jedi jedi)
        {
            return _jediRepository.AddAsync(jedi);
        }

        public Task<bool> UpdateAsync(jedi jedi)
        {
            return _jediRepository.UpdateAsync(jedi);
        }

        public Task<bool> DeleteAsync(int id)
        {
            return _jediRepository.DeleteAsync(id);
        }
    }
}
