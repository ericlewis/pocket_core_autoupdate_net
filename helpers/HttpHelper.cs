namespace pannella.analoguepocket;

public static class HttpHelper
{
   private static readonly HttpClient _httpClient = new HttpClient();

   public static async Task DownloadFileAsync(string uri
        , string outputPath)
   {
      Uri uriResult;

      if (!Uri.TryCreate(uri, UriKind.Absolute, out uriResult))
         throw new InvalidOperationException("URI is invalid.");

      byte[] fileBytes = await _httpClient.GetByteArrayAsync(uri);
      File.WriteAllBytes(outputPath, fileBytes);
   }
}