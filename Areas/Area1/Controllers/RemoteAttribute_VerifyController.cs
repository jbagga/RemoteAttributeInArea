using Microsoft.AspNetCore.Mvc;

namespace RemoteAttributeInArea
{
    [Area("Area1")]
    [Route("FormArea")]
    public class RemoteAttribute_VerifyController : Controller
    {
        [AcceptVerbs("Get", "Post")]
        public IActionResult IsEmailAvailable(string userEmail)
        {
            return Json(data: false);
        }
    }
}