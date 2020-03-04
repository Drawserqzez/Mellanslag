namespace Lib {
    public class Achievement : ISubscriber {
        public int UnlockLimit;
        public string Name { get; set; }
        public bool Unlocked { get; set; } = false;

        public void Update(Game game) {
            if (game.Score >= UnlockLimit && !Unlocked) {
                Unlocked = true;
                game.Unsubscribe(this);
            }
        }
    }
}