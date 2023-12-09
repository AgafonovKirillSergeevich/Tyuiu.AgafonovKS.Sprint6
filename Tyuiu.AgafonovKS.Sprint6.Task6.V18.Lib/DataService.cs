using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.AgafonovKS.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] res = line.Split(' ');
                    for (int i = 0; i < res.Length; i++)
                    {
                        if (res[i].Contains("n"))
                        {
                            resStr += res[i] + " ";
                        }

                    }
                }
            }
            return resStr;
        }
    }
}
