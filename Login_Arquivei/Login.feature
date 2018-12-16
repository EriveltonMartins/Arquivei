#language: pt

Funcionalidade: Login
	Sendo: usuário do Arquivei
	Desejo acessar o sistema Arquivei com meu Usuário/Login e senha
	Para obter acesso ao Arquivei e suas funcionalidades
	

Esquema do Cenario: 01 Login efetuado com sucesso
	Dado que o Usuário esteja na pagina de login do Arquivei
	Quando digitar o usuário "<Usuario>" e senha "<Senha>"
	E tenha clicado no botão Entrar
	Então o Usuário estiver na home
	Exemplos: 
		| Usuario						| Senha	   |
		| erivelton_martins@hotmail.com | mudar123 |


Esquema do Cenario: 02 Falha ao efetuar o login
	Dado que o Usuário esteja na pagina de login do Arquivei
	Quando digitar o usuário "<Usuario>" e senha "<Senha>"
	E tenha clicado no botão Entrar
	Então é exibida uma mensagem de erro, informando que suas credenciais estão inválidas
	Exemplos: 
		| Usuario						| Senha	   |
		| erivelton_martins@hotmail.com | mudar123 |