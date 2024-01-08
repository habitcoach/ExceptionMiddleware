using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication9.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            try
            {

                int a = 10 / (10-10);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

        }
    }
}