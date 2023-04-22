internal class Program
{

    public static void Main(string[] args)
    {

        string? choice;
        List<User> UserList = new List<User>();

        do
        {
            //Menu Area
            Console.WriteLine("Boas-vindas!\n1) Para adicionar um novo usuário ao sistema.\n2) Mostrar todos os usuários já cadastrados.\n3) Excluir um usuário do sistema.\n----------------\nX) Sair.");

            //User's choice verification
            choice = Console.ReadLine();
            while (choice != "1" && choice != "2" && choice != "3" && choice != "x" && choice != "X")
            {
                Console.WriteLine("Opção inválida, por favor escolha novamente.");
                choice = Console.ReadLine();
            }

            //Insert name Area
            switch (choice)
            {
                case "1":
                    string? SignNewUser;
                    do
                    {

                        Console.WriteLine("Digite seu nome de usuário:");
                        string? _name = Console.ReadLine();

                        while (_name == "")
                        {
                            Console.WriteLine("Usuário inválido, tente novamente.");
                            _name = Console.ReadLine();
                        }

                        User user = new User(_name);
                        UserList.Add(user);
                        Console.WriteLine("Seu nome de usuário foi cadastrado com sucesso!\nDigite (s) para cadastrar outro usuário ou (n) para retornar ao menu principal.");
                        SignNewUser = Console.ReadLine();
                        while (SignNewUser != "s" && SignNewUser != "S" && SignNewUser != "n" && SignNewUser != "N")
                        {
                            Console.WriteLine("Opção inválida, tente novamente.");
                            SignNewUser = Console.ReadLine();
                        }
                    } while (SignNewUser != "n" && SignNewUser != "N");
                    Console.Clear();
                    break;


                case "2":
                    Console.WriteLine("Aqui estão todo os usuários cadastrados:\n");
                    int UserOrder = 0;
                    foreach (User _user in UserList)
                    {
                        Console.WriteLine("{0}.{1}", UserOrder, _user.name);
                        UserOrder++;

                    }
                    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu! :)");
                    Console.ReadKey();
                    Console.Clear();

                    break;

                case "3":
                    Console.WriteLine("Estes são todos os usuários cadastrados no sistema:\n");
                    int UserCounter = 0;

                    foreach (User _user in UserList)
                    {
                        Console.WriteLine("{0}.{1}", UserCounter, _user.name);
                        UserCounter++;
                    }
                    Console.WriteLine("\nInsira o número do usuário que você deseja excluir:");
                    int UserIndex = Convert.ToInt32(Console.ReadLine());
                    while (UserIndex >= UserList.Count)
                    {
                        Console.WriteLine("O número escolhido não condiz com nenhum existente no sistema, tente novamente.");
                        UserIndex = Convert.ToInt32(Console.ReadLine());
                    }
                    if (UserIndex >= 0 && UserIndex <= UserList.Count)
                    {
                        User RemovedUser = UserList[UserIndex];
                        UserList.RemoveAt(UserIndex);
                        Console.WriteLine("O usuário removido foi: {0}", RemovedUser.name);
                    }
                    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu! :)");
                    Console.ReadKey();
                    Console.Clear();

                    break;
                case "x":
                    Console.WriteLine("Até a próxima! :)");
                    break;

                case "X":
                    Console.WriteLine("Até a próxima! :)");
                    break;
            }

        } while (choice != "x" && choice != "X");

        Console.ReadKey();
    }
}