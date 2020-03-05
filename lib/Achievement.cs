using System;

namespace lib {
    public class Achievement : IObserver<Achievement>
    {
        private string _name; 
        private bool _isUnlocked;

        public bool IsUnlocked { get; private set; }    

        public Achievement(string name) {
            _name = name;
            IsUnlocked = false;
        }

        public void Unlock() {
            IsUnlocked = false;
        }

        public override string ToString(){
            string str = $"---<<{_name}>>---";
            return str;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Achievement value)
        {
            if (value.)
        }
    }
}