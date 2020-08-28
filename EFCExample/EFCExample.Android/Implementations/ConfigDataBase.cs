using System.IO;
using Xamarin.Forms;
using EFCExample.Droid.Implementations;
using EFCExample.Interfaces;


[assembly: Dependency(typeof(ConfigDataBase))]
namespace EFCExample.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}