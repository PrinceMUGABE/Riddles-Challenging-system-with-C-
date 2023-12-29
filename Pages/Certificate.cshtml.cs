using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Riddles.Pages
{
    public class CertificateModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Grade { get; set; }

        public bool Passed { get; private set; }

        public void OnGet()
        {
            Passed = true;
   
            if(Grade>=5)
            {
                Passed = true;
            }
            else
            {
                Passed = false;
            }
        }

        
    }
}
