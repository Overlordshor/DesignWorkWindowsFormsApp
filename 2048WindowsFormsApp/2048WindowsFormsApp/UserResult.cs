using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace _2048WindowsFormsApp
{
    public partial class UserResult
    {
        public string Name;
        public int Result;
        private static string PathToResult = "result.json";


        public UserResult(string name, int result)
        {
            Name = name;
            Result = result;
        }

        public void AddUserResult(string userName, int userResult)
        {
            var usersResult = CreateUsersList();
            var lastResult = usersResult.Last();
            if (lastResult.Name != userName || lastResult.Result != userResult)
            {
                usersResult.Add(new UserResult(userName, userResult));
                var serializedResults = JsonConvert.SerializeObject(usersResult, Formatting.Indented);
                FileProvider.Save(PathToResult, serializedResults);
            }
        }
        public int GetBestResult()
        {
            var resultList = GetSortedListUsers();
            if (resultList.Count == 0)
            {
                return 0;
            }
            else
            {
                var bestResult = resultList[0].Result;
                return bestResult;
            }
        }
        public List<UserResult> GetSortedListUsers()
        {
            var usersList = CreateUsersList();
            var sortedUsers = from user in usersList
                              orderby user.Result descending
                              select user;
            List<UserResult> usersSortedResult = sortedUsers.ToList();
            return usersSortedResult;
            
        }

        private List<UserResult> CreateUsersList()
        {
            var isExist = FileProvider.TryGet(PathToResult, out var resultData);
            List<UserResult> usersList;
            if (!isExist)
            {
                usersList = new List<UserResult>();
            }
            else
            {
                usersList = Get();
            }
            return usersList;
        }    
        private List<UserResult> Get()
        {
            var data = FileProvider.Load(PathToResult);
            return JsonConvert.DeserializeObject<List<UserResult>>(data);
        }
    }
}
