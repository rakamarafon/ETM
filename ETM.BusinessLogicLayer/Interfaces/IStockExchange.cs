using ETM.Shared.DTO;
using System.Threading.Tasks;

namespace ETM.BusinessLogicLayer.Interfaces
{
    public interface IStockExchange
    {
        Task<UserInfo> GetUserInfoAsync();
        UserInfo GetUserInfo();
    }
}
