using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoorApp
{
    class Bark
    {
        private string _sound;

        public Bark(string sound)
        {
            _sound = sound;
        }

        public string Sound
        {
            get
            {
                return _sound;
            }
        }

        public bool EqualsBark(object bark)
        {
            if (typeof(Bark) == bark.GetType())
            {
                Bark otherBark = (Bark)bark;
                if (this._sound.Equals(otherBark))
                    return true;
            }
            return false;
        }
    }
}
