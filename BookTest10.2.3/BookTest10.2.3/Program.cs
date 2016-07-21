using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTest10._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DriveClass driveClass = new DriveClass();
            //driveClass.ID = "00123";
            //driveClass.ShowMessage();

            //myClass myclass = driveClass;
            ////myclass.ID = "00124";
            //myclass.ShowMessage();
            ////driveClass.ShowMessage();

            myClass2 myclass = new myClass2();
            myclass.ID = "123456";
            myclass.ShowMessage();
        }
    }

    public class myClass2
    {
        private string id = "#####";
        public string ID { get; set; }

        public void ShowMessage()
        {
            Console.WriteLine("ID = " + ID);
            Console.WriteLine("id = " + id);
        }
    }

    public abstract class myClass
    {
        private string _id = "#####";

        public string ID { get; set; }

        public abstract void ShowMessage();
    }

    public class DriveClass : myClass
    {
        //public new string ID { get; set; }

        public override void ShowMessage()
        {
            //throw new NotImplementedException();
            Console.WriteLine(ID);
        }
    }
}
