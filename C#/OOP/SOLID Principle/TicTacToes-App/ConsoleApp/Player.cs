using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Player
    {
        private Mark mark;
        private string name;

        public Player(String name, Mark mark)
        {
            this.setMark(mark);
            this.name = name;
        }

        //public string Name { get { return name; } set{name= value;} }
        public string getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public Mark getMark()
        {
            return mark;
        }

        public void setMark(Mark mark)
        {
            this.mark = mark;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
