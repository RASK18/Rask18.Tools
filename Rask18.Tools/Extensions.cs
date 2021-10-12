using Newtonsoft.Json.Linq;
using System.Linq;

namespace Rask18.Tools
{
    public static class Extensions
    {
        public static JObject Sort(this JObject obj)
        {
            JObject result = new();

            foreach (JProperty prop in obj.Properties().OrderBy(p => p.Name))
            {
                if (prop.Value is JObject value)
                {
                    value = value.Sort();
                    result.Add(prop.Name, value);
                }
                else
                {
                    result.Add(prop.Name, prop.Value);
                }
            }

            return result;
        }
    }
}
