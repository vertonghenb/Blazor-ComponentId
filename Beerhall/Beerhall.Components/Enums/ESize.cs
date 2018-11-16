namespace Beerhall.Components

{
    public class ESize
    {
        public static ESize Small { get; } = new ESize(0, "sm");
        public static ESize Medium { get; } = new ESize(1, "md");
        public static ESize Large { get; } = new ESize(2, "lg");

        public string Name { get; private set; }
        public int Value { get; private set; }

        private ESize(int val, string name)
        {
            Value = val;
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        //public static implicit operator string(ESize size)
        //{
        //    return size.Name;
        //}
    }
}
