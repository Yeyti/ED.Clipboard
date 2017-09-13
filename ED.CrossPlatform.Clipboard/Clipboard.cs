using System;
using System.Collections.Generic;
using System.Text;

namespace GwenNet.Platform
{
    class Clipboard{
        public static void Copy(string val){
            if (OS.IsWindows()){
                $"echo {val} | clip".Bat();
            }

            if (OS.IsMacOS()||OS.IsLinux()){
                $"echo \"{val}\" | pbcopy".Bash();
            }
        }

        public static void Past()
        {
            /*
            if (OS.IsWindows())
            {
                $"echo {val} | clip".Bat();
            }*/

            if (OS.IsMacOS() || OS.IsLinux())
            {
                $"echo pbpast".Bash();
            }
        }
    }
}
