using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Repositories
{
    public interface IRepository
    {
        bool SaveChanges();
    }
}
