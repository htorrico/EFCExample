using System;
using System.Collections.Generic;
using System.Text;

namespace EFCExample.Interfaces
{
    public interface IConfigDataBase
    {
        //Implementación Ruta
        string GetFullPath(string databaseFileName);
    }
}
