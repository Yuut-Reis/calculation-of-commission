using System;

namespace CommissionCalculation;
public class CommissionCalculator
{
  public const decimal CommissionPerCarSold = 250;
  public const decimal Percentage = 3 / 100M;
  public decimal FixedSalary { get; set; }
  public int AmountCarsSold { get; set; }
  public decimal TotalSalesValue { get; set; }
  public decimal FinalSalary { get; set; }
  public decimal PercentageBySales { get; set; }
  public void CalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue)
  {

    AmountCarsSold = amountCarsSold;
    TotalSalesValue = totalSalesValue;
    FixedSalary = fixedSalary;
    FinalSalary = FixedSalary + (AmountCarsSold * CommissionPerCarSold) + (TotalSalesValue * Percentage);
    PercentageBySales = TotalSalesValue * Percentage;

  }

  public void ShowFinalSalary(string contributorName, string month)
  {
    System.Console.WriteLine($"O colaborador {contributorName} neste mês de {month} obteve o salário final de R${FinalSalary:N2} referente à:");
    System.Console.WriteLine($"SALARIO FIXO: R${FixedSalary:N2}");
    System.Console.WriteLine($"TOTAL DE CARROS VENDIDOS:{AmountCarsSold}");
    System.Console.WriteLine($"VALOR TOTAL DE VENDAS NO MÊS: R${TotalSalesValue:N2}");
    System.Console.WriteLine($"COMISSÃO POR CARROS VENDIDOS: R$<{CommissionPerCarSold:N2}");
    System.Console.WriteLine($"COMISSÃO DE 3% DO TOTAL DE VENDAS: R$<{PercentageBySales:N2}");

  }

}
