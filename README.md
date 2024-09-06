# Locadora De Veiculos 2024

<div style="display: flex; justify-content: center; align-items: center; gap: 15px;">
	<img width="80" src="https://user-images.githubusercontent.com/25181517/121405754-b4f48f80-c95d-11eb-8893-fc325bde617f.png">
	<img width="80" src="https://learn.microsoft.com/pt-br/ef/core/what-is-new/ef-core-8.0/ef8.png">
	<img width="80" src="https://user-images.githubusercontent.com/25181517/184103699-d1b83c07-2d83-4d99-9a1e-83bd89e08117.png">

</div>


## Projeto
Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2024

### Stack:
- NET 8.0
- ASP.NET MVC
- Microsoft SQL Server
- Entity Framework Core
- AutoMapper
- FluentResults
- Selenium

### Inclui:
- Testes de Unidade
- Testes de Integra��o
- Testes e2e
---

## Detalhes

O sistema visa facilitar o gerenciamento das opera��es de uma locadora de autom�veis,
abrangendo desde o cadastro de funcion�rios, grupos de autom�veis, ve�culos e clientes at� a
configura��o de pre�os de alugu�is e devolu��es.

O sistema permitir� a cria��o de usu�rios para empresas que desejam utilizar a plataforma para
gerenciar o aluguel de seus ve�culos. Usu�rios administradores dessas empresas ter�o a
capacidade de cadastrar e gerenciar seus funcion�rios, incluindo a ativa��o e desativa��o de
contas de usu�rio. Esses funcion�rios realizar�o tarefas operacionais, como o cadastro de ve�culos,
registro de loca��es, entre outras atividades relacionadas.

Al�m disso, o sistema calcula o valor dos alugu�is considerando diversos fatores, como tipo do
ve�culo, plano escolhido e taxas adicionais.

A locadora oferecer� uma lista de taxas e servi�os que os clientes poder�o adicionar aos alugu�is.
Cada taxa ou servi�o ter� um pre�o e indica��o se � fixo ou calculado por dia, afetando o pre�o
total do aluguel.

Ser� poss�vel registrar a devolu��o dos ve�culos, aplicando multas em caso de atraso. O sistema
tamb�m permitir� configurar o pre�o do combust�vel para inclus�o no c�lculo dos alugu�is.

O objetivo � proporcionar uma gest�o eficiente e uma experi�ncia positiva tanto para os
funcion�rios quanto para os clientes da locadora.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
---
## Como Usar

#### Clone o Reposit�rio
```
git clone https://github.com/academia-do-programador/locadora-de-veiculos-2024.git
```

#### Navegue at� a pasta raiz da solu��o
```
cd locadora-de-veiculos-2024
```

#### Restaure as depend�ncias
```
dotnet restore
```

#### Navegue at� a pasta do projeto
```
cd LocadoraDeVeiculos.WebApp
```

#### Execute o projeto
```
dotnet run
```****
