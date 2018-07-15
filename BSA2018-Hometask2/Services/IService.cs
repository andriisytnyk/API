using BSA2018_Hometask2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSA2018_Hometask2.Services
{
    public interface IService
    {
        List<User> GetHierarhy();
    }
}
