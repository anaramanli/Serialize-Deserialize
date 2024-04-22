using Newtonsoft.Json;

namespace ConsoleApp1.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> nameAnar = new List<string>();
            //Add
            nameAnar.Add("Anar");
            nameAnar.Add("Porsche");


            string json = JsonConvert.SerializeObject(nameAnar);
            /*Serialize(json);*/
            List<string> deserializedData = Deserialize<List<string>>(@"C:\path\to\json1.json");

            #region Serialize

            Delete(1, nameAnar);
            Console.WriteLine(json);


            static void Serialize(string json)
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\User\Desktop\File, Directory\ConsoleApp1\ConsoleApp1\JsonFile\json1.json"))
                {
                    sw.Write(json);
                }
            }

            static T Deserialize<T>(string filePath)
            {
                string result;
                using (StreamReader sr =
                       new(@"C:\Users\User\Desktop\File, Directory\ConsoleApp1\ConsoleApp1\JsonFile\json1.json"))
                {
                    result = sr.ReadToEnd();
                }

                T objective = JsonConvert.DeserializeObject<T>(result);
                return objective;
            }



            #endregion
            #region Deserialize
            /*string result;
            using (StreamReader sr =
                   new(@"C:\Users\User\Desktop\File, Directory\ConsoleApp1\ConsoleApp1\JsonFile\json1.json"))
            {
                result = sr.ReadToEnd();
            }
            //Generic
            List<string> objects = JsonConvert.DeserializeObject<List<string>>(result);
            foreach (string name in objects)
            {
                
                Console.WriteLine(name);
            }*/
            #endregion
            /*#region Bool Search
            string result;
            using (StreamReader sr =
                   new(@"C:\Users\User\Desktop\File, Directory\ConsoleApp1\ConsoleApp1\JsonFile\json1.json"))
            {
                result = sr.ReadToEnd();
            }
            List<string> objects = JsonConvert.DeserializeObject<List<string>>(result);
            //
            Console.WriteLine(result);
            bool Search1(string name, List<string> objects)
            {
                foreach (var item in objects)
                {
                    if (objects.Contains(name))
                    {
                        return true;
                    }
                }
                return false;
            }
            bool Search(string name, List<string> objects)
            {
                foreach (var item in objects)
                {
                    if (item == name)
                    {
                        return true;
                    }
                }
                return false;
            }
            Console.WriteLine(Search1("G-Wagon", objects));
            #endregion*/

            #region Delete

            static void Delete(int index, List<string> objects)
            {
                if (index >= 0 && index < objects.Count)
                {
                    objects.RemoveAt(index);
                    Console.WriteLine("Removed");
                }
                else
                {
                    Console.WriteLine("cant find");
                }
            }

            /*using (StreamWriter sw = new(@"C:\Users\User\Desktop\File, Directory\ConsoleApp1\ConsoleApp1\JsonFile\json1.json"))
            {
                foreach (string item in nameAnar)
                {
                    sw.Write(json);
                */
        }
    }
    #endregion
    /*Directory.CreateDirectory(json);*/
}

