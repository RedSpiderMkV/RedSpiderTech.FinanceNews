using System.Configuration;
using System.IO;

namespace RedSpiderTech.FinanceNews.Host.Utilities.Implementation
{
    public class AppConfigurationManager
    {
        #region Properties

        public string LogFile
        {
            get
            {
                string logFileDirectory = ConfigurationManager.AppSettings["logFileDirectory"];
                string logFileName = ConfigurationManager.AppSettings["logFileName"];
                string logFile = Path.Combine(logFileDirectory, logFileName);

                return logFile;
            }
        }

        #endregion
    }
}
