using System.Text.Json;

namespace Adapter
{
    public class JsonParser<T> : IJsonParser<T>
    {
        public T Parse(string data)
        {
            // Ensure the deserialization result is not null
            var result = JsonSerializer.Deserialize<T>(data);
            if (result == null)
            {
                throw new InvalidOperationException("Deserialization resulted in a null object.");
            }
            return result;
        }

        public string ConvertToJson(T obj)
        {
            return JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
