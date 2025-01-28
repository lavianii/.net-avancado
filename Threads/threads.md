# O que é uma Thread?
Uma thread (ou "linha de execução") é a menor unidade de processamento que pode ser gerenciada pelo sistema operacional. Uma thread representa uma sequência única de instruções que podem ser executadas independentemente em um programa.

## Diferença entre Processos e Threads
Um processo é uma instância de um programa em execução, com seu próprio espaço de memória.
Uma thread é um fluxo de execução dentro de um processo. Todas as threads de um processo compartilham o mesmo espaço de memória e recursos.
### Exemplo simples:
Se você abrir o navegador, ele será um processo. Quando o navegador carrega várias abas, cada aba pode ser executada em uma thread separada (ou mesmo em um processo, dependendo da arquitetura do navegador).

### Características de uma Thread
#### Compartilhamento de Recursos:
Todas as threads dentro de um mesmo processo compartilham o espaço de memória (heap, variáveis globais) e os recursos (arquivos abertos, conexões de rede, etc.) do processo pai.

##### Independência:
Cada thread tem sua própria pilha (stack) e contador de programa (que rastreia as próximas instruções a serem executadas). Isso permite que elas executem tarefas de forma independente.

#### Leveza:
Criar e alternar entre threads geralmente consome menos recursos do que fazer o mesmo com processos, pois threads compartilham o mesmo espaço de memória.

### Benefícios do Uso de Threads
- Paralelismo:
Threads permitem que diferentes partes de um programa sejam executadas simultaneamente, aproveitando múltiplos núcleos de um processador.

- Desempenho:
Em programas que precisam realizar várias tarefas, como leitura/escrita de arquivos, conexões de rede ou cálculos intensos, as threads permitem que essas tarefas sejam executadas de forma mais eficiente.

- Responsividade:
Em aplicativos com interface gráfica, o uso de threads pode manter a interface responsiva enquanto outras tarefas mais pesadas são realizadas em segundo plano.

### Fontes
- https://learn.microsoft.com/pt-br/dotnet/standard/threading/using-threads-and-threading
- https://www.devmedia.com.br/programacao-assincrona-multithreading-em-net-com-csharp/23357
- https://pt.wikipedia.org/wiki/Thread_%28computa%C3%A7%C3%A3o%29
- https://macoratti.net/10/09/c_thd1.htm