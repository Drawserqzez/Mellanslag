using System;

namespace Lib
{
    public class Achievement {
        public string Name { get; set; }
        public bool IsUnlocked { get; set; }
        public int UnlockCondition { get; set; }
        public bool IsGameStateUnlock { get; set; }

        public Achievement() {
            
        }
        
        public Achievement(string name, int unlockCondition, bool isGameStateUnlock) {
            Name = name;
            UnlockCondition = unlockCondition;
            IsGameStateUnlock = isGameStateUnlock;
            IsUnlocked = false;
        }
    }
}
