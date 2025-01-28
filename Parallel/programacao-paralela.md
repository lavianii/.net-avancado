# Paralelismo x Concorr�ncia

## Concorr�ncia

Consegue executar v�rias tarefas ao mesmo tempo, mas n�o s�o executadas simultaneamente. A concorr�ncia faz trocas de tarefas rapidamente dando a impress�o que s�o executadas ao mesmo tempo.  Um exemplo para isso � o SO, pois troca o tempo de CPU entre diversos programas, dando a impress�o que todos est�o sendo executados ao mesmo tempo, mas a CPU s� � muito r�pida em trocar os processamentos.

## Paralelismo

Consegue executar v�rias tarefas ao mesmo tempo, isso requer m�ltiplos n�cleos de CPU, onde cada n�cleo processa uma tarefa individualmente, sem precisar passar a vez do processamento.

- Um m�todo marcado como `async`:
    - Deve retornar um dos seguintes tipos:
        - `Task`: usado para m�todos que n�o retornam valor.
        - `Task<T>`: usado para m�todos que retornam um valor do tipo `T`.
        - `void`: usado em eventos ass�ncronos, mas � geralmente desencorajado para outros m�todos.

### Imagem representando os processos de Concorr�ncia e Paralelismo 
![image.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a3d7a794-57b4-4d56-86db-ecde1b76df01/cbb34f8e-41b0-4c30-a66e-4d25b61d6012/image.png)

## Fontes
https://learn.microsoft.com/pt-br/dotnet/standard/parallel-programming/
https://dev.to/hugaomarques/paralelismo-e-concorrencia-101-2pgc