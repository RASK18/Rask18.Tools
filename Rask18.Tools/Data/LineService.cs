using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Rask18.Tools.Data
{
    public class LineService
    {
        public List<Line> GetLines(JObject jObject)
        {
            List<Line> result = new();

            foreach (JProperty prop in jObject.Properties())
            {
                if (prop.Value is JObject value)
                {

                }
                else if (prop.Value is JArray array)
                {

                }
                else
                {
                    result.Add(new Line
                    {
                        Level = 0,
                        Key = prop.Name,
                        Number = result.Count,
                        Value = prop.Value.ToString()
                    });
                }
            }

            return result;
        }
    }
}
