# NetCoreComRabbitMQ

Simples exemplo de utilização de RabbitMQ com net core 

Para rodar o projeto siga as instruções abaixo (necessário docker instalado)

* instale o Docker https://docs.docker.com/desktop/

* docker pull rabbitmq

* docker run -d --hostname host-rabbit --port 5672:5672 --name rabbit rabbitmq

* docker ps (para verificar se está rodando)

* Execute primeiro o projeto Sender que é responsável por colocar as mensagens na fila

* Execute o projeto Receiver para ler as mensagens que estão na fila