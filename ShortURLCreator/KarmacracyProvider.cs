using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace ShortURLCreator
{
    public class KarmacracyProvider : ProviderBase
    {
        #region

        public KarmacracyProvider()
        {
            mProviderURL = @"http://kcy.me/api/?u={0}&key={1}&url={2}";
        }

        #endregion

        #region Public Methods

        public override string GetShortURL(string longURL)
        {
            HttpWebRequest request;
            StreamReader reader;
            HttpWebResponse response;
            string result = "";

            request = (HttpWebRequest)WebRequest.Create(string.Format(mProviderURL, Settings.GetKarmacracyUser(), Settings.GetKarmacracyKeypass(), longURL));
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            // The result is a simple text
            result = reader.ReadToEnd();

            return result;
        }

        #endregion
    }
}
