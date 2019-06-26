using NetCrawlerDetect;

namespace NetCrawlerDetectConflict
{
    public class BotDetector
    {
        public string Check(string userAgent)
        {
            var detector = new CrawlerDetect();
            var isBot = detector.IsCrawler(userAgent);

            if (isBot)
            {
                return detector.Matches[0].Value;
            }

            return null;
        }

    }
}
