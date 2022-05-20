using System;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using YukkuriCli.Voices;

namespace YukkuriCli {
    class Program {
        static void Main(string[] args) {
            
            Voices.Voices voices = new Voices.Voices();
            voices.F1.Play("こんにちわ.ゆっくりれいむです");
            voices.F2.Play("ゆっくりまりさだぜ");

        }
    }
}
