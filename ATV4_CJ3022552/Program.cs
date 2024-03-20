
// ATIVIDADE 4

//1 
Console.WriteLine("Escolha a operação que deseja iniciar \n1- débito \n2-crédito \n3- pix \n4- boleto \n5- transferência bancária ");

int opç = int.Parse(Console.ReadLine());

switch (opç)

{
    case 1:
        Console.WriteLine("o pagamento será efetuado no Débito");
        break;

    case 2:
        Console.WriteLine(" O pagamento será efetuado no crédito");
        Console.WriteLine("Haverá um acréssimo de 3%");
        break;

    case 3:
        Console.WriteLine("O pagamento será efetuado por pix");
        Console.WriteLine("Haverá um desconto de 5%");
        break;

    case 4:
        Console.WriteLine("O pagamento será efetuado em boleto");
        Console.WriteLine(" Haverá um acréssimo de 5% ");
        break;

    case 5:
        Console.WriteLine(" Será realizado uma transferência bancária");
        break;


}

