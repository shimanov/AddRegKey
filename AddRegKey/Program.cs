using Microsoft.Win32;

namespace AddRegKey
{
    class Program
    {
        protected void Main()
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Validata\\zcs", "TimeWarnExpiredCert", "00,00,00,00", RegistryValueKind.Binary);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Validata\\zcs", "TimeWarnExpiredCrl", "00,00,00,00", RegistryValueKind.Binary);
        }
    }
}
