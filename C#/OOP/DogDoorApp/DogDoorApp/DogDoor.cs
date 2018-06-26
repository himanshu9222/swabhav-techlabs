using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;


namespace DogDoorApp
{
    class DogDoor
    {
        private bool _open;
        private List<Bark> _allowedBarks;

        public DogDoor()
        {
            _allowedBarks = new List<Bark>();
            _open = false;
        }

        public void AddAllowedBark(Bark bark)
        {
            _allowedBarks.Add(bark);
        }

        public List<Bark> GetAllowedBark
        {
            get
            {
                return _allowedBarks;
            }
        }

        public bool isOpen()
        {
            return _open;
        }

        public void Close()
        {
            Console.WriteLine("The Dog Door Closes");
            _open = false;
        }

        public void Open()
        {
            Console.WriteLine("The Dog Door Opens");
            _open = true;

            Timer timer = new Timer { Interval = 5000 };
            timer.Elapsed += OnTimedEvent;
        }

        void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Close();
        }
    }
}
