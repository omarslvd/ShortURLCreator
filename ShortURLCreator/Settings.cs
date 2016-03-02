using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lumos.Shared;

namespace ShortURLCreator
{
    public static class Settings
    {
        public static void SetBitlyLogin(string bitlyLogin)
        {
            ConfigurationFileHelper.SetValue("BitlyLogin", bitlyLogin);
        }

        public static string GetBitlyLogin()
        {
            return ConfigurationFileHelper.GetValue("BitlyLogin");
        }

        public static void SetBitlyAPIKey(string bitlyAPIKey)
        {
            ConfigurationFileHelper.SetValue("BitlyAPIKey", bitlyAPIKey);
        }

        public static string GetBitlyAPIKey()
        {
            return ConfigurationFileHelper.GetValue("BitlyAPIKey");
        }

        //
        public static void SetKarmacracyUser(string karmacracyUser)
        {
            ConfigurationFileHelper.SetValue("KarmacracyUser", karmacracyUser);
        }

        public static string GetKarmacracyUser()
        {
            return ConfigurationFileHelper.GetValue("KarmacracyUser");
        }

        public static void SetKarmacracyKeypass(string karmacracyKeypass)
        {
            ConfigurationFileHelper.SetValue("KarmacracyKeypass", karmacracyKeypass);
        }

        public static string GetKarmacracyKeypass()
        {
            return ConfigurationFileHelper.GetValue("KarmacracyKeypass");
        }
    }
}
