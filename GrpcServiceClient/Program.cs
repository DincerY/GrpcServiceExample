using Grpc.Net.Client;
using GrpcGreeterClient;


using var channel = GrpcChannel.ForAddress("https://localhost:7183");
var client = new Greeter.GreeterClient(channel);

Console.WriteLine("Adınızı giriniz : ");
var name = Console.ReadLine();
Console.WriteLine("Soy adınızı giriniz : ");
var surname = Console.ReadLine();

var reply = await client.SayHelloAsync(
    new HelloRequest { Name = name , Surname = surname});
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();