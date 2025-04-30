# Sistema de Pedidos com Arquitetura de Microsserviços

Este projeto simula um sistema de pedidos construído com arquitetura de microsserviços, utilizando tecnologias modernas e voltado para aprendizado prático e demonstrativo.

## 🧱 Tecnologias Utilizadas

- **.NET 8** com C#
- **ASP.NET Core Web API**
- **Azure Service Bus** (mensageria)
- **MongoDB** (banco de dados NoSQL)
- **Swagger** para documentação da API
- **Docker** (futuramente)
- **XUnit** (em implementação)

## 📦 Estrutura dos Serviços

| Projeto             | Descrição                                                                 |
|---------------------|---------------------------------------------------------------------------|
| `PedidoAPI`         | API REST para registrar pedidos, publica mensagens no Azure Service Bus. |
| `PedidoWorker`      | Worker Service que consome as mensagens da fila e salva no MongoDB.      |

## 📌 Como Executar Localmente

### Pré-requisitos
- .NET SDK 8+
- MongoDB em execução local (`mongodb://localhost:27017`)
- Azure Service Bus com string de conexão válida
- Visual Studio 2022 ou VSCode

### Execução
1. Configure `appsettings.json` com as strings de conexão (MongoDB e Service Bus)
2. Rode o projeto `PedidoAPI`
3. Acesse `https://localhost:{porta}/swagger` para testar os endpoints
4. Rode o `PedidoWorker` separadamente (ele consome da fila e salva no Mongo)

## 🚀 Próximas Etapas

- Dockerizar ambos os serviços
- Criar pipeline no Azure DevOps
- Monitoramento com DataDog
- Interface frontend opcional

## 🤝 Contribuição

Este projeto foi criado para fins de estudo e demonstração. Feedbacks e sugestões são sempre bem-vindos.

---

