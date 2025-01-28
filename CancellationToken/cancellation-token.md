## O que é o Cancellation Token?
O CancellationToken é uma estrutura do namespace System.Threading usada para notificar tarefas assíncronas ou paralelas a interromperem sua execução. Ele é útil em cenários de timeout, onde uma operação é forçada a parar caso ultrapasse o tempo limite, e também em processos de I/O, como consultas a banco de dados ou comunicação de rede, que podem ser demorados. Ele permite gerenciar interrupções de forma eficiente e controlada em operações longas.

## Como o Cancellation Token funciona

O CancellationToken funciona criando uma CancellationTokenSource, que gera um token a ser passado para tarefas assíncronas. Quando necessário cancelar, chama-se o método Cancel() na fonte, que notifica todas as tarefas associadas para interromper o processamento. Um exemplo de uso inclui interromper uma tarefa caso ela demore mais do que um tempo limite, como 10 segundos.

## Fonte
- https://dev.to/angelobelchior/asyncawait-para-que-serve-o-cancellationtoken-nm7