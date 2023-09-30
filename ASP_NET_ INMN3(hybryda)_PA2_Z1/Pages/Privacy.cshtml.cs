using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET__INMN3_hybryda__PA2_Z1.Pages;
public class PrivacyModel : PageModel
{
	private readonly ILogger<PrivacyModel> _logger;

	public PrivacyModel(ILogger<PrivacyModel> logger)
	{
		_logger = logger;
	}

	public void OnGet()
	{
	}
}

