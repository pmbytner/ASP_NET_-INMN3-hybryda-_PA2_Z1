using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET__INMN3_hybryda__PA2_Z1.Pages;
public class IndexModel : PageModel
{
	private readonly ILogger<IndexModel> _logger;

	public IndexModel(ILogger<IndexModel> logger)
	{
		_logger = logger;
	}

	public void OnGet()
	{

	}
}
