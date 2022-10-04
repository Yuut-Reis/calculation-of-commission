# Boas-vindas ao repositório do exercício Cálculo de Comissões.

Para realizar o projeto, atente-se a cada passo descrito a seguir, e se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-exercises-calculation-of-commission.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-exercises-calculation-of-commission`

  2. Instale as dependências

  - `dotnet restore`.
  
  1. Crie uma branch a partir da branch `master`

  - Verifique que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-csharp-0x-exercises-calculation-of-commission`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-csharp-0x-exercises-calculation-of-commission`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-exercises-calculation-of-commission/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/sd-0x-project-talker-manager/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se de sempre após um (ou alguns) `commits` atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-0x`.

  Caso tenha alguma dúvida, [aqui tem um video explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://course.betrybe.com/real-life-engineer/code-review/) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `main.yml`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências

  ### Executando todos os testes

  Para executar os testes com o .NET execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/PsefzL2e)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e compartilhar o seu aprendizado lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe esse projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos
A empresa _TryAuto_ revendedora de automóveis usados te contratou para desenvolver um sistema que lhe ajudasse a calcular o valor a ser pago aos seus colaboradores. Cada colaborador recebe um salário fixo por mês mais um valor para cada carro vendido e mais uma porcentagem do valor total das vendas efetuadas pelo colaborador.

O seu programa deve auxiliar a obter e apresentar o valor total a ser pago ao colaborador como seu salário final como a soma dos valores:
  - Salário fixo no mês.
  - Uma comissão de fixa de **`R$250,00`** para cada carro vendido.
  - **`3%`** do valor total das vendas realizadas.
  
  Após a implementação dos requisitos você pode executar o programa usando `dotnet run` na pasta `src/CommissionCalculation`. Lembre-se de ajustar o código encontrado no arquivo `src/CommissionCalculation/Program.cs`.
  
 >> **⚠️Importante⚠️:** Para cada requisito do README, você verá dois requisitos associados no avaliador. Isso acontece porque para avaliar os testes deste projeto, o avaliador irá realizar dois testes: um de sucesso e um de falha. Você deve desenvolver o requisito e o seu teste para ter a aprovação em ambos.

## 1 - Função `CalculateFinalSalary`
  
  _Crie a sua lógica na função `CalculateFinalSalary` encontrada no arquivo `src/CommissionCalculation/ComissionCalculator.cs`._

<details>
  <summary> Esta função deve retornar o valor a ser pago ao colaborador.</summary><br />

A função recebe os seguintes parâmetros:
- VALOR DO SALÁRIO FIXO -> fixedSalary
- QUANTIDADE DE CARROS VENDIDOS -> amountCarsSold
- VALOR TOTAL DE VENDAS -> totalSalesValue
  
Esta função deve preencher o atributo `FinalSalary` com o resultado dos cálculos definidos nos requisitos.

</details>

<details>
  <summary>Crie os testes para a função <code>CalculateFinalSalary</code></summary><br />

Implemente seu teste no arquivo `src/CommissionCalculation.Test/CommissionCalculation.Test.cs` na função `TestCalculateFinalSalary`.

O teste deve ser capaz de identificar se a função `CalculateFinalSalary` armazena corretamente os valores de:
  1. `FixedSalary`
  2. `AmountCarsSold`
  3. `TotalSalesValue`
  4. `FinalSalary`
</details>
  
## 2 - Função `ShowFinalSalary`

_Crie a sua lógica na função `ShowFinalSalary` encontrada no arquivo `src/CommissionCalculation/ComissionCalculator.cs`._
  
<details>
  <summary> Esta função deve mostrar na tela do console as seguintes informações.</summary><br />
  Faça com que sua função imprime no console da seguinte forma:

```
O colaborador <NOME_DO_COLABORADOR> neste mês de <NOME_DO_MES> obteve o salário final de R$<VALOR_SALARIO_FINAL> referente à: 
SALÁRIO FIXO: R$<VALOR_SALARIO_FIXO>
TOTAL DE CARROS VENDIDOS: <QUANTIDADE_DE_CARROS_VENDIDOS>
VALOR TOTAL DE VENDAS NO MÊS: R$<VALOR_TOTAL_DE_VENDAS> 
COMISSÃO POR CARROS VENDIDOS: R$<COMISSAO_POR_CARROS_VENDIDOS>
COMISSÃO DE 3% DO TOTAL DE VENDAS: R$<COMISSAO_POR_TOTAL_DE_VENDAS>
```

Substitua os seguintes valores:
 1. <NOME_DO_COLABORADOR>
 2. <NOME_DO_MES>
 3. <VALOR_SALARIO_FINAL>
 4. <VALOR_SALARIO_FIXO>
 5. <QUANTIDADE_DE_CARROS_VENDIDOS>
 6. <VALOR_TOTAL_DE_VENDAS>
 7. <COMISSAO_POR_CARROS_VENDIDOS>
 8. <COMISSAO_POR_TOTAL_DE_VENDAS>

Dica: Para os valores de `ponto flutuante` utilize 2 casa decimais.
</details>

<details>
  <summary>Crie os testes para a função <code>ShowFinalSalary</code></summary><br />

Implemente seu teste no arquivo `src/CommissionCalculation.Test/CommissionCalculation.Test.cs` na função `TestShowFinalSalary`.

O teste deve ser capaz de identificar se a função `ShowFinalSalary` imprime corretamente os valores no _console_ conforme as instruções descritas anteriormente.
</details>
