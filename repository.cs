using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class repository
    {
        public void GetBookbyId(int id)
        {
            FileStream Books = new FileStream("Ссылка на файл", FileMode.Open);
            StreamReader reader = new StreamReader(Books);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
    }
}
