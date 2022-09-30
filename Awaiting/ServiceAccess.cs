namespace Awaiting
{
    public class ServiceAccess : IServiceAccess
    {
        private string? _cache;

        public async Task<string> GetDataAsync()
        {
            if (_cache == null)
            {
                var client = new HttpClient();

                var response = await client.GetAsync(new Uri("https://jasperkentxxxx.com"));

                _cache = await response.Content.ReadAsStringAsync();
            }

            return _cache;
        }

        public async Task NoReturn()
        {
            var client = new HttpClient();

            await client.GetAsync(new Uri("https://jasperkentxxxx.com"));
        }
    }
}
