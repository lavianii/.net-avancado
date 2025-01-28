# Paralelismo x Concorrência

## Concorrência

Consegue executar várias tarefas ao mesmo tempo, mas não são executadas simultaneamente. A concorrência faz trocas de tarefas rapidamente dando a impressão que são executadas ao mesmo tempo.  Um exemplo para isso é o SO, pois troca o tempo de CPU entre diversos programas, dando a impressão que todos estão sendo executados ao mesmo tempo, mas a CPU só é muito rápida em trocar os processamentos.

## Paralelismo

Consegue executar várias tarefas ao mesmo tempo, isso requer múltiplos núcleos de CPU, onde cada núcleo processa uma tarefa individualmente, sem precisar passar a vez do processamento.

### Imagem representando os processos de Concorrência e Paralelismo 
![image.png](https://media2.dev.to/dynamic/image/width=800%2Cheight=%2Cfit=scale-down%2Cgravity=auto%2Cformat=auto/https%3A%2F%2Fdev-to-uploads.s3.amazonaws.com%2Fuploads%2Farticles%2Fliy4nb34fxlz22pucrf9.png)

## Fontes
- https://learn.microsoft.com/pt-br/dotnet/standard/parallel-programming/
- https://dev.to/hugaomarques/paralelismo-e-concorrencia-101-2pgc