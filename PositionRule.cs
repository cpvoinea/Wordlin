namespace Wordlin
{
    internal class PositionRule
    {
        public int Position { get; private set; }
        public string Letter { get; set; }
        public Rule Rule { get; set; }

        public PositionRule(int position)
        {
            Position = position;
        }
    }
}
