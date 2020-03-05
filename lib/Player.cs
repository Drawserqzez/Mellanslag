
using System;
using System.Collections.Generic;

namespace lib {
    public class Player
    {
        public int Score { get; set; }
        public List<Achievement> Achievments { get; set; }

        public override string ToString() {
            string str = "";
            foreach (var achivements in Achievments) {
                str += achivements.ToString();
                str += "\n\r";
            }
            return str;
        }


    }
}