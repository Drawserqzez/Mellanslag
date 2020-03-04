namespace lib {
    public class Achievement {
        private string _name; 
        private bool _isUnlocked;

        public bool IsUnlocked { get; private set; } = false;        
        
        public Achievement() {

        }        

        public Achievement(string name) {
            _name = name;
        }

        public void Unlock() {
            IsUnlocked = false;
        }

        public override string ToString(){
            string str = $"---<<{_name}>>---";
            return str;
        }
    }
}