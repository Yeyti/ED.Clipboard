using System;
using System.Collections.Generic;
using System.Text;

namespace GwenNet.Platform
{
    public class Clipboard{
        private static string buf;

        public static void Copy(string val){
            if (OS.IsWindows()){
                $"echo {val} | clip".Bat();
            }

            if (OS.IsMacOS()){
                $"echo \"{val}\" | pbcopy".Bash();
            }
        }

        
        public static bool ContainsText()
        {
            /*if (OS.IsWindows())
            {
                buf = $"echo {val} | clip".Bat();
            }*/

            if (OS.IsMacOS())
            {
                buf = $"echo pbpaste".Bash();
            }
            
            return buf != "";
        }

        public static string GetText(){
            return buf;
        }
    }
}
