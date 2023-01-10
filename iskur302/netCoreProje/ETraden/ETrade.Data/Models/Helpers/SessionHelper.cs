using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ETrade.Data.Models.Helpers
{
    public static class SessionHelper
    {

        public static int Count { get; set; }
        public static void SetObjectAsJson(this ISession Session,string key, object value)
        {
            Session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObjectFromJson<T>(this ISession Session,string key)
        {
            var value= Session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

    }
}
