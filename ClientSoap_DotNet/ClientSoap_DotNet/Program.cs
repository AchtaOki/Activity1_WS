// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ServiceReference1.BanqueServiceClient stub= new ServiceReference1.BanqueServiceClient();
double res = stub.Convert(900);
Console.WriteLine(res);
Console.ReadLine();
ServiceReference1.compte cp = stub.getCompte(1);
Console.WriteLine("Solde=" +cp.solde);

