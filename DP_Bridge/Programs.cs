using System.Text.RegularExpressions;
using DesignPatterns.Bridge;

IDiscount safeDriverDiscount = new SafeDriverDiscount();
CarInsurance comp1 = new Comprehensive(2023, "Mercedes-Benz", "E-Class", safeDriverDiscount);
CarInsurance thirdParty1 = new ThirdParty(2023, "VW", "Tiguan", safeDriverDiscount);
CarInsurance propDamage1 = new PropertyDamage(2023, "Cadillac", "Escalade", safeDriverDiscount);
Console.WriteLine("Safe Driver Discounts:");
Console.WriteLine("----------------------");
Print(comp1);
Print(thirdParty1);
Print(propDamage1);

IDiscount noClaimDiscount = new NoClaimsDiscount();
CarInsurance comp2 = new Comprehensive(2023, "Mercedes-Benz", "E-Class", noClaimDiscount);
CarInsurance thirdParty2 = new ThirdParty(2023, "VW", "Tiguan", noClaimDiscount);
CarInsurance propDamage2 = new PropertyDamage(2023, "Cadillac", "Escalade", noClaimDiscount);
Console.WriteLine("\nNo Claims Discounts:");
Console.WriteLine("--------------------");
Print(comp2);
Print(thirdParty2);
Print(propDamage2);

IDiscount autoOwnerDiscount = new AutoOwnersDiscount();
CarInsurance comp3 = new Comprehensive(2023, "Mercedes-Benz", "E-Class", autoOwnerDiscount);
CarInsurance thirdParty3 = new ThirdParty(2023, "VW", "Tiguan", autoOwnerDiscount);
CarInsurance propDamage3 = new PropertyDamage(2023, "Cadillac", "Escalade", autoOwnerDiscount);
Console.WriteLine("\nAuto Owners Discounts:");
Console.WriteLine("----------------------");
Print(comp3);
Print(thirdParty3);
Print(propDamage3);

static void Print(CarInsurance carInsurance)
{
    Console.WriteLine($"{PascalCaseToSentence(carInsurance.GetType().Name)} Premium:"
        + $"{carInsurance.Year} {carInsurance.Make} {carInsurance.Model}"
        + $"@ ${carInsurance.CalculatePremium():f2} p/m");
}

static string PascalCaseToSentence(string input)
{
    return Regex.Replace(input, "(\\B[A-Z])", " $1").Trim();
}