using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace ShortURLCreator
{
    public class IsgdProvider : ProviderBase
    {
        #region Constructors

        public IsgdProvider()
        {
            mProviderURL = @"http://is.gd/api.php?longurl={0}";
        }

        #endregion

        #region Public Methods

        public override string GetShortURL(string longURL)
        {
            HttpWebRequest request;
            StreamReader reader;
            HttpWebResponse response;
            string result = "";

            request = (HttpWebRequest)WebRequest.Create(string.Format(mProviderURL, longURL));
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            result = reader.ReadToEnd();
            
            return result;
        }

        #endregion
    }
}
