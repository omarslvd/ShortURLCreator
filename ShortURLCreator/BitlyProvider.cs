using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace ShortURLCreator
{
    public class BitlyProvider : ProviderBase
    {
        #region Constructors

        public BitlyProvider()
        {
            mProviderURL = @"http://api.bit.ly/shorten?version=2.0.1&format=xml&longUrl={0}&login={1}&apiKey={2}";
        }

        #endregion

        #region Public Methods

        public override string GetShortURL(string longURL)
        {
            HttpWebRequest request;
            StreamReader reader;
            HttpWebResponse response;
            string result = "";

            request = (HttpWebRequest)WebRequest.Create(string.Format(mProviderURL, longURL, Settings.GetBitlyLogin(), Settings.GetBitlyAPIKey()));
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            result = reader.ReadToEnd();
            // The result is a XML
            //<bitly>
            //  <errorCode>0</errorCode>
            //  <errorMessage/>
            //  <results>
            //    <nodeKeyVal>
            //      <userHash>kYnhS</userHash>
            //      <shortKeywordUrl/>
            //      <hash>qGKcO</hash>
            //      <nodeKey>http://omarslvd.blogspot.com</nodeKey>
            //      <shortUrl>http://bit.ly/kYnhS</shortUrl>
            //    </nodeKeyVal>
            //  </results>
            //  <statusCode>OK</statusCode>
            //</bitly>
            XElement xmlResult = XElement.Parse(result);
            var shortURLValue = from node in xmlResult.Descendants("results").Descendants("nodeKeyVal")
                                select node.Element("shortUrl").Value;

            result = shortURLValue.First();
            return result;
        }

        #endregion
    }
}
