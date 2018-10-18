using ETM.BusinessLogicLayer.Interfaces;
using ETM.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETM.BusinessLogicLayer.Services
{
    public class ExmoService : BaseStockService, IStockExchange
    {
        public UserInfo GetUserInfo()
        {
          
        }

        public Task<UserInfo> GetUserInfoAsync()
        {
            throw new NotImplementedException();
        }
    }
}
