using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Player_App
{
    class Player
    {
        private int id;
		private String name;
		private int age;

        public Player(int id, String name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public Player(int id, String name)
            : this(id, name, 18)
        {    
        }

		public override string ToString(){
			return "id="+id+"\nname="+name+"\nage"+age;
		}

        public override Boolean Equals(Object obj)
        {
            if (this.Id == ((Player)obj).Id)
            {
                return true;
            }
            else
                return false;
        }

        public Player whoIsElder(Player playerType)
        {
            return this.Age > playerType.Age ? this : playerType;

        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

    }
}
