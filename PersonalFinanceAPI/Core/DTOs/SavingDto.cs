namespace PersonalFinanceAPI.Core.DTOs
{
    public class SavingDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}