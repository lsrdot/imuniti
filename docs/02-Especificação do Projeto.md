# Especificações do Projeto

A definição do problema e os pontos relevantes deste projeto foram consolidados a partir de uma imersão da equipe em
situações reais, observadas em unidades básicas de saúde e complementadas por pesquisas. Durante esse processo, foram
levantados dados importantes sobre os usuários-alvo da aplicação de caderneta de vacinação, apresentados na forma de
personas e histórias de usuários documentadas neste projeto.

## Personas

As personas são representações fictícias dos usuários ideais da aplicação, criadas com base em pesquisas e dados reais.
Elas ajudam a guiar o desenvolvimento de funcionalidades e interfaces, garantindo que as necessidades, dores e
expectativas dos usuários sejam atendidas de maneira eficaz. No caso desta aplicação de gerenciamento de vacinas, as
personas permitem que a equipe de desenvolvimento foque na criação de uma experiência que seja intuitiva e útil para
diferentes perfis de usuários, como mães, cuidadores e idosos.

### Persona 1: Maria Gonzaga

<figure> 
  <img src="/docs/img/MariaGonzaga.jpg">
</figure>

## Persona 2: João Antônio

<figure> 
  <img src="/docs/img/JoãoAntônio.jpg">
</figure>

## Persona 3: Rodrigo Menezes

<figure> 
  <img src="/docs/img/RodrigoMenezes.jpg">
</figure>

## Persona 4: Clara Barboza

<figure> 
  <img src="/docs/img/ClaraBarboza.jpg">
</figure>

## Persona 5: Beatriz Oliveira

<figure> 
  <img src="/docs/img/BeatrizOliveira.jpg">
</figure>

## Histórias de Usuários

Com base na análise das personas foram identificadas as seguintes histórias de usuários:

| EU COMO... `PERSONA` | QUERO/PRECISO ... `FUNCIONALIDADE`                                                       | PARA ... `MOTIVO/VALOR`                                                                                                                        |
|----------------------|------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------|
| Maria Gonzaga        | Acompanhar as vacinas dos meus filhos sem me preocupar em lembrar de todas as datas      | Não esquecer nenhuma vacina importante, mesmo com a rotina corrida.                                                                            |
| Maria Gonzaga        | Receber lembretes claros e diretos sobre as vacinas                                      | Garantir que meus filhos fiquem protegidos, sem o risco de atrasos.                                                                            |
| João Antônio         | Manter todas as vacinas dos meus pais organizadas em um único lugar                      | Não ter que me preocupar com o controle das vacinas, especialmente em momentos de saúde frágil.                                                |
| João Antônio         | Saber rapidamente se meus pais estão com as vacinas em dia                               | Sentir que estou cuidando bem deles, sem o risco de perder prazos importantes.                                                                 |
| Rodrigo Menezes      | Ter tudo sobre minhas vacinas à mão, de maneira personalizada                            | Garantir que minhas vacinas estejam todas registradas, de acordo com o que eu realmente preciso.                                               |
| Rodrigo Menezes      | Ajustar e atualizar meu histórico de vacinas quando necessário                           | Manter meu controle sempre certo e alinhado com minha realidade.                                                                               |
| Clara Barboza        | Ter uma visão clara das vacinas necessárias para mim e meu bebê                          | Sentir que estou protegendo a saúde do meu bebê, seguindo todas as recomendações.                                                              |
| Clara Barboza        | Anotar qualquer detalhe importante sobre as vacinas que tomo                             | Acompanhar como cada vacina me afeta, especialmente durante a gravidez.                                                                        |
| Beatriz Oliveira     | Usar uma aplicação acessível para gerenciar minhas vacinas sem dificuldades de navegação | Garantir que, apesar da minha mobilidade reduzida, eu consiga manter meu histórico de vacinação atualizado e organizado de forma independente. |
| Beatriz Oliveira     | Receber lembretes automáticos de vacinas                                                 | Não precisar me preocupar com o acompanhamento constante das datas, facilitando a gestão da minha saúde.                                       |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID     | Descrição do Requisito                                                                                                                                                                                                                                                                                                          | Prioridade |
|--------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RF-001 | A aplicação deve permitir que o usuário faça o auto cadastro e gerencie seus dados, incluindo informações básicas como e-mail e senha.                                                                                                                                                                                          | ALTA       | 
| RF-002 | A aplicação deve permitir que o usuário faça login utilizando suas credenciais cadastradas.                                                                                                                                                                                                                                     | ALTA       |
| RF-003 | A aplicação deve permitir que o usuário crie e gerencie perfis de outros familiares.                                                                                                                                                                                                                                            | ALTA       |
| RF-004 | A aplicação deve permitir que o usuário registre e gerencie as vacinas tomadas, possibilitando a modificação ou exclusão dos registros, se necessário, e incluir detalhes como nome da vacina, data de aplicação, lote, validade, local, responsável pela aplicação e anotações importantes, como possíveis efeitos colaterais. | ALTA       |
| RF-005 | A aplicação deve permitir que o usuário personalize a caderneta de vacinação conforme necessidade específica, podendo anexar vacinas adicionais.                                                                                                                                                                                | ALTA       |
| RF-006 | A aplicação deve permitir que o usuário localize a Unidade Básica de Saúde (UBS) mais próxima, com base em sua localização atual ou endereço informado, exibindo detalhes como nome, endereço.                                                                                                                                  | MÉDIA      |
| RF-007 | A aplicação deve permitir que o usuário faça a impressão da caderneta de vacinação no formato PDF.                                                                                                                                                                                                                              | MÉDIA      |
| RF-008 | A aplicação deve permitir que o usuário visualize o calendário vacinal com base na idade e histórico de vacinas.                                                                                                                                                                                                                | MÉDIA      |
| RF-009 | A aplicação deve permitir que o usuário consiga recuperar sua senha.                                                                                                                                                                                                                                                            | MÉDIA      |
| RF-010 | A aplicação deve exibir de forma dinâmica a situação das vacinas: verde para aplicada, amarelo para próxima do prazo, vermelho as atrasadas e cinza para futuras.                                                                                                                                                               | MÉDIA      |


