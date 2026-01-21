# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Segue apresentação os cenários de testes utilizados na realização dos testes da sua aplicação. Os cenários demonstram os requisitos sendo satisfeitos.

 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir que o usuário faça o autocadastro e gerencie seus dados. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://imuniti... - Clicar em "Crie sua conta" <br> - Preencher os campos obrigatórios (e-mail, senha, confirmação de senha) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-002	- A aplicação deve permitir que o usuário faça login utilizando suas credenciais cadastradas. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://imuniti... - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Entrar" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Criar e gerenciar membros	|
|Requisito Associado | RF-003	- A aplicação deve permitir que o usuário crie e gerencie membros. |
| Objetivo do Teste 	| Verificar se o usuário consegue criar e gerenciar membros. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://imuniti... - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Entrar" <br> - Clicar em "Cadastrar membro" <br> - Preencher os campos obrigatórios (Apelido, nome completo, Data de nascimento, CPF, CNS) <br> - Clicar em "Cadastrar membro" - <br> - Clicar em "Selecionar membro"  |
|Critério de Êxito | - Novo membro cadastrado com sucesso e visualização do novo membro |
|  	|  	|
| Caso de Teste 	| CT-04 – Registrar, gerenciar, alterar e excluir registros de vacinas	|
|Requisito Associado | RF-004	- A aplicação deve permitir que o usuário registre e gerencie as vacinas tomadas, possibilitando a modificação ou exclusão dos registros, se necessário, e incluir detalhes como nome da vacina, data de aplicação, lote, validade, local, responsável pela aplicação e anotações importantes, como possíveis efeitos colaterais. |
| Objetivo do Teste 	| Verificar se o usuário consegue registra e gerenciar as vacinas além de alterar e excluir registros. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://imuniti... - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Entrar" <br> - Clicar em "Gerenciar Cadastro" <br> - Clicar em "Selecionar membro" <br> - Clicar em um card de vacina - <br> Inserir, editar ou excluir as informações dos campos: "Data de aplicação", "Nome do vacinador", "Lote", "Data de validade", "CNES" e "Observações" - Clicar em "Salvar" ou "Redefinir padrão"  |
|Critério de Êxito | - Informações registradas/excluídas/ alteradas com sucesso |
|  	|  	|
| Caso de Teste 	| CT-05 – Anexar vacinas adicionais	|
|Requisito Associado | RF-005	- A aplicação deve permitir que o usuário personalize a cardeneta de vacinação conforme necessidade específica, podendo anexar vacinas adicionais. |
| Objetivo do Teste 	| Verificar se o usuário consegue anexar vacinas adicionais. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://imuniti... - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Entrar" <br> - Clicar em "Selecionar membro" <br> - Clicar em "adicionar vacina complementar" <br> - Inserir os dados:  "Data de aplicação", "Nome do vacinador", "Lote", "Data de validade", "CNES" e "Observações" - Clicar em "Salvar"  |
|Critério de Êxito | <br> - Novo vacina anexada com sucesso |
|  	|  	|
| Caso de Teste 	| CT-06 – Busca de	Unidade Básica de Saúde (UBS) mais próxima |
|Requisito Associado | RF-006	- A aplicação deve permitir que o usuário localize a Unidade Básica de Saúde (UBS) mais próxima, com base em sua localização atual ou endereço informado, exibindo detalhes como nome, endereço. |
| Objetivo do Teste 	| Verificar se o usuário consegue localizar a UBS mais próxima. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://imuniti... - Clicar no mapa ao final da tela <br> - Permitir uso de localização <br> - Localizar UBS mais próxima do endereço informado <br> |
|Critério de Êxito | - UBS mais próximas localizadas |
|  	|  	|
| Caso de Teste 	| CT-07 – Imprimir caderneta de vacinação em formato PDF	|
|Requisito Associado | RF-007	- A aplicação deve permitir que o usuário faça a impressão da caderneta de vacinação no formato PDF. |
| Objetivo do Teste 	| Verificar se o usuário consegue imprimir caderneta de vacinação em formato PDF. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://imuniti... - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Entrar" <br> - Clicar em "Selecionar membro" <br> - Selecionar membro desejado <br> - Clicar em "Imprimir caderneta" - <br> |
|Critério de Êxito | - abrirá um PDF permitindo Imprimir/salvar caderneta |
|  	|  	|
| Caso de Teste 	| CT-08 – Visualizar calendário vacinal	|
|Requisito Associado | RF-008	- A aplicação deve permitir que o usuário visualize o calendário vacinal com base na idade e histórico de vacinas. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar o calendário vacinal. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://imuniti... - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Entrar" <br> - Clicar em "Selecionar membro" <br> - Selecionar membro desejado <br> - Visualizar calendário vacinal  |
|Critério de Êxito | - Tela mostrando o calendário vacinal |
|  	|  	|
| Caso de Teste 	| CT-09 – Recuperar Senha	|
|Requisito Associado | RF-009	- A aplicação deve permitir que o usuário consiga recuperar sua senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue criar e gerenciar perfis. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://imuniti... - Clicar no botão "Entrar" <br> - Clicar no botão "Esqueceu sua senha? Clique aqui" <br> - Preencher o campo do e-mail <br> - Clicar em "Recuperar Senha" <br> - Inserir nova senha nos campos "Informe sua nova senha" e "Confirme sua nova senha" <br> - Clicar em "Salvar nova senha"  |
|Critério de Êxito | - Nova senha cadastrada com sucesso |
|  	|  	|
| Caso de Teste 	| CT-10 – Exibir situações das vacinas através de tags coloridas	|
|Requisito Associado | RF-010	- A aplicação deve exibir de forma dinâmica a situação das vacinas: verde para aplicada, amarelo para próxima do prazo, vermelho as atrasadas e cinza para futuras. |
| Objetivo do Teste 	| Verificar se as tags coloridas indicam o status das vacinas|
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://imuniti... - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Entrar" <br> - Clicar em "Selecionar membro" <br> - Clicar no membro desejado <br> - Visualizar caderneta, e observar se as tags (verde para aplicada, amarelo para próxima do prazo, vermelho as atrasadas e cinza para futuras) estão condizentes |
|Critério de Êxito | - Usuário consegue visualizar os status das vacinas corretamente, através de tags coloridas |
|  	|  	|
