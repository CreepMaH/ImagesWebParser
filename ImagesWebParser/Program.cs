using ImagesWebParser;

const string URL_PART = "https://www.carmanualsonline.info/img/37/22332/w960_22332-";
const string OUTPUT_DIRECTORY_WEBP = "Downloaded Images";
const int LAST_PAGE = 406;

for (int i = 1; i <= LAST_PAGE; i++)
{
    string url = $"{URL_PART}{i}.png";
    await ImageParser.DownloadImageByURL(url, OUTPUT_DIRECTORY_WEBP);
    Console.WriteLine(LAST_PAGE - i);
    await Task.Delay(5);
}
