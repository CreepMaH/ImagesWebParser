using System.Net;

namespace ImagesWebParser
{
    public static class ImageParser
    {
        public static async Task DownloadImageByURL(string url, string outputDirectory)
        {
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            using (WebClient client = new WebClient())
            {
                string fileName = url.Split('/').LastOrDefault() ?? $"file_{DateTime.Now:d}_{DateTime.Now:mmss}";
                fileName = $"{outputDirectory}/{fileName}.webp";

                await client.DownloadFileTaskAsync(new Uri(url), fileName);
            }
        }
    }
}
