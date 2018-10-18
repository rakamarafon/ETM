using ETM.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETM.BusinessLogicLayer.Interfaces
{
    public interface IStockExchange
    {
        Task<UserInfo> GetUserInfoAsync();
        UserInfo GetUserInfo();
    }
}
