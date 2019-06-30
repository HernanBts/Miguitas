
namespace Miguitas.Web.Notifications
{
    using Newtonsoft.Json;
    using System.Net.Http;
    using System.Threading.Tasks;

    public static class PushNotificationLogic
    {
        //public static async Task<bool> SendPushNotificationAsync(string[] deviceTokens, string title, string body, object data)
        //{
        //    var messageInformation = new Message()
        //    {
        //        notification = new Notification()
        //        {
        //            title = title,
        //            text = body
        //        },
        //        data = data,
        //        registration_ids = deviceTokens
        //    };
        //    //Object to JSON STRUCTURE => using Newtonsoft.Json;
        //    string jsonMessage = JsonConvert.SerializeObject(messageInformation);

        //    // Create request to Firebase API
        //    string ServerKey = "AAAAgTaafSE:APA91bF4k8Up9DHLb4KHk8_CIYbE0ktWwx-G2t_-59BBtexP7tC6EpOQbZRO9wHJdOx8yzS0cS3p-v-Bl-h0gVZiOZp0zan5mJdVuK9839hdqYTMWi2s1sY1pzBuZmT7Cw8FWmpngXrP";
        //    var request = new HttpRequestMessage(HttpMethod.Post, "https://fcm.googleapis.com/fcm/send");
        //    request.Headers.TryAddWithoutValidation(“Authorization”, “key =” + ServerKey);
        //    request.Content = new StringContent(jsonMessage, Encoding.UTF8, “application / json”);
        //    HttpResponseMessage result;
        //    using (var client = new HttpClient())
        //    {
        //        result = await client.SendAsync(request);
        //    }
        //}
    }
}
