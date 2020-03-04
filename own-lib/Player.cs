using System.Collections.Generic;

namespace Lib {
    public class Player {
        public List<Achievement> Achievements { get; private set; }

        public Player() {
            InstansiateAchievements();
        }
        
        private void InstansiateAchievements() {
            Achievements = new List<Achievement> {
                new Achievement{ Name = "10 Poäng!", UnlockLimit = 10 },
                new Achievement{ Name = "100 Poäng! Fint klickat!", UnlockLimit = 100 },
                new Achievement{ Name = "1000 Poäng :o", UnlockLimit = 1000 },
                new Achievement{ Name = "100 000 Poäng. Du är sjuk", UnlockLimit = 100000 }
            };
        }
    }
}