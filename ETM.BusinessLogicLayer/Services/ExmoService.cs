using ETM.BusinessLogicLayer.Interfaces;
using ETM.Shared.DTO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETM.BusinessLogicLayer.Services
{
    public class ExmoService : BaseStockService, IStockExchange
    {
        public UserInfo GetUserInfo()
        {            
            string result = ApiQuery("user_info", new Dictionary<string, string>());
            UserInfo info = JsonConvert.DeserializeObject<UserInfo>(result);
            return info;
        }

        public async Task<UserInfo> GetUserInfoAsync()
        {
            string result = await ApiQueryAsync("user_info", new Dictionary<string, string>());
            UserInfo info = JsonConvert.DeserializeObject<UserInfo>(result);
            return info;
        }
    }
}
