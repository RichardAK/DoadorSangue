int idade; 

Console.Write("Indique sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if(idade >= 18 && idade <= 67)
{   
  Console.WriteLine("Você pode doar sangue");
}

else
{   
   Console.WriteLine("Você não pode doar sangue");  
}