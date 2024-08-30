namespace SIEleccionReina.Entidades
{
    internal class ComboBoxItem
    {
        public string Display { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(){}

        public ComboBoxItem( string display, int value )
        {
            Display = display;
            Value = value;
        }

        public override string ToString() => Display;
    }
}