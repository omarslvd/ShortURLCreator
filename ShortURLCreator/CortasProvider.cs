using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace ShortURLCreator
{
    public class CortasProvider : ProviderBase
    {
        #region Constructors

        public CortasProvider()
        {
            mProviderURL = @"http://www.soitu.es/cortas/encode.pl?u={0}&r=xml";
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
            // The result is a XML
            //<cortas>
            //  <status>ok</status>
            //  <urlCortas>http://cort.as/1</urlCortas>
            //  <uriOriginal>http://www.yahoo.com/</uriOriginal>
            //  <tracking>0</tracking>
            //</cortas>
            XElement xmlResult = XElement.Parse(result);
            var shortURLValue = from node in xmlResult.Descendants("urlCortas")
                                select node.Value;

            result = shortURLValue.First();
            return result;
        }

        #endregion
    }
}
