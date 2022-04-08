namespace ININET.Model.Configuration
{
    public class ConcatenateDuplicatedKeysIniParserConfiguration : IniParserConfiguration
    {
        public new bool AllowDuplicateKeys { get {return true; }}
        public ConcatenateDuplicatedKeysIniParserConfiguration()
            :base()
        {
            ConcatenateSeparator = ";";
        }

        public ConcatenateDuplicatedKeysIniParserConfiguration(ConcatenateDuplicatedKeysIniParserConfiguration ori)
            :base(ori)
        {
            this.ConcatenateSeparator = ori.ConcatenateSeparator;
        }

        /// <summary>
        ///     Gets or sets the string used to concatenate duplicated keys.
        /// </summary>
        /// <value>
        ///     Defaults to ';'.
        /// </value>
        public string ConcatenateSeparator { get; set; }
    }

}