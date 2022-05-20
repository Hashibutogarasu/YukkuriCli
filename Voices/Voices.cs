using System;
using System.Collections.Generic;
using System.Text;

namespace YukkuriCli.Voices {

    class Voices {
        public F1 F1 { get; set; }
        public F2 F2 { get; set; }
        public Imd1 Imd1 { get; set; }
        public Jgr Jgr { get; set; }
        public M1 M1 { get; set; }
        public M2 M2 { get; set; }
        public R1 R1 { get; set; }

        public Voices() {

            F1 = new F1();
            F2 = new F2();
            Imd1 = new Imd1();
            Jgr = new Jgr();
            M1 = new M1();
            M2 = new M2();
            R1 = new R1();

        }
    }
}
