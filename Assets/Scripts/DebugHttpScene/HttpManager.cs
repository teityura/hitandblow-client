using System.Net.Http;
using System;

public static class HttpManager
{
    public const string SERVER_URL = "http://34.145.109.41:5000";
    public static Action<string> onComplete;

    public static async void SendRequest(string path)
    {
        HttpClient client = new HttpClient();
        var responce = await client.GetStringAsync($"{SERVER_URL}/{path}");
        onComplete?.Invoke(responce);
    }

    public static void OnComplete(Action<string> callback)
    {
        onComplete = callback;
    }
}
