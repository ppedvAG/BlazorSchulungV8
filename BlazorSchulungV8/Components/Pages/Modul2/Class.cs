using Microsoft.AspNetCore.Authorization;

namespace BlazorSchulungV8.Components.Pages.Modul2
{
    [Authorize]
    public class Class
    {
        
        public int MyProperty { get; set; }
    }
}
