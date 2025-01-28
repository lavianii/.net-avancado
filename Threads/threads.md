# O que � uma Thread?
Uma thread (ou "linha de execu��o") � a menor unidade de processamento que pode ser gerenciada pelo sistema operacional. Uma thread representa uma sequ�ncia �nica de instru��es que podem ser executadas independentemente em um programa.

## Diferen�a entre Processos e Threads
Um processo � uma inst�ncia de um programa em execu��o, com seu pr�prio espa�o de mem�ria.
Uma thread � um fluxo de execu��o dentro de um processo. Todas as threads de um processo compartilham o mesmo espa�o de mem�ria e recursos.
### Exemplo simples:
Se voc� abrir o navegador, ele ser� um processo. Quando o navegador carrega v�rias abas, cada aba pode ser executada em uma thread separada (ou mesmo em um processo, dependendo da arquitetura do navegador).

### Caracter�sticas de uma Thread
#### Compartilhamento de Recursos:
Todas as threads dentro de um mesmo processo compartilham o espa�o de mem�ria (heap, vari�veis globais) e os recursos (arquivos abertos, conex�es de rede, etc.) do processo pai.

##### Independ�ncia:
Cada thread tem sua pr�pria pilha (stack) e contador de programa (que rastreia as pr�ximas instru��es a serem executadas). Isso permite que elas executem tarefas de forma independente.

#### Leveza:
Criar e alternar entre threads geralmente consome menos recursos do que fazer o mesmo com processos, pois threads compartilham o mesmo espa�o de mem�ria.

### Benef�cios do Uso de Threads
- Paralelismo:
Threads permitem que diferentes partes de um programa sejam executadas simultaneamente, aproveitando m�ltiplos n�cleos de um processador.

- Desempenho:
Em programas que precisam realizar v�rias tarefas, como leitura/escrita de arquivos, conex�es de rede ou c�lculos intensos, as threads permitem que essas tarefas sejam executadas de forma mais eficiente.

- Responsividade:
Em aplicativos com interface gr�fica, o uso de threads pode manter a interface responsiva enquanto outras tarefas mais pesadas s�o realizadas em segundo plano.

### Fontes
- https://learn.microsoft.com/pt-br/dotnet/standard/threading/using-threads-and-threading
- https://www.devmedia.com.br/programacao-assincrona-multithreading-em-net-com-csharp/23357
- https://pt.wikipedia.org/wiki/Thread_%28computa%C3%A7%C3%A3o%29
- https://macoratti.net/10/09/c_thd1.htm