using System.ComponentModel.DataAnnotations;

public class LoanItem
{
    [Key]
    public int Id { get; set; }

    [Required]
    public required string Name { get; set; }

    //대출 금액
    [Required]
    public decimal Amount { get; set; }

    //이자율
    [Required]
    public double InterestRate { get; set; }

    //대출 기간(개월)
    [Required]
    public int TermInMonths { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}