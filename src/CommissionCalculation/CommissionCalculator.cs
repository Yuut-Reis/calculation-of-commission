using System;

namespace CommissionCalculation;
public class CommissionCalculator
{
    public const decimal CommissionPerCarSold = 250;
    public const decimal Percentage = 3/100M;
    public decimal FixedSalary { get; set; }
    public int AmountCarsSold { get; set; }
    public decimal TotalSalesValue { get; set; }
    public decimal FinalSalary { get; set; }
    public decimal PercentageBySales { get; set;}
    public void CalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue) 
    {
        
        AmountCarsSold = amountCarsSold;
        TotalSalesValue = totalSalesValue;
        FixedSalary = fixedSalary;
        FinalSalary =  FixedSalary + (AmountCarsSold * CommissionPerCarSold) + (TotalSalesValue * Percentage);
        PercentageBySales = TotalSalesValue * Percentage;

    }

    public void ShowFinalSalary(string contributorName, string month)
    {
      throw new NotImplementedException();  
    }

}
