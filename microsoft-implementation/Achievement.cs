using System;

namespace Lib
{
    public class Achievement {
        public string Name { get; set; }
        public bool IsUnlocked { get; set; }

        public Achievement(string name) {
            Name = name;
            IsUnlocked = false;
        }
    }
}
