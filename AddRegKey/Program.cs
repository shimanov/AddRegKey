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

                //Type
                string type = "16";
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\zCSSVC", "Type", type, RegistryValueKind.DWord);

                //Start
                string start = "2";
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\zCSSVC", "Start", start, RegistryValueKind.DWord);

                //ErrorControl
                string errorControl = "1";
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\zCSSVC", "ErrorControl", errorControl, RegistryValueKind.DWord);

                //DelayedAutostart
                string delayedAutostart = "1";
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\zCSSVC", "DelayedAutostart", delayedAutostart, RegistryValueKind.DWord);

                //FailureActionsOnNonCrashFailures
                string failureActionsOnNonCrashFailures = "1";
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\zCSSVC", "FailureActionsOnNonCrashFailures", failureActionsOnNonCrashFailures, RegistryValueKind.DWord);

                //FailureActions
                byte[] failureActions = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00,
                                          0x00, 0x01, 0x00, 0x00, 0x00, 0xe0, 0x93, 0x04, 0x00, 0x01, 0x00, 0x00, 0x00, 0xe0, 0x93, 0x04, 0x00, 0x01, 0x00,
                                          0x00, 0x00, 0xe0, 0x93, 0x04, 0x00 };
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\zCSSVC", "FailureActions", failureActions, RegistryValueKind.Binary);

                return 0;
            }
            catch (System.Exception)
            {
                return 1;
            }
        }
    }
}
