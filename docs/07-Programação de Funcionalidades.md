# Programação de Funcionalidades

| ID     | Descrição do Requisito                                                                                                            | Artefatos produzidos | Aluno(a) responsável |
|--------|-----------------------------------------------------------------------------------------------------------------------------------|----------------------|----------------------|
| RF-001 | A aplicação deve permitir que o usuário faça o auto cadastro e gerencie seus dados, incluindo informações básicas como e-mail e senha. |AccountController.cs, RegisterViewModel.cs, VerifyEmailViewModel.cs, VerifyEmailViewModel.cs, EditUserViewModel.cs, Register.cshtml, EditUser.cshtml |Felipe e Lucas|
| RF-002 | A aplicação deve permitir que o usuário faça login utilizando suas credenciais cadastradas. |AccountController.cs e HomeController.cs, LoginViewModel.cs, VerifyEmailViewModel.cs, Login.cshtml, Index.cshtml, Privacy.cshtml |Felipe e Lucas|
| RF-003 | A aplicação deve permitir que o usuário crie e gerencie perfis de outros familiares. |MembrosController.cs, AddMembrosViewModel, Add.cshtml, Edit.cshtml, List.cshtml |Alberto e Carolina|
| RF-004 | A aplicação deve permitir que o usuário registre e gerencie as vacinas tomadas, possibilitando a modificação ou exclusão dos registros, se necessário, e incluir detalhes como nome da vacina, data de aplicação, lote, validade, local, responsável pela aplicação e anotações importantes, como possíveis efeitos colaterais. |Caderneta.cs, DetalhesVacina.cs, StausVacina.cs, Vacina.cs, CadernetasController.cs, Details.cshtml |Gilson e Ryan|
| RF-005 | A aplicação deve permitir que o usuário personalize a caderneta de vacinação conforme necessidade específica, podendo anexar vacinas adicionais. |Caderneta.cs, DetalhesVacina.cs, Vacina.cs, CadernetasController.cs, Details.cshtml |Gilson e Ryan|
| RF-006 | A aplicação deve permitir que o usuário localize a Unidade Básica de Saúde (UBS) mais próxima, com base em sua localização atual ou endereço informado, exibindo detalhes como nome, endereço.  |map.js, markers.js, Index.cshtml |Lucas|
| RF-007 | A aplicação deve permitir que o usuário faça a impressão da caderneta de vacinação no formato PDF. |CadernetasController.cs, Details.cshtml |Gilson e Ryan|
| RF-008 | A aplicação deve permitir que o usuário visualize o calendário vacinal com base na idade e histórico de vacinas. |Caderneta.cs, DetalhesVacina.cs, Vacina.cs, CadernetasController.cs, Details.cshtml |Gilson e Ryan|
| RF-009 | A aplicação deve permitir que o usuário consiga recuperar sua senha. |AccountController.cs, ChangePasswordViewModel.cs, ChangePassword.cshtml|Felipe e Lucas|
| RF-010 | A aplicação deve exibir de forma dinâmica a situação das vacinas: verde para aplicada, amarelo para próxima do prazo, vermelho as atrasadas e cinza para futuras. |Caderneta.cs, DetalhesVacina.cs, StausVacina.cs, Vacina.cs, CadernetasController.cs, Details.cshtml |Gilson e Ryan|

# Instruções de acesso

### URL de acesso

Link: https://app-imuniti-main-cjbfczh7d9ahf7h0.brazilsouth-01.azurewebsites.net/

### Usuario de teste

Email: teste@teste.com
Senha: 12345678
