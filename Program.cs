    BanckAccount bankUser1 = new BanckAccount();
    Car car1 = new();
    bankUser1.User = "Mario";
    bankUser1.Balance = 1500.15f;

    Console.WriteLine($"Titular: {bankUser1.User}, saldo: {bankUser1.Balance}");
    
    car1.Ano = 2028;
    Console.WriteLine(car1.Ano);