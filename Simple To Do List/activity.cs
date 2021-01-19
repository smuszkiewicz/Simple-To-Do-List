using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Simple_To_Do_List
{
    abstract class Activity
    {
        protected DateTime dateTime;
        public static List<Activity> ActivitiesList = new List<Activity>();

        protected static void Save<T>(string fileName, List<T> list)
        {
            try
            {
                using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, list);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected static List<T> Load<T>(string fileName)
        {
            var list = new List<T>();
            if (File.Exists(fileName))
            {
                try
                {
                    using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    {
                        var formatter = new BinaryFormatter();
                        list = (List<T>)
                            formatter.Deserialize(stream);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return list;
        }

    }
}
