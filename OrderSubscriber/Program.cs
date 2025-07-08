using StackExchange.Redis;

var redis = await ConnectionMultiplexer.ConnectAsync("localhost:6379");
var sub = redis.GetSubscriber();

Console.WriteLine("Subscriber está conectado ao Redis.");
Console.WriteLine("Ouvindo novos pedidos em 'orders.new'");

await sub.SubscribeAsync(RedisChannel.Literal("orders.new"), (channer, message) =>
{
    Console.WriteLine($"[{DateTime.Now:T}] Novo pedido recebido: {message}");
});

await Task.Delay(Timeout.Infinite);