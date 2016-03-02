namespace ShortURLCreator
{
    public abstract class ProviderBase
    {
        #region Protected Fields

        protected string mProviderURL;

        #endregion

        #region Properties

        public string ProviderURL
        {
            get { return mProviderURL; }
            set { mProviderURL = value; }
        }

        #endregion

        #region Public Methods

        public abstract string GetShortURL(string longURL);

        #endregion
    }
}
