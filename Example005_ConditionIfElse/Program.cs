Console.Write("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha"){
    Console.WriteLine("Hello, Mashaaaa!");
}else{
    Console.WriteLine("Good morning " + username);
}

// ToLower() - Все символы строки переводит в нижний регистр (даже заглавные буквы).