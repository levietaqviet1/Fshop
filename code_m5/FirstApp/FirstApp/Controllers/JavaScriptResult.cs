using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class JavaScriptResult : ContentResult
    {
        public JavaScriptResult(string script)
        {
            this.Content = script;
            this.ContentType = "text/javascript";
        }
    }

}