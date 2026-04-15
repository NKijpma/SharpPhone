using System.Text.Json;

namespace SharpPhone
{
    public class SharpPhoneFileStorage(string path)
    {
        private readonly string _path = path;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

        public SharpPhoneDatabase Load()
        {
            if (!File.Exists(_path)) return new();
            try
            {
                var json = File.ReadAllText(_path);
                if (string.IsNullOrWhiteSpace(json)) return new();
                return JsonSerializer.Deserialize<SharpPhoneDatabase>(json, _opts) ?? new();
            }
            catch { return new(); }
        }

        public void Save(SharpPhoneDatabase data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_path, json);
        }
    }
}