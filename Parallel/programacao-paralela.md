# Paralelismo x Concorrência

## Concorrência

Consegue executar várias tarefas ao mesmo tempo, mas não são executadas simultaneamente. A concorrência faz trocas de tarefas rapidamente dando a impressão que são executadas ao mesmo tempo.  Um exemplo para isso é o SO, pois troca o tempo de CPU entre diversos programas, dando a impressão que todos estão sendo executados ao mesmo tempo, mas a CPU só é muito rápida em trocar os processamentos.

## Paralelismo

Consegue executar várias tarefas ao mesmo tempo, isso requer múltiplos núcleos de CPU, onde cada núcleo processa uma tarefa individualmente, sem precisar passar a vez do processamento.

- Um método marcado como `async`:
    - Deve retornar um dos seguintes tipos:
        - `Task`: usado para métodos que não retornam valor.
        - `Task<T>`: usado para métodos que retornam um valor do tipo `T`.
        - `void`: usado em eventos assíncronos, mas é geralmente desencorajado para outros métodos.

### Imagem representando os processos de Concorrência e Paralelismo 
![image.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a3d7a794-57b4-4d56-86db-ecde1b76df01/cbb34f8e-41b0-4c30-a66e-4d25b61d6012/image.png)

## Fontes
https://learn.microsoft.com/pt-br/dotnet/standard/parallel-programming/
https://dev.to/hugaomarques/paralelismo-e-concorrencia-101-2pgc