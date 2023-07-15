namespace WildMini
{
    public class WildMiniObject
    {
        [System.Runtime.InteropServices.DllImport("WildMiniCore.dll")]
        public static extern int CoreTest();

        public int Test()
        {
            return CoreTest();
        }
    }
}
