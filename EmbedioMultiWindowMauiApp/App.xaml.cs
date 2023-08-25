using System.Reflection;
using EmbedIO;
using EmbedIO.WebApi;

namespace EmbedioMultiWindowMauiApp
{
    public partial class App : Application
    {
        private static int _port = 8080;
        private static string _ip = "http://*:";

        public App()
        {
            InitializeComponent();
            Url = _ip + _port;
            Task.Factory.StartNew(async () =>
            {
                
                using (var server = new WebServer(HttpListenerMode.EmbedIO, Url))
                {
                    Assembly assembly = typeof(App).Assembly;
                    server.WithLocalSessionManager();
                    server.WithWebApi("/api", m => m.WithController(() => new TestController()));
                    server.WithEmbeddedResources("/", assembly, "EmbedIO.Forms.Sample.html");
                    await server.RunAsync();
                }
            });

            MainPage = new AppShell();
        }

        public static string Url { get; private set; }
    }
}