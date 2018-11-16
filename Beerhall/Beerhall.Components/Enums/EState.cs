namespace Beerhall.Components
{
    public class EState
    {
        // Bootstrap
        public static EState Primary { get; } = new EState(0, "primary");
        public static EState Secondary { get; } = new EState(1, "secondary");
        public static EState Success { get; } = new EState(2, "success");
        public static EState Info { get; } = new EState(3, "info");
        public static EState Warning { get; } = new EState(4, "warning");
        public static EState Danger { get; } = new EState(5, "danger");
        public static EState Link { get; } = new EState(6, "link");
        // Metronic 
        public static EState Brand { get; } = new EState(7, "brand");
        public static EState Metal { get; } = new EState(8, "metal");
        public static EState Accent { get; } = new EState(9, "accent");
        public static EState Focus { get; } = new EState(10, "focus");

        public string Name { get; private set; }
        public int Value { get; private set; }

        private EState(int val, string name)
        {
            Value = val;
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
