# RedisPubSub

Projeto .NET de estudo para a publicação/consumo de mensagens com Redis.

## Pré-requisitos

- [Git](git-scm/download)
- [DotNet 8 SDK ou superior](https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-8.0.411-windows-x64-installer)
- [Docker](https://docs.docker.com/get-started/)
- [Imagem docker do Redis](https://hub.docker.com/_/redis)

## Passos para subir o projeto

1. **Faça o download do repositório:**
[Clique aqui para realizar o download]()

2. **Descompacte o projeto...**

3. **Execute o conteiner do redis**
```sh
docker run -d -p 6379:6379 redis
```

4. **Execute a aplicação que envia mensagens**
```sh
dotnet run
```

4. **Execute a aplicação que consome mensagens**
```sh
dotnet run
```