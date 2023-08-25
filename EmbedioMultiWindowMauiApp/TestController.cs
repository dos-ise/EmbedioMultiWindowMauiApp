using EmbedIO;
using EmbedIO.Routing;
using EmbedIO.WebApi;

namespace EmbedioMultiWindowMauiApp
{
    public class TestController : WebApiController
    {
        public TestController() : base()
        { }

        [Route(HttpVerbs.Get, "/testresponse")]
        public int GetTestResponse()
        {
            return 12345;
        }
    }
}