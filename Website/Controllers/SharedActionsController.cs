namespace Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Olive.Mvc;

    public class SharedActionsController : BaseController
    {
        [Route("error")]
        public ActionResult Error() => View("error");

        [Route("error/404")]
        public ActionResult NotFound404() => View("error-404");


        [Route("file")]
        public async Task<ActionResult> DownloadFile()
        {
            var path = Request.QueryString.ToString().TrimStart('?');
            var accessor = await FileAccessor.Create(path, User);
            if (!accessor.IsAllowed()) return new UnauthorizedResult();

            if (accessor.Blob.IsMedia())
                return await RangeFileContentResult.From(accessor.Blob);
            else return await File(accessor.Blob);
        }


    }
}