using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace ShortURLCreator
{
    public class TrimProvider : ProviderBase
    {
        #region Constructors

        public TrimProvider()
        {
            mProviderURL = @"http://api.tr.im/api/trim_url.xml?url={0}";
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
            //<trim>
            //  <status result="OK" code="200" message="tr.im URL Added."/>
            //  <url>http://tr.im/lcjY</url>
            //  <reference>Hx5zjO66gKyKYv2baIlvjiyAM4zpK2</reference>
            //  <trimpath>lcjY</trimpath>
            //</trim>
            XElement xmlResult = XElement.Parse(result);
            var shortURLValue = from node in xmlResult.Descendants("url")
                                select node.Value;

            result = shortURLValue.First();
            return result;
        }

        #endregion
    }
}
