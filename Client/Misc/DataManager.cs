using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace Red.Common.Client.Misc
{
    public static class DataManager
    {
        public static bool GetSettingsBool(string kvpString, string resourceName)
        {
            string savedVal = GetResourceKvpString($"red_{resourceName}_{kvpString}");
            bool exists = !string.IsNullOrEmpty(savedVal);

            if (!exists)
            {
                SetSavedBoolData(kvpString, resourceName, false);
                return false;
            }
            else
            {
                return GetResourceKvpString($"red_{resourceName}_{kvpString}").ToLower() == "true";
            }
        }

        public static void SetSavedBoolData(string kvpString, string resourceName, bool newValue) => SetResourceKvp($"red_{resourceName}_{kvpString}", newValue.ToString());
    }
}
