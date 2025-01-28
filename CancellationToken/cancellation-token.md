## O que � o Cancellation Token?
O CancellationToken � uma estrutura do namespace System.Threading usada para notificar tarefas ass�ncronas ou paralelas a interromperem sua execu��o. Ele � �til em cen�rios de timeout, onde uma opera��o � for�ada a parar caso ultrapasse o tempo limite, e tamb�m em processos de I/O, como consultas a banco de dados ou comunica��o de rede, que podem ser demorados. Ele permite gerenciar interrup��es de forma eficiente e controlada em opera��es longas.

## Como o Cancellation Token funciona

O CancellationToken funciona criando uma CancellationTokenSource, que gera um token a ser passado para tarefas ass�ncronas. Quando necess�rio cancelar, chama-se o m�todo Cancel() na fonte, que notifica todas as tarefas associadas para interromper o processamento. Um exemplo de uso inclui interromper uma tarefa caso ela demore mais do que um tempo limite, como 10 segundos.

## Fonte
- https://dev.to/angelobelchior/asyncawait-para-que-serve-o-cancellationtoken-nm7