using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab3_solution.Pages; // Change namespace to match your project

public class TimeModel : PageModel
{
    private readonly ILogger<TimeModel> _logger;
    public string Message {get; set;} = string.Empty;
    public List<int> LuckyNumbers {get; set;} = default!;

    public TimeModel(ILogger<TimeModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // OnGet() method is automatically called when someone visits your page
        // Variables are initialized to values and can be displayed in razor page
        _logger.LogCritical("Critical Error - Please reboot your MindSync device.");
        Message = "Your Message Here";
        LuckyNumbers = new List<int>{420, 13, 666};
    }
}