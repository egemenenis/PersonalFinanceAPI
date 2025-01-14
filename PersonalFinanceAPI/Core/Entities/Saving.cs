namespace PersonalFinanceAPI.Core.Entities
{
    public class Saving
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}