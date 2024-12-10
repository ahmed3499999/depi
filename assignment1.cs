while(true) {
    float num1 = float.Parse(Console.ReadLine());
    char op = Console.ReadLine()[0];
    float num2 = float.Parse(Console.ReadLine());

    switch (op){
        case '+':
        Console.WriteLine(num1.ToString() + op + num2.ToString() + "=" + (num1 + num2).ToString());    
        break;
        case '-':
        Console.WriteLine(num1.ToString() + op + num2.ToString() + "=" + (num1 - num2).ToString());    
        break;
        case '*':
        Console.WriteLine(num1.ToString() + op + num2.ToString() + "=" + (num1 * num2).ToString());    
        break;
        case '/':
        if (num2 == 0) {
            Console.WriteLine("Can't divide by zero!");
        }
        else {
            Console.WriteLine(num1.ToString() + op + num2.ToString() + "=" + (num1 / num2).ToString());    
        }
        break;
    }
}