using System.Configuration;

namespace Modson
{
    public class ModsonDatabaseConnectionSettings : ConfigurationSection
    {
        public static ModsonDatabaseConnectionSettings Settings { get; } =
            ConfigurationManager.GetSection("modsonDbConnectionSettings") as
                ModsonDatabaseConnectionSettings;

        [ConfigurationProperty("Host", IsRequired =  false)]
        public string Host
        {
            get { return (string) this["Host"]; }
            set { this["Host"] = value; }
        }
        [ConfigurationProperty("Port", IsRequired = false)]
        public string Port
        {
            get { return (string)this["Port"]; }
            set { this["Port"] = value; }
        }
        [ConfigurationProperty("User", IsRequired = false)]
        public string User
        {
            get { return (string) this["User"]; }
            set { this["User"] = value; }
        }

        [ConfigurationProperty("Password", IsRequired = false)]
        public string Password
        {
            get { return (string) this["Password"]; }
            set { this["Password"] = value; }
        }

        [ConfigurationProperty("DatabaseName", IsRequired = false)]
        public string DatabaseName
        {
            get { return (string) this["DatabaseName"]; }
            set { this["DatabaseName"] = value; }
        }
    }
}
