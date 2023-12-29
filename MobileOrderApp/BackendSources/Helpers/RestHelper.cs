using MobileOrderApp.BackendSources.Models;

namespace MobileOrderApp.BackendSources.Helpers
{
    public class RestHelper
    {
        public static async Task<object> LoginMethod(Login login)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, "https://app.elifsoft.com.tr/api/AccountApi/Login");
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(login.username), "username");
                content.Add(new StringContent(login.password), "password");
                request.Content = content;
                var response = client.SendAsync(request);
                return await response.Result.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
