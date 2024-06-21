// wage calculator

static int calculatorYearlyWage(int monthlyWage, int numOfMonthsWorked){
    //Console.WriteLine($"Yearly wage: {monthlyWage * numOfMonthsWorked}");
    // return monthlyWage * numOfMonthsWorked;
    
    if(numOfMonthsWorked == 12){
        return monthlyWage * (numOfMonthsWorked + 1);
    } else {
        return monthlyWage * numOfMonthsWorked;
    }
}

int amount = 1234;
int months = 11;

// Console.WriteLine(calculatorYearlyWage(amount, months));
int yearlyWage = calculatorYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

Console.ReadLine();