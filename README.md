# MRP-FATEC-GUARULHOS ⛏

MRP (Manufacturing Resource Planning) da honrada montadora Saco de Carvão Computadores. Desenvolvido pela primeira turma ADS da FATEC Guarulhos.

O programa criado no windows forms, em C#, é responsável por cadastrar e controlar o estoque de componentes e produtos finalizados em um banco de dados MySql.

## Como baixar o projeto
Se você faz parte do 4° semestre de ADS, tem duas coisas que mudaram entre o segundo e terceiro semestres que você deveria saber:

1. Depois das mudanças estruturais feitas pelo professor [Alécio](https://github.com/aleciogodoi), o MRP já está com o backend todo planejado e a um passo de se tornar funcional.

2. Ficou ainda mais difícil contribuir com o projeto...

Não que esteja difícil de entender o código, só tá difícil dar o primeiro passo e configurar todas as tecnologias que estão sendo usadas, então vamo devagar...

### Git
1. Baixe e instale o [Git](https://git-scm.com/downloads) no seu computador.

2. [Configure o Git](https://git-scm.com/book/pt-br/v2/Come%C3%A7ando-Configura%C3%A7%C3%A3o-Inicial-do-Git) com o nome de usuário que quiser e o email que você usou pra se cadastrar no gitHub.

### mySql
1. Baixe o [MySQL Workbench](https://dev.mysql.com/downloads/workbench/), instale o programa e [configure um servidor](https://www.alura.com.br/artigos/mysql-do-download-e-instalacao-ate-sua-primeira-tabela).

2. Baixe e instale o [conector MySQL/.NET](https://dev.mysql.com/downloads/connector/net/).

3. Abra uma conexão no Workbench e cole o conteúdo do [sql que o alécio criou](https://github.com/MRP-FATEC-GUARULHOS-ADS/MRP-FATEC-GUARULHOS/blob/main/MRP-SacoCarvao/MRP-SacoCarvao/Banco%20de%20Dados/Script%20Banco%20MRP.sql) dentro da janela de queries da sua conexão, então execute a query com o botão mostrado na imagem abaixo.

![executando queries mysql](/img/mysql.png)

### Visual Studio
1. Baixe e instale o [Visual Studio Enterprise 2019](https://azureforeducation.microsoft.com/devtools) usando o seu email institucional.

2. Abra o Visual Studio, escolha a opção clonar um repositório.

![abrindo o VS](/img/vs-git1.jpg)

3. Digite o endereço do projeto na caixa de Local do repositório, escolha a pasta onde o repositório será criado e clique em Clonar.

```
https://github.com/MRP-FATEC-GUARULHOS-ADS/MRP-FATEC-GUARULHOS.git
```

![clonando o repositório](/img/vs-git2.png)

4. Depois de abrir a solução, veja se alguma referência do projeto não foi carregada corretamente (se tiver um símbolo amarelo do lado do nome da referência, ela teve algum problema ao ser carregada).

![erro carregando referências](/img/vs-git6.png)

5. Caso isso aconteça, tente remover a referência e readiciona-la em `Projeto > Adicionar Referência...`, se o problema for no Conector MySql tente instalar a [versão 8.0.21](https://downloads.mysql.com/archives/c-net/), ou então *dá teu jeito cara, sei lá*.

![adicionando referências](/img/vs-gitrefs.png)

Pronto, você já tem acesso ao projeto que a gente tá usando, tomara.

## Mantendo o projeto atualizado
Agora toda vez que editar alguma coisa você deve se certificar que ele esteja atualizado. Pra isso, cheque sempre no canto inferior direito do programa, uma setinha pra cima ↑ (Push) indica que tem mudanças que você fez e ainda não compartilhou, enquanto uma setinha pra baixo ↓ (Pull) indica que tem mudanças online que você ainda não baixou, tenha certeza de sempre estar atualizado (setinha pra cima do lado de um número 0) e na *branch* certa do projeto.

![Team-explorer](/img/vs-git3.jpg)

## Branch certa do projeto???
Se tudo deu certo esse repositório tem 5 *branches*, uma principal e uma pra cada módulo. *Branchs* são versões paralelas do mesmo repositório, que a gente tá usando pra evitar conflito entre contribuições. Se quiser mudar pra *branch* do seu módulo é só escolher no canto inferior direito do Visual Studio, ou só esquece o que eu disse e deixa no `main` mesmo, o importante é contribuir.

## Contribuindo com o projeto
1. Faça as alterações que quiser no projeto e depois abra a aba 'Team Explorer' em `Exibir > Team Explorer`, ou clique no lápis no canto inferior direito do programa, a tela de alterações será aberta, como na imagem abaixo.

2. Digite uma mensagem que expresse suas mudanças de forma clara

3. Clique no '+' e confirme tudo, ou escolha os arquivos ou pastas que quer adicionar e inclua-os separadamente (clicando com o direito no item e escolhendo `Preparar`).

Incluir no commit só os arquivos que você alterou diminui a chance de criar conflitos no Git e te torna uma pessoa melhor, mas tenha certeza de incluir todos os arquivos que você alterou.

![commit](/img/vs-git4.jpg)

4. Clique na seta do canto inferior direito e na aba que se abrir clique em 'Enviar por push'.

![push](/img/vs-git5.jpg)

Pronto, mudança feita, espero que tenha valido a pena.

![dica](/img/dica.png)

## Coisas a fazer

- Banco de dados
    - Subir o banco no Azure (?)
    - Usar o banco entre módulos
    - Proteger as strings de acesso ao banco de dados
- Interface
    - agora tem q fazer as caixinhas de texto e oscaraio
    - tooltips com o modo certo de preenchimento das caixas de texto
    - página de 'ajuda'
    - página de 'sobre'
- Tratamento de erros
    - garantir que os campos sejam preenchidos da forma certa
    - imprimir os catchs no console pelo menos
- Padronização
    - nomenclatura das variáveis e elementos do layout
    - comentários
    - aparência uniforme da interface

- Documentação dos módulos
    - Diagrama de Caso de Uso
    - Fluxograma
    - Diagrama de Classes
- Documentação do MRP
    - Diagrama de Caso de Uso
    - Fluxograma
    - Diagrama de Classes
    
- Módulo de Compras
    - usar o id do fornecedor pra registrar compras
    - poder editar o tipo de movimentação
    - registrar qual usuário fez cada registro

![Saco de carvão](/img/logo.png)
