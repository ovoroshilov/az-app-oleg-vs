using Microsoft.AspNetCore.Mvc.RazorPages;

namespace az_app_oleg_vs.Pages
{
    public class PrivacyModel(ILogger<PrivacyModel> logger) : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger = logger;

        public void OnGet()
        {
            throw new NotImplementedException();
        }
    }

}
