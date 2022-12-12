using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
//using System.Text.Json;

namespace FurnitureStore.Infrastracture
{
    public static class SessionExtension
    {
        //public static void SetJson(this ISession session, string key, object value)
        //{
        //    session.SetString(key, JsonSerializer.Serialize(value));
        //}
        //public static T GetJson<T>(this ISession session, string key)
        //{
        //    var sessionData = session.GetString(key);
        //    return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        //}

        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default(T) : JsonConvert.DeserializeObject<T>(sessionData);
        }
    }
}
