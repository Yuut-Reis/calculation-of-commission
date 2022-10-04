using Xunit;
using FluentAssertions;
using CommissionCalculation.Test;
using System.Globalization;

namespace CommissionCalculation.Test.Test;

public class TestCommissionCalculatorTest1
{    
    [Trait("Category", "1 - Criou testes de sucesso para TestCalculatorFinalSalary.")]    
    [Theory(DisplayName = "TestCalculatorFinalSalary deve passar com as entradas corretas.")]
    [InlineData(1200, 2, 60000, 3500)]
    public void TestSucessTestCalculatorFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue, decimal expectedFinalSalary) 
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
        CommissionCalculatorTest instance = new();
        Action act = () => instance.TestCalculateFinalSalary(fixedSalary, amountCarsSold, totalSalesValue, expectedFinalSalary);
        act.Should().NotThrow();
    }
}
public class TestCommissionCalculatorTest2
{    
    [Trait("Category", "2 - Criou testes de falha para TestCalculatorFinalSalary.")]
    [Theory(DisplayName = "TestCalculatorFinalSalary deve falhar caso as entradas sejam incorretas.")]
    [InlineData(1200, 2, 60000, 2000)]
    public void TestFailTestCalculatorFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue, decimal expectedFinalSalary)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
        CommissionCalculatorTest instance = new();
        Action act = () => instance.TestCalculateFinalSalary(fixedSalary, amountCarsSold, totalSalesValue, expectedFinalSalary);
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}

public class TestCommissionCalculatorTest3
{    
    [Trait("Category", "3 - Criou testes de sucesso para ShowFinalSalary.")]
    [Theory(DisplayName = "ShowFinalSalary passar ao executar com os valores corretos.")]
    [InlineData("Nome Contribuidor", "janeiro", new string[] {
        "O colaborador Nome Contribuidor neste mês de janeiro obteve o salário final de R$0.00 referente à:",
        "SALARIO FIXO: R$0.00",
        "TOTAL DE CARROS VENDIDOS: 0",
        "VALOR TOTAL DE VENDAS NO MES: R$0.00",
        "COMISSÃO POR CARROS VENDIDOS: R$0.00",
        "COMISSÃO DE 3% DO TOTAL DE VENDAS: R$0.00"
    })]
    public void TestSuccessTestShowFinalSalary(string contributorName, string month, string[] expectedMessage)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
        CommissionCalculatorTest instance = new();
        Action act = () => instance.TestShowFinalSalary(contributorName, month, expectedMessage);
        act.Should().NotThrow();
    }
}
public class TestCommissionCalculatorTest4
{
    
    [Trait("Category", "4 - Criou testes de falha para ShowFinalSalary.")]
    [Theory(DisplayName = "ShowFinalSalary deve falhar caso as entradas sejam incorretas.")]
    [InlineData("Nome Contribuidor", "janeiro", new string[] {
        "O colaborador NomeContribuidor neste mês dejaneiro obteve o salário final de R$3500 referente à:",
        "SALARIO FIXO: R$1200",
        "TOTAL DE CARROS VENDIDOS: 0",
        "VALOR TOTAL DE VENDAS NO MES: R$0",
        "COMISSÃO POR CARROS VENDIDOS: R$0",
        "COMISSÃO DE 3% DO TOTAL DE VENDAS: R$0"
    })]
    public void TestFailTestShowFinalSalary(string contributorName, string month, string[] expectedMessage)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
        CommissionCalculatorTest instance = new();
        Action act = () => instance.TestShowFinalSalary(contributorName, month, expectedMessage);
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}
