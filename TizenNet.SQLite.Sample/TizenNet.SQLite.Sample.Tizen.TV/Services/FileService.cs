using System.IO;
using Tizen.Applications;
using TizenNet.SQLite.Sample.Interfaces;

namespace TizenNet.SQLite.Sample.Tizen.TV.Services
{
    public class FileService : IFileService
    {
        public string AppPath
            => Application.Current.DirectoryInfo.Data;

        public string PathCombine(string fileName)
            => Path.Combine(AppPath, fileName);
    }
}
