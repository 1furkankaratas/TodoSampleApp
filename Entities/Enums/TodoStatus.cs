namespace Entities.Enums
{
    public enum TodoStatus
    {
        Activate = 0,
        Process = 1,
        Complated = 2
    }

    public class EnumValue
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
