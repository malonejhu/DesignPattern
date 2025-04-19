using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Practice1
{
    [Serializable]
    internal class WeeklyLog
    {
        private Attachment attachment;
        private string name;
        private string date;
        private string content;


        public Attachment Attachment 
        {
            get { return attachment; }
            set { attachment = value; }
        }


        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public WeeklyLog Clone() 
        {
            //淺clone
            //return this.MemberwiseClone() as WeeklyLog;

            WeeklyLog clone = null;

            //FileStream fs = new FileStream("Temp.dat", FileMode.Create);
            //BinaryFormatter formatter = new BinaryFormatter();

            //try
            //{
            //    formatter.Serialize(fs, this);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    throw;
            //}
            //finally 
            //{
            //    fs.Close();
            //}

            FileStream fs1 = new FileStream("Temp.dat", FileMode.Open);
            BinaryFormatter formatter1 = new BinaryFormatter();

            try
            {
                clone = (WeeklyLog)formatter1.Deserialize(fs1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally 
            {
                fs1.Close();
            }

            return clone;
        }
    }
}