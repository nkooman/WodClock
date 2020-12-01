namespace WodClock.Repository.EntityFramework.Entities
{
    public class ActionStep
    {
        public Action Action { get; set; }
        public int Duration { get; set; }
        public int Order { get; set; }
    }
}