### Requisitos não Funcionais

| ID      | Descrição do Requisito                                                                                                                                        | Prioridade |
|---------|---------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RNF-001 | A aplicação deve ser responsiva, garantindo uma visualização adequada em dispositivos de diferentes tamanhos e formatos.                                      | ALTA       | 
| RNF-002 | A aplicação deve ser projetada de forma a ser acessível nos principais navegadores, incluindo Google Chrome, Mozilla Firefox, Microsoft Edge, Opera e Safari. | ALTA       | 
| RNF-003 | A aplicação deve garantir segurança e privacidade das informações dos usuários.                                                                               | ALTA       | 
| RNF-004 | A aplicação deve ter seu back-end desenvolvido utilizando a linguagem de programação C#.                                                                      | ALTA       | 
| RNF-005 | A aplicação deve ter seu banco de dados implementado utilizando SQL Server.                                                                                   | ALTA       | 
| RNF-006 | A aplicação deve ter seu front-end desenvolvido utilizando HTML e CSS, sendo permitido o uso do framework Bootstrap.                                          | ALTA       | 
| RNF-007 | A aplicação deve apresentar mensagens de erro claras, oferecendo orientações para a correção dos problemas.                                                   | ALTA       | 
| RNF-008 | A aplicação deve ser publicada em um ambiente acessível publicamente na Internet.                                                                             | MEDIA      | 
| RNF-009 | A aplicação deve garantir um bom nível de contraste entre os elementos da tela.                                                                               | MEDIA      | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

| ID | Restrição                                                          |
|----|--------------------------------------------------------------------|
| 01 | O projeto deverá ser entregue até o final do semestre.             |
| 02 | O projeto deve incluir o desenvolvimento de um módulo de back-end. |
| 03 | A equipe não pode subcontratar o desenvolvimento do projeto.       |

## Diagrama de Casos de Uso

<figure> 
  <img src="/docs/img/Diagrama de Casos de Uso_v3.png">
</figure>
