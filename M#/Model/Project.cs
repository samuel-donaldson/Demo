using MSharp;

namespace App
{
    public class Project : MSharp.Project
    {
        public Project()
        {
            Name("CET.Demo").SolutionFile("CET.Demo.sln");

            Role("Local.Request");
            Role("Anonymous");
            Role("Admin").SkipQueryStringSecurity();

            Layout("Admin default").AjaxRedirect().Default().VirtualPath("~/Views/Layouts/AdminDefault.cshtml");
            Layout("Admin default Modal").Modal().VirtualPath("~/Views/Layouts/AdminDefault.Modal.cshtml");
            Layout("Login").AjaxRedirect().VirtualPath("~/Views/Layouts/Login.cshtml");
            Layout("Blank").AjaxRedirect().VirtualPath("~/Views/Layouts/Blank.cshtml");

            PageSetting("LeftMenu");
            PageSetting("SubMenu");
            PageSetting("TopMenu");

        }
    }
}