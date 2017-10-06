using Microsoft.AspNetCore.Mvc;

namespace RemoteAttributeInArea
{
    [Area("Area1")]
    [Route("[area]/[controller]/[action]")]
    public class RemoteAttribute_VerifyController : Controller
    {
        [AcceptVerbs("Get", "Post")]
        public IActionResult IsEmailAvailable(string userId1, string userId3)
        {
            return Json(data: false);
        }
    }
}