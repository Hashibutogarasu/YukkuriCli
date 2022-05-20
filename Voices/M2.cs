using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YukkuriCli.Voices {
    class M2 {
        const string dllPath = ".\\lib\\m2\\AquesTalk.dll";

        [DllImport(dllPath)]
        private static extern IntPtr AquesTalk_Synthe(string koe, int iSpeed, ref int size);

        [DllImport(dllPath)]
        private static extern void AquesTalk_FreeWave(IntPtr wavPtr);

        public M2() {

        }

        public void Play(string voice_text, int speed = 100, int size = 0) {
            IntPtr wavPtr = IntPtr.Zero;

            try {
                wavPtr = AquesTalk_Synthe(voice_text, speed, ref size);

                if (wavPtr == IntPtr.Zero) {
                    throw new Exception("音声生成に失敗しました。不正な文字が使われた可能性があります。");
                }
            }
            catch (Exception exception) {
                throw exception;
            }

            byte[] wav = new byte[size];
            Marshal.Copy(wavPtr, wav, 0, size);

            AquesTalk_FreeWave(wavPtr);

            using (var ms = new MemoryStream(wav))
            using (var sp = new SoundPlayer(ms)) {
                sp.PlaySync();
            }

            return;
        }
    }
}
