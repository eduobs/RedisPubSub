# RedisPubSub

Projeto .NET de estudo para a publicação/consumo de mensagens com Redis.

## Pré-requisitos

- [Git](git-scm/download)
- [DotNet 8 SDK ou superior](https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-8.0.411-windows-x64-installer)
- [Docker](https://docs.docker.com/get-started/)
- [Imagem docker do Redis](https://hub.docker.com/_/redis)

## Passos para subir o projeto

1. **Clone o repositório repositório:**
[Clique aqui para acessar o repo](https://github.com/eduobs/RedisPubSub)

2. **Execute o conteiner do redis**
```sh
docker run -d -p 6379:6379 redis
```

3. **Execute as aplicações emn terminais distindos com o comando**
```sh
dotnet run
```