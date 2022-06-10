namespace Wordlin
{
    internal class LetterRule
    {
        public LetterRule(string letter)
        {
            Letter = letter.ToLower()[0];
        }

        public char Letter { get; private set; }
        /// <summary>
        /// null -> ignore, true -> contains, false -> does NOT contain
        /// </summary>
        public bool? IsInclude { get; set; }
        /// <summary>
        /// null -> position anywhere (yellow), true -> fixed Position (green), false -> exists, but not in this Position
        /// </summary>
        public bool? IsPosition { get; set; }
        /// <summary>
        /// Fixed position (0-based)
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// true -> letter is contained at least twice
        /// </summary>
        public bool IsSecondOccurence { get; set; } = false;
        /// <summary>
        /// null -> second leter position anywhere, true -> fixed SecondPosition, false -> second letter exists, but not in this SecondPosition
        /// </summary>
        public bool? IsSecondPosition { get; set; }
        public int SecondPosition { get; set; }
    }
}
