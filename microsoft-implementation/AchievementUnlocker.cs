using System;

namespace Lib 
{
    public class AchievementUnlocker : IObserver<Achievement> {
        private Achievement _achievementToUnlock;
        private IDisposable _destroyer;

        public AchievementUnlocker(Achievement unlock) {
            if (unlock == null)
                throw new InvalidOperationException("Achievement cannot be null");

            _achievementToUnlock = unlock;
        }

        public void Subscribe(Game game) {
            _destroyer = game.Subscribe(this);
        }

        public void Unsubscribe() {
            _destroyer.Dispose();
        }

        public void OnCompleted() {
            Unsubscribe();
            _achievementToUnlock = null;
        }

        public void OnError(Exception error) {

        }

        public void OnNext(Achievement value) {
            if (!_achievementToUnlock.IsUnlocked) {
                if (value.UnlockCondition == _achievementToUnlock.UnlockCondition) {
                    _achievementToUnlock.IsUnlocked = true;
                    System.Console.WriteLine("Unlocked {0}!", _achievementToUnlock.Name);
                }
            }
        }
    }
}