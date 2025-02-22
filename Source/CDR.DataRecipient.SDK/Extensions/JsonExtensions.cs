﻿using System.IO;
using Newtonsoft.Json;

namespace CDR.DataRecipient.SDK.Extensions
{
    public static class JsonExtensions
    {
        public static string ToPrettyJson(this string json)
        {
            dynamic parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);

            //using (var stringReader = new StringReader(json))
            //using (var stringWriter = new StringWriter())
            //{
            //    var jsonReader = new JsonTextReader(stringReader);
            //    var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
            //    jsonWriter.WriteToken(jsonReader);
            //    return stringWriter.ToString();
            //}
        }
    }
}
