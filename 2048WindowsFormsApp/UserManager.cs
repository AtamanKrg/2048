using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048WindowsFormsApp
{
    public class UserManager
    {
        public string Path = "results.json";
        public List<User> GetAll()
        {
            var jsonData = FileProvider.GetValue(Path);
            return JsonConvert.DeserializeObject<List<User>>(jsonData);
        }

        public void Add(User newUser)
        {
            var users = GetAll();
            users.Add(newUser);

            var jsonData = JsonConvert.SerializeObject(users);
            FileProvider.Replace(Path, jsonData);
        }
    }
}
