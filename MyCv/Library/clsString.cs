namespace MyCv.Library
{
    class clsString
    {
        private string setLanguage = "en-GB";
        private string en = "en-GB";
        private string srCyrillic = "sr-Cyrl-RS";
        private string srLatin = "sr-Latn-RS";

        public string Set(string contextEn, string contextSrCyrillic, string contextSrLatin)
        {
            if (setLanguage == en)
            {
                return contextEn;
            }
            else if (setLanguage == srCyrillic)
            {
                return contextSrCyrillic;
            }
            else if (setLanguage == srLatin)
            {
                return contextSrLatin;
            }
            else
            {
                return contextEn;
            }
        }
    }
}