using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1
{
    /*
    public class Events
    {
        int value;
        public delegate void numManipulator();
        //Event declaration and association with the delegate
        public event numManipulator changenum; 
        // changenum is obj and associating numManipulator with delegate

        public virtual void OnNumChanged()
        {
            Console.WriteLine("Event raised and value changed");
        }

        public Events(int n)
        {
            this.changenum += new numManipulator(this.OnNumChanged);
            setvalue(n);
        }

        public void setvalue(int n)
        {
            if(value!=n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }
    class EventTest
    {
        static void Main()
        {
            Events e = new Events(2);
            e.setvalue(2);
            e.setvalue(234);
            e.setvalue(0);

            Console.Read();
        }
    }
    */
    public class Events
    {
        int value;
        public delegate void numManipulator(int x);
        //Event declaration and association with the delegate
        public event numManipulator changenum;
        // changenum is obj and associating numManipulator with delegate

        public virtual void OnNumChanged(int x)
        {
            Console.WriteLine("Event raised and value from {0} is changed to {1}",value,x);
        }

        public Events(int n)
        {
            this.changenum += new numManipulator(this.OnNumChanged); //association of the delegate with
            setvalue(n);
        }

        public void setvalue(int n)
        {
            if (value != n)
            {
                //value = n;
                OnNumChanged(n);
            }
            else
            {
                Console.WriteLine("No notification");
            }
        }
    }
    class EventTest
    {
        static void Main()
        {
            Events e = new Events(2);
            e.setvalue(2);
            e.setvalue(234);
            e.setvalue(0);

            Console.Read();
        }
    }
}
