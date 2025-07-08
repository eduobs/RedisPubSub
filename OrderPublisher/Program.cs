using StackExchange.Redis;

var redis = await ConnectionMultiplexer.ConnectAsync("localhost:6379");
var pub = redis.GetSubscriber();

Console.WriteLine("O Publisher se conectou ao Redis.");
Console.WriteLine("Digite um ID de pedido para publicar (ou 'exit' para sair):");

while (true)
{
    var input = Console.ReadLine();

    if (input?.ToLower() == "exit")
        break;

    await pub.PublishAsync(RedisChannel.Literal("orders.new"), input);
    Console.WriteLine($"[{DateTime.UtcNow:T}] - Publicado: {input}");
}
