using System.Runtime.InteropServices;

namespace UserList
{
    internal sealed class NativeMethods
    {
        [DllImport("user32")]
        public static extern void SetProcessDPIAware();
    }
}