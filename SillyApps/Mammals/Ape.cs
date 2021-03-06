namespace MyConsoleApp
{
    public class Ape : IMammal
    {
        public string Name { get; set; }
        public bool CanFly { get; set; }
        public bool CanRun { get; set; }

        public int HeightInCentimetres{ get; set; }
    }
}
