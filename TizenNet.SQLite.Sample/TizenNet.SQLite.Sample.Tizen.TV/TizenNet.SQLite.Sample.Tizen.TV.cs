using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;
using TizenNet.SQLite.Sample.Tizen.TV.Services;

namespace TizenNet.SQLite.Sample.Tizen.TV
{
    class Program : FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();

            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_sqlite3());

            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();

            Forms.Init(app);

            DependencyService.Register<FileService>();

            app.Run(args);
        }
    }
}
