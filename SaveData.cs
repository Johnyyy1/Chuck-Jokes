using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuck_Jokes
{
    internal class SaveData
    {
        public void Save(string logFilePath, string value, string icon_url)
        {
            string searchQuery = value;
            string searchQuery1 = icon_url;
            if (!string.IsNullOrEmpty(searchQuery) && !string.IsNullOrEmpty(searchQuery1))
            {
                File.AppendAllText(logFilePath, searchQuery + Environment.NewLine);
                File.AppendAllText(logFilePath, searchQuery1 + Environment.NewLine);
            }
        }
    }
}
