using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace GrammarBotClient
{
    public class GrammarBot
    {
        private ApiConfig ApiConfig;
        public GrammarBot(ApiConfig apiConfig)
        {
            ApiConfig = apiConfig;
        }

        public async Task<Result> CheckAsync(string words)
        {
            var result = new Result();
            if (!Validation(words, result))
            {
                return result;
            }

            words = System.Net.WebUtility.UrlEncode(words);
            string url = $"{ApiConfig.BaseURI}/{ApiConfig.Version}/{ApiConfig.ApiName}?api_key={ApiConfig.ApiKey}&text={words}&language={ApiConfig.Language}";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                result.CheckContent = JsonConvert.DeserializeObject<CheckContent>(response);
                result.Success = true;
                result.Message = "Check Successfully";
            }
            return result;
        }

        private bool Validation(string words, Result result)
        {
            if (words.Length > 50000)
            {
                result.Success = false;
                result.Message = "Text longer than 50,000 characters are not allowed.";
                return false;
            }
            if (string.IsNullOrEmpty(words))
            {
                result.Success = false;
                result.Message = "Empty text to check";
                return false;
            }
            return true;
        }
    }
}
