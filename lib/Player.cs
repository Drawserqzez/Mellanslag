using System;
using System.Collections.Generic;

namespace lib {
    public class Player {
        public int Score { get; set; }
        public List<Achievement> MyProperty { get; set; }

        public override string ToString() {
            return String.Empty;
        }
    }
}