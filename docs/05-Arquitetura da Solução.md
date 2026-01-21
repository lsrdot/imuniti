# Arquitetura da Solução

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

<figure> 
  <img src="/docs/img/Diagrama de classes_v3.png">
</figure>

## Modelo ER (Projeto Conceitual)

<figure> 
  <img src="/docs/img/MER_v3.png">
</figure>

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
 
<figure> 
  <img src="/docs/img/Base de Dados.png">
</figure>


## Tecnologias Utilizadas

Para o desenvolvimento do Imuniti, foram utilizadas diversas tecnologias para atender às necessidades do projeto. Abaixo, listamos as principais ferramentas, linguagens e serviços que contribuíram para a implementação da solução:

Linguagens: C#, HTML, CSS, JavaScript.

Frameworks e Bibliotecas: ASP.NET Core, Bootstrap, Entity Framework.

Banco de Dados: SQL Server no Azure.

Serviços Web: Azure App Service, Azure SQL Database.

Ferramentas de Desenvolvimento: Visual Studio, SQL Server Management Studio.

Ferramentas de Design e Modelagem: Figma, CorelDRAW, Canva, Astah, LucidChart, Draw.io.

Controle de Versão: Git e GitHub.

Essas tecnologias trabalham de forma integrada para oferecer uma solução robusta, garantindo o armazenamento seguro dos dados, um front-end responsivo e dinâmico, e um back-end eficiente para o processamento de informações.

### Interação do Usuário com o Sistema e Relação entre Tecnologias

As tecnologias utilizadas se relacionam de maneira integrada para oferecer uma experiência eficiente ao usuário. O fluxo de interação do usuário com o sistema pode ser descrito da seguinte forma:

Interação do Usuário com o Front-End
O usuário acessa o sistema por meio de uma interface web desenvolvida em HTML, CSS, Bootstrap e JavaScript. Esses elementos garantem uma navegação amigável, com design responsivo e interativo.

Requisições para o Back-End
As ações realizadas pelo usuário, como login, cadastro de membros ou atualização de dados, são enviadas para o servidor por meio de requisições HTTP, gerenciadas pelo ASP.NET Core. O framework processa essas requisições utilizando lógica implementada em C#.

Processamento no Servidor e Banco de Dados
No servidor, o Entity Framework facilita a comunicação com o SQL Server, onde os dados são armazenados e consultados. O Azure SQL Database, integrado ao sistema, garante o armazenamento centralizado e seguro das informações.

Resposta ao Usuário
Após o processamento, o servidor envia uma resposta ao front-end, que exibe os resultados para o usuário. Isso pode incluir mensagens de sucesso, visualização de dados atualizados ou feedback sobre erros.

Gestão e Implantação
O sistema é hospedado no Azure App Service, que possibilita a execução das aplicações web. O gerenciamento do código é feito por meio do Visual Studio e GitHub, com controle de versão e colaboração entre a equipe.

Planejamento e Design
Durante o desenvolvimento, ferramentas como Figma, CorelDRAW, Canva, Astah, LucidChart e Draw.io foram utilizadas para criar protótipos, diagramas e representar visualmente a arquitetura do sistema.


## Hospedagem

O sistema foi hospedado na Microsoft Azure, garantindo segurança, escalabilidade e alta disponibilidade. Utilizamos o Azure App Service para disponibilizar o sistema de forma acessível via navegador, sem necessidade de instalações locais. A hospedagem também oferece ferramentas de monitoramento e logs, permitindo a análise de desempenho e identificação de falhas, assegurando a confiabilidade do sistema.

https://app-imuniti-main-cjbfczh7d9ahf7h0.brazilsouth-01.azurewebsites.net/
