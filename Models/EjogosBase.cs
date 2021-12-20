using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_JOGOS.Models
{
    public class EjogosBase
    {
        //criar uma função para criar a pasta e o arquivo
        public void CreateFolderAndFile(string path)
        {
            string folder = path.Split("/")[0];
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            if (!File.Exists(path))
                File.Create(path);
        }
        public void AppendEquipe(string path, string[] linha)
        {
            File.AppendAllLines(path, linha);
        }
        public string[] ReadEquipes(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
