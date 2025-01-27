# Conceitos - Async/ Await

Em C#, as palavras-chave **`async`** e **`await`** s�o usadas para escrever c�digo ass�ncrono, ou seja, c�digo que pode ser executado de forma que n�o pare as outras opera��es, permitindo que a aplica��o continue funcionando enquanto espera por execu��es demoradas, como requisi��es, acesso a banco de dados leituras de arquivos grandes etc.

## Async

A palavra-chave `async` � usada para marcar um m�todo como ass�ncrono. Isso permite que o m�todo contenha opera��es ass�ncronas que usam a palavra-chave `await`.

- Um m�todo marcado como `async`:
    - Deve retornar um dos seguintes tipos:
        - `Task`: usado para m�todos que n�o retornam valor.
        - `Task<T>`: usado para m�todos que retornam um valor do tipo `T`.
        - `void`: usado em eventos ass�ncronos, mas � geralmente desencorajado para outros m�todos.

## Await

A palavra-chave `await` � usada para pausar/esperar a execu��o de um m�todo ass�ncrono at� que a tarefa que est� sendo aguardada seja conclu�da. Durante essa pausa, o controle � liberado para que o thread atual possa executar outras tarefas.