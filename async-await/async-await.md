# Conceitos - Async/ Await

Em C#, as palavras-chave **`async`** e **`await`** são usadas para escrever código assíncrono, ou seja, código que pode ser executado de forma que não pare as outras operações, permitindo que a aplicação continue funcionando enquanto espera por execuções demoradas, como requisições, acesso a banco de dados leituras de arquivos grandes etc.

## Async

A palavra-chave `async` é usada para marcar um método como assíncrono. Isso permite que o método contenha operações assíncronas que usam a palavra-chave `await`.

- Um método marcado como `async`:
    - Deve retornar um dos seguintes tipos:
        - `Task`: usado para métodos que não retornam valor.
        - `Task<T>`: usado para métodos que retornam um valor do tipo `T`.
        - `void`: usado em eventos assíncronos, mas é geralmente desencorajado para outros métodos.

## Await

A palavra-chave `await` é usada para pausar/esperar a execução de um método assíncrono até que a tarefa que está sendo aguardada seja concluída. Durante essa pausa, o controle é liberado para que o thread atual possa executar outras tarefas.