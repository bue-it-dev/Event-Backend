using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Models.HrmModels;
namespace BUECarSystem.Implementations.Repositories
{
    public class BaseRepository
    {
        protected readonly HrmDBContext _context;

        public BaseRepository (HrmDBContext context)
        {
            _context = context;
        }
    }
}
