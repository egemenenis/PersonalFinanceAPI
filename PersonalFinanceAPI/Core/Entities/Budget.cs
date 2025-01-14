namespace PersonalFinanceAPI.Core.Entities
{
    public class Budget
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal Limit { get; set; }
        public decimal Spent { get; set; }
    }
}