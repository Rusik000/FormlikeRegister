using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormQuestions
{
    public static class FileHelper
    {
        public static string Filename { get; set; }

        public static void Serialize(List<Worker> workers)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(Filename))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, workers);
                }
            }
        }

        public static void Deserialize()
        {

            List<Worker> workers = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader(Filename))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    workers = serializer.Deserialize<List<Worker>>(jr);
                }
                foreach (var item in workers)
                {
                    Console.WriteLine(item);
                }

            }


        }

    }
}
