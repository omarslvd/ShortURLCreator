using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using System.Web;

namespace ShortURLCreator
{
    public class TinyArrowsProvider : ProviderBase
    {
        #region Constructors

        public TinyArrowsProvider()
        {
            mProviderURL = @"http://tinyarro.ws/api-create.php?url={0}";
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
            result = HttpUtility.HtmlDecode(result);

            return result;
        }

        #endregion
    }
}
