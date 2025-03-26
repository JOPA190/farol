# Sistema de Controle de Semáforo

Este projeto implementa um sistema simples de controle de semáforo utilizando C# e Windows Forms. O sistema simula o funcionamento de um semáforo com as cores **Vermelho**, **Amarelo** e **Verde**, permitindo controlar a troca das cores manualmente ou automaticamente.

## Funcionalidades

### 1. **Controle Manual**
   O sistema permite controlar manualmente o semáforo clicando nos botões para cada cor:
   - **Vermelho**: Acende o sinal vermelho.
   - **Amarelo**: Acende o sinal amarelo.
   - **Verde**: Acende o sinal verde.

### 2. **Controle Automático**
   A função de automação simula a troca de sinais de forma sequencial e automática, com intervalos definidos para cada cor (Vermelho, Verde e Amarelo). O tempo de cada transição pode ser ajustado através do **nud_Tempo**.

### 3. **Controle Sequencial**
   O semáforo pode funcionar de forma sequencial, trocando de cor automaticamente a cada intervalo de tempo (10 segundos para Vermelho e Verde, e 3 segundos para Amarelo). O sistema continua funcionando até ser interrompido. 

   - **Parar**: A automação pode ser interrompida a qualquer momento clicando no botão **Stop**.

### 4. **Monitoramento de Tempo**
   O sistema utiliza a classe **Stopwatch** para medir o tempo gasto em cada transição de cor e exibir o tempo decorrido.

## Estrutura do Código

A aplicação é composta pela classe `Form1`, que controla as funcionalidades do semáforo, incluindo os métodos de controle manual e automático, e o controle sequencial com a implementação assíncrona.

### Principais Métodos:

- **btn_Vermelho_Click**: Acende o sinal vermelho e desliga os outros sinais.
- **btn_Amarelo_Click**: Acende o sinal amarelo e desliga os outros sinais.
- **btn_Verde_Click**: Acende o sinal verde e desliga os outros sinais.
- **btn_Automacao_Click**: Realiza a troca automática das cores do semáforo em sequência, controlando os tempos de cada cor.
- **btn_Stop_Click**: Interrompe a sequência de automação.
- **btn_Sequencial_Click_1**: Inicia o controle sequencial de cores do semáforo com tempos ajustáveis.

## Dependências

- **System.Diagnostics**: Para medição de tempo utilizando a classe `Stopwatch`.
- **System.Threading**: Para controle assíncrono e delay entre as trocas de cores.

## Instruções de Uso

1. **Controle Manual**: Clique nos botões "Vermelho", "Amarelo" e "Verde" para controlar o semáforo manualmente.
2. **Automação**: Clique no botão "Automação" para iniciar a troca automática das cores.
3. **Controle Sequencial**: Clique no botão "Sequencial" para iniciar a troca automática das cores em sequência.
4. **Parar**: Clique em "Stop" para interromper a automação.

## Considerações Finais

Este sistema simula o funcionamento básico de um semáforo e pode ser utilizado como um exemplo de automação com controle assíncrono em C#. Ele pode ser expandido para incluir mais funcionalidades, como ajustes no tempo de cada cor ou a inclusão de novos modos de controle.
