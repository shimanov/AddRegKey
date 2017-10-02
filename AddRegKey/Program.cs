using Microsoft.Win32;

namespace AddRegKey
{
    class Program
    {
        protected static int Main()
        {
            try
            {
                byte[] data = { 0x00, 0x00, 0x00, 0x00 };
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Validata\\zcs", "TimeWarnExpiredCert", data, RegistryValueKind.Binary);
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Validata\\zcs", "TimeWarnExpiredCrl", data, RegistryValueKind.Binary);

                return 0;
            }
            catch (System.Exception)
            {
                return 1;
            }
        }
    }
}
