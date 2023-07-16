using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildMini
{
    public class WildMiniPlugin
    {
        [System.Runtime.InteropServices.DllImport("WildMiniCore.dll")]
        public static extern int CoreTest();

        public static int CoreTestPublic()
        {
            return CoreTest();
        }
    }
}
