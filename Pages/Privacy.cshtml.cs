using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace ASPWeb.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            String dateTime = DateTime.Now.ToString("d", new CultureInfo("ch-TW"));
            String Information = "中華民國總統府廳舍位於臺灣臺北市中正區，為中華民國總統、副總統及總統府的辦公場所，中華民國政府亦於每年元旦及國慶日在這裡舉行升旗典禮。1919年建成，建築風格屬辰野金吾風格，為中華民國國定古蹟。起初於臺灣日據時期做為「臺灣總督府」，是臺灣重要的政治中樞[1]。為國定古蹟，只有在特定時間才會開放給民眾入內參觀。";
            ViewData["TimeStamp"] = dateTime;
            ViewData["RegionInformation"] = Information;
        }
    }

}
