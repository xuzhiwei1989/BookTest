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
            DriveClass driveClass = new DriveClass();
            driveClass.ID = "00123";
            driveClass.ShowMessage();

            myClass myclass = driveClass;
            myclass.ID = "00124";
            myclass.ShowMessage();
            driveClass.ShowMessage();
        }
    }

    public abstract class myClass
    {
        private string _id = "";

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public abstract void ShowMessage();
    }

    public class DriveClass : myClass
    {
        public override void ShowMessage()
        {
            //throw new NotImplementedException();
            Console.WriteLine(ID + " ");
        }
    }
}
