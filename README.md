<h1>Fundamentos do Entity Framework</h1>

> As aulas assistidas foram organizadas nos **commits**

<!--#region Sumário -->

<h2>Sumário</h2>

<!--#region Introdução -->

<details><summary>Introdução</summary>

<ul>
    <li><a href="#introducao">Introdução</a></li>
    <li><a href="#ferramentas">Ferramentas</a></li>
    <li><a href="#orm">ORM</a></li>
    <li><a href="#ef">Entity Framework</a></li>
    <li><a href="#code-database-first">Code First ou Database First</a></li>
    <li><a href="#datacontext">DataContext</a></li>
    <li><a href="#restaurando-banco">Restaurando o banco</a></li>
    <li><a href="#criando-modelos">Criando os Modelos</a></li>
    <li><a href="#dbset">DbSet</a></li>
    <li><a href="#config-datacontext">Configurando o DataContext</a></li>
    <li><a href="#create">Create</a></li>
    <li><a href="#update">Update</a></li>
    <li><a href="#delete">Delete</a></li>
    <li><a href="#tolist">ToList</a></li>
    <li><a href="#asnottracking">AsNoTracking</a></li>
    <li><a href="#first-single">First, Single</a></li>
</ul>

</details>

<!--#endregion -->

<!--#region Operações Básicas -->

<details><summary>Operações Básicas</summary>

<ul>
    <li><a href="#ob-mapeamento">Mapeamento</a></li>
    <li><a href="#ob-tipos">Tipos de Mapeamento</a></li>
    <li><a href="#ob-table-key-identity">Table, Key e Identity</a></li>
    <li><a href="#ob-required-maxlenght-column">Required, MaxLenght e Column</a></li>
    <li><a href="#ob-navigation-properties">Navigation Properties</a></li>
    <li><a href="#ob-subconjuntos">Trabalhando com Sub Conjuntos</a></li>
    <li><a href="#ob-include">Include</a></li>
    <li><a href="#ob-log">Log</a></li>
    <li><a href="#ob-subconjunto">Alterando um Subconjunto</a></li>
</ul>

</details>

<!--#endregion -->

<!--#region Mapeamento -->

<details><summary>Mapeamento</summary>

<ul>
    <li><a href="#map-introducao">Introdução</a></li>
    <li><a href="#map-iniciando">Iniciando o Mapeamento</a></li>
    <li><a href="#map-primary-identity">Chave Primária e Identity</a></li>
    <li><a href="#map-propriedades">Mapeando Propriedades</a></li>
    <li><a href="#map-indices">Índices</a></li>
    <li><a href="#map-usuario">Iniciando o Mapeamento do Usuário</a></li>
    <li><a href="#map-default">Default Values</a></li>
    <li><a href="#map-relacionamento-1-n">Relacionamento Um para Muitos</a></li>
    <li><a href="#map-relacionamento-n-n">Relacionamento Muitos para Muitos</a></li>
    <li><a href="#map-criados">Utilizando os Mapeamentos Criados</a></li>
    <li><a href="#map-testando">Testando os Relacionamentos</a></li>
</ul>

</details>

<!--#endregion -->

<!--#region Relacionamentos -->

<details><summary>Relacionamentos</summary>

<ul>
    <li><a href="#rel-introducao">Introdução</a></li>
    <li><a href="#rel-migracao">Criando uma migração</a></li>
    <li><a href="#rel-banco">Atualizando o banco</a></li>
    <li><a href="#rel-versao">Gerando nova versao do banco</a></li>
    <li><a href="#rel-script">Gerando script do banco</a></li>
</ul>

</details>

<!--#endregion -->

<!--#region Relacionamentos -->

<details><summary>Performance e Outros</summary>

<ul>
    <li><a href="#out-performance">Performance</a></li>
    <li><a href="#out-asnotracking">AsNoTracking</a></li>
    <li><a href="#out-async-await">Async e Await</a></li>
    <li><a href="#out-loading">Eager Loading VS Lazy Loading</a></li>
</ul>

</details>

<!--#endregion -->

<!--#endregion -->

<!--#region Introdução -->

<h2>Introdução</h2>

<!--#region Introdução -->

<details id="introducao"><summary>Introdução</summary>

<br/>

<p>Objetivos:</p>
<ul>    
    <li>Introdução e imersão</li>
    <li>Relacionamentos</li>
    <li>CRUD</li>
    <li>Migrations</li>
    <li>Performance</li>
</ul>

</details>

<!--#endregion -->

<!--#region Ferramentas -->

<details id="ferramentas"><summary>Ferramentas</summary>

<br/>

<p>Requisitos:</p>
<ul>
    <li>Fundamentos C#</li>
    <li>OOP</li>
    <li>SQL Server</li>
    <li>Dapper</li>
</ul>

<p>Ferramentas:</p>
<ul>
    <li>Fundamentos C#, OOP, SQL Server, Dapper</li>
    <li>Windows, Mac ou Linux</li>
    <li>.NET 5 ou superior</li>
    <li>Azure Data Studio</li>
    <li>SQL Server</li>
    <li>Visual Studio Code</li>    
</ul>

</details>

<!--#endregion -->

<!--#region ORM -->

<details id="orm"><summary>ORM</summary>

<br/>

<p>Object/ Relational Mapping:</p>
<ul>    
    <li>Mapeamento Objeto/ Relacional</li>
    <li>Responsável por fazer o DE-PARA</li>
    <li>Parte essencial do Entity Framework</li>
    <li>Similar ao Dapper</li>
</ul>

</details>

<!--#endregion -->

<!--#region Entity Framework -->

<details id="ef"><summary>Entity Framework</summary>

<br/>

<p>Framework:</p>
<ul>    
    <li>Conjunto de bibliotecas</li>
    <li>Muito mais poderoso que o Dapper</li>
    <ul>
        <li>Maix compleso e mais <b>pesado</b></li>
    </ul>
    <li>Permite trabalhar com:</li>
    <ul>
        <li>CRUD</li>
        <li>Migrações</li>
    </ul>
</ul>

</details>

<!--#endregion -->

<!--#region Code First ou Database First -->

<details id="code-database-first"><summary>Code First ou Database First</summary>

<br/>

<p>Projetos Greenfield e Brownfield</p>

<br/>

<p>Abordagens:</p>

<p>1. Database First:</p>
<ul>
<li>O banco já está feito</li>
<li>Mapeamos o que existe para os novos objetos criados</li>
</ul>

<p>2. Code First:</p>
<ul>
<li>Também conhecido como <b>Model First</b></li>
<li>Começamos pelo código</li>
<li>Geramos o banco automaticamente via Migrations</li>
<li>Modelo amplamente usado</li>
</ul>

</details>

<!--#endregion -->

<!--#region DataContext -->

<details id="datacontext"><summary>DataContext</summary>

<br/>

<p>Contextos:</p>

<ul>
<li>Único objeto que o EF precisa</li>
<li>Define o <b>banco de dados</b> em memória</li>
<li>Composto por subconjuntos de dados chamados de <b>DbSet</b></li>
</ul>

</details>

<!--#endregion -->

<!--#region Restaurando o Banco -->

<details id="restaurando-banco"><summary>Restaurando o Banco</summary>

<br/>

<p>Preparando o ambiente:</p>

[Docker Desktop](https://www.docker.com/products/docker-desktop/)

[Docker - Instalação, Configuração e Primeiros Passos](https://balta.io/blog/docker-instalacao-configuracao-e-primeiros-passos)

[SQL Server Docker](https://balta.io/blog/sql-server-docker)

[Azure Data Studio](https://docs.microsoft.com/pt-br/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver16)

[Script SQL](./script.sql)

</details>

<!--#endregion -->

<!--#region Criando os Modelos -->

<details id="criando-modelos"><summary>Criando os Modelos</summary>

<br/>

```ps
dotnet --list-sdks
dotnet new globaljson --sdk-version 5.0.400

dotnet --version
5.0.408
```

```ps
dotnet new console -o Blog
```

</details>

<!--#endregion -->

<!--#region DbSet -->

<details id="dbset"><summary>DbSet</summary>

<br/>

<p>Instalar pacotes:</p>

```ps
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.17
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.17

dotnet restore
```

</details>

<!--#endregion -->

<!--#region Configurando o DataContext -->

<details id="config-datacontext"><summary>Configurando o DataContext</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Create -->

<details id="create"><summary>Create</summary>

<br/>

```ps
dotnet run
```

```sql
SELECT [Id]
      ,[Name]
      ,[Slug]
  FROM [Blog].[dbo].[Tag]
```

</details>

<!--#endregion -->

<!--#region Update -->

<details id="update"><summary>Update</summary>

<br/>

```ps
dotnet run
```

```sql
SELECT [Id]
      ,[Name]
      ,[Slug]
  FROM [Blog].[dbo].[Tag]
```

</details>

<!--#endregion -->

<!--#region Delete -->

<details id="delete"><summary>Delete</summary>

<br/>

```ps
dotnet run
```

```sql
SELECT [Id]
      ,[Name]
      ,[Slug]
  FROM [Blog].[dbo].[Tag]
```

</details>

<!--#endregion -->

<!--#region ToList -->

<details id="tolist"><summary>ToList</summary>

<br/>

```ps
dotnet run
```

```sql
SELECT [Id]
      ,[Name]
      ,[Slug]
  FROM [Blog].[dbo].[Tag]
```

</details>

<!--#endregion -->

<!--#region AsNoTracking -->

<details id="asnotracking"><summary>AsNoTracking</summary>

<br/>

Muito usado em cenários somente leitura.

Utilizar em leituras.
Não recomendável para atualizações e exclusões. Geralmente os erros ocorrem em tempo de execução (cliente).

```ps
dotnet run
```

```sql
SELECT [Id]
      ,[Name]
      ,[Slug]
  FROM [Blog].[dbo].[Tag]
```

</details>

<!--#endregion -->

<!--#region First, Single -->

<details id="first-single"><summary>First, Single</summary>

<br/>

First: Traz o primeiro item da lista
Single: Traz o primeiro item da lista, mas se houver mais de um item exibe exceção

```ps
dotnet run
```

</details>

<!--#endregion -->

<!--#endregion -->

<!--#region Operações Básicas -->

<h2>Operações Básicas</h2>

<!--#region Mapeamento -->

<details id="ob-mapeamento"><summary>Mapeamento</summary>

<br/>

<p><b>O que é?</b></p>
<ul>    
    <li>De/Para</li>
    <li>Diz qual classe no C# se refere a qual tabela no banco de dados</li>
    <li>Diz quais propriedades da classe se referem a quais colunas da tabela relacionada</li>
    <li>Informa os tipos de dados</li>
    <li>Permite gerar o banco automaticamente</li>
</ul>

</details>

<!--#endregion -->

<!--#region Tipos de Mapeamento -->

<details id="ob-tipos"><summary>Tipos de Mapeamento</summary>

<br/>

<p><b>Tipos:</b></p>
<ul>    
    <li>
        Fluent Mapping
        <ul>
            <li>Mapeamento fluente</li>
            <li>Feito em uma classe externa</li>
            <li>Não "polui" a classe principal</li>
            <li>Não cria dependências na classe/ projeto principal</li>
        </ul>
    </li>
    <li>
        Data Annotations
        <ul>
            <li>Feitos diretamente nas classes</li>
            <li>Mais simples e diretos</li>
            <li>Dependem do System.ComponentModel.DataAnnotations ¹</li>
        </ul>
    </li>
</ul>

¹ Alguns dependem do Microsoft.EntityFrameworkCore também. Quando compartilhado com outros projetos, as dependências não são recomendadas. Utilizado para projetos menores.

</details>

<!--#endregion -->

<!--#region Table, Key e Identity -->

<details id="ob-table-key-identity"><summary>Table, Key e Identity</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Required, MaxLenght e Column -->

<details id="ob-required-maxlenght-column"><summary>Required, MaxLenght e Column</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Navigation Properties -->

<details id="ob-navigation-properties"><summary>Navigation Properties</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Trabalhando com Sub Conjuntos -->

<details id="ob-subconjuntos"><summary>Trabalhando com Sub Conjuntos</summary>

<br/>

```ps
dotnet run
```

```sql
select * from [Post]
select * from [User]
select * from [Category]
```

![Imagem](./Blog/Assets/Captura%20de%20tela%202022-06-21%20210232.png)

</details>

<!--#endregion -->

<!--#region Include -->

<details id="ob-include"><summary>Include</summary>

<br/>

```ps
dotnet run

Começando com EF Core escrito por André Baltieri
```

</details>

<!--#endregion -->

<!--#region Log -->

<details id="ob-log"><summary>Log</summary>

<br/>

<p>Evitar **ThenInclude** que faz **subselect** na base de dados.</p>

```ps
dotnet run
```

Sem include:

```ps
info: 21/06/2022 21:17:42.309 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (76ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [p].[Id], [p].[AuthorId], [p].[Body], [p].[CategoryId], [p].[CreateDate], [p].[LastUpdateDate], [p].[Slug], [p].[Summary], [p].[Title]
      FROM [Post] AS [p]
      ORDER BY [p].[LastUpdateDate] DESC
```

Com include **Author**:

```ps
info: 21/06/2022 21:19:50.036 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (101ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [p].[Id], [p].[AuthorId], [p].[Body], [p].[CategoryId], [p].[CreateDate], [p].[LastUpdateDate], [p].[Slug], [p].[Summary], [p].[Title], [u].[Id], [u].[Bio], [u].[Email], [u].[Image], [u].[Name], [u].[PasswordHash], [u].[Slug]
      FROM [Post] AS [p]
      INNER JOIN [User] AS [u] ON [p].[AuthorId] = [u].[Id]
      ORDER BY [p].[LastUpdateDate] DESC
```

Com include **Author** e **Category**:

```ps
info: 21/06/2022 21:22:41.974 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (193ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [p].[Id], [p].[AuthorId], [p].[Body], [p].[CategoryId], [p].[CreateDate], [p].[LastUpdateDate], [p].[Slug], [p].[Summary], [p].[Title], [u].[Id], [u].[Bio], [u].[Email], [u].[Image], [u].[Name], [u].[PasswordHash], [u].[Slug], [c].[Id], [c].[Name], [c].[Slug]
      FROM [Post] AS [p]
      INNER JOIN [User] AS [u] ON [p].[AuthorId] = [u].[Id]
      INNER JOIN [Category] AS [c] ON [p].[CategoryId] = [c].[Id]
      ORDER BY [p].[LastUpdateDate] DESC
```

</details>

<!--#endregion -->

<!--#region Alterando um Subconjunto -->

<details id="ob-subconjunto"><summary>Alterando um Subconjunto</summary>

<br/>

```ps
dotnet run
```

```ps
info: 21/06/2022 21:35:49.805 CoreEventId.ContextInitialized[10403] (Microsoft.EntityFrameworkCore.Infrastructure)
      Entity Framework Core 5.0.17 initialized 'BlogDataContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: None
info: 21/06/2022 21:35:50.646 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (44ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT TOP(1) [p].[Id], [p].[AuthorId], [p].[Body], [p].[CategoryId], [p].[CreateDate], [p].[LastUpdateDate], [p].[Slug], [p].[Summary], [p].[Title], [u].[Id], [u].[Bio], [u].[Email], [u].[Image], [u].[Name], [u].[PasswordHash], [u].[Slug], [c].[Id], [c].[Name], [c].[Slug]
      FROM [Post] AS [p]
      INNER JOIN [User] AS [u] ON [p].[AuthorId] = [u].[Id]
      INNER JOIN [Category] AS [c] ON [p].[CategoryId] = [c].[Id]
      ORDER BY [p].[LastUpdateDate] DESC
info: 21/06/2022 21:35:51.102 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (71ms) [Parameters=[@p8='?' (DbType = Int32), @p0='?' (DbType = Int32), @p1='?' (Size = 4000), @p2='?' (DbType = Int32), @p3='?' (DbType = DateTime2), @p4='?' (DbType = DateTime2), @p5='?' (Size = 4000), @p6='?' (Size = 4000), @p7='?' (Size = 4000)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      UPDATE [Post] SET [AuthorId] = @p0, [Body] = @p1, [CategoryId] = @p2, [CreateDate] = @p3, [LastUpdateDate] = @p4, [Slug] = @p5, [Summary] = @p6, [Title] = @p7
      WHERE [Id] = @p8;
      SELECT @@ROWCOUNT;
info: 21/06/2022 21:35:51.118 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command)
      Executed DbCommand (8ms) [Parameters=[@p1='?' (DbType = Int32), @p0='?' (Size = 4000)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      UPDATE [User] SET [Name] = @p0
      WHERE [Id] = @p1;
      SELECT @@ROWCOUNT;
```

```sql
select * from [User];
```

![Imagem](./Blog/Assets/Captura%20de%20tela%202022-06-21%20213623.png)

</details>

<!--#endregion -->

<!--#endregion -->

<!--#region Mapeamento -->

<h2>Mapeamento</h2>

<!--#region Introdução -->

<details id="map-introducao"><summary>Introdução</summary>

<br/>

<p><b>Fluent Mapping</b></p>

</details>

<!--#endregion -->

<!--#region Iniciando o Mapeamento -->

<details id="map-iniciando"><summary>Iniciando o Mapeamento</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Chave Primária e Identity -->

<details id="map-primary-identity"><summary>Chave Primária e Identity</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Mapeando Propriedades -->

<details id="map-propriedades"><summary>Mapeando Propriedades</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Índices -->

<details id="map-indices"><summary>Índices</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Iniciando o Mapeamento do Usuário -->

<details id="map-usuario"><summary>Iniciando o Mapeamento do Usuário</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Default Values -->

<details id="map-default"><summary>Default Values</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Relacionamento Um para Muitos -->

<details id="map-relacionamento-1-n"><summary>Relacionamento Um para Muitos</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Relacionamento Muitos para Muitos -->

<details id="map-relacionamento-n-n"><summary>Relacionamento Muitos para Muitos</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Utilizando os Mapeamentos Criados -->

<details id="map-criados"><summary>Utilizando os Mapeamentos Criados</summary>

<br/>

</details>

<!--#endregion -->

<!--#region Testando os Relacionamentos -->

<details id="map-testando"><summary>Testando os Relacionamentos</summary>

<br/>

```ps
dotnet run
```

```sql
select * from [User]
select * from [Category]
select * from [Post]
```

![Imagem](./FluentBlog/Assets/Captura%20de%20tela%202022-06-25%20095451.png)

</details>

<!--#endregion -->

<!--#endregion -->

<!--#region Relacionamentos -->

<h2>Relacionamentos</h2>

<!--#region Introdução -->

<details id="rel-introducao"><summary>Introdução</summary>

<br/>

```sql
USE [master]
GO

ALTER DATABASE [Blog] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

DROP DATABASE [Blog]
GO
```

```ps
dotnet tool install --global dotnet-ef
dotnet ef
```

</details>

<!--#endregion -->

<!--#region Criando uma migração -->

<details id="rel-migracao"><summary>Criando uma migração</summary>

<br/>

```ps
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.17
```

```ps
dotnet clean
dotnet build

dotnet ef migrations add InitialCreation
```

<p>Será criada a pasta <b>Migrations</b> dentro do projeto</p>

</details>

<!--#endregion -->

<!--#region Atualizando o banco -->

<details id="rel-banco"><summary>Atualizando o banco</summary>

<br/>

```ps
dotnet ef database update
```

```sql
SELECT TOP (1000) [MigrationId]
      ,[ProductVersion]
  FROM [Blog].[dbo].[__EFMigrationsHistory]
```

![Imagem](./FluentBlog/Assets/Captura%20de%20tela%202022-06-25%20111557.png)

</details>

<!--#endregion -->

<!--#region Gerando nova versão do banco -->

<details id="rel-versao"><summary>Gerando nova versão do banco</summary>

<br/>

```ps
dotnet ef migrations add AdicionadoCampoGitHub
dotnet ef database update

dotnet run
```

![Imagem](./FluentBlog/Assets/Captura%20de%20tela%202022-06-25%20112944.png)

</details>

<!--#endregion -->

<!--#region Gerando script do banco -->

<details id="rel-script"><summary>Gerando script do banco</summary>

<br/>

<p>Para deixar de trabalhar com Migrations:</p>
<ul>
    <li>Excluir a pasta <b>Migrations</b> do projeto</li>
    <li>Excluir a tabela <b>__EFMigrationsHistory</b> do banco de dados</li>
</ul>

```sql
DROP TABLE [__EFMigrationsHistory]
```

<p>Geração de script do banco:</p>

```sql
USE [master]
GO

ALTER DATABASE [Blog] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

DROP DATABASE [Blog]
GO
```

```ps
dotnet clean
dotnet build

dotnet ef migrations add InitialCreation
dotnet ef migrations script -o ./migration.sql
```

```sql
CREATE DATABASE [Blog]
GO

USE [Blog]
GO

<migration.sql>
```

</details>

<!--#endregion -->

<!--#endregion -->

<!--#region Performance e Outros -->

<h2>Performance e Outros</h2>

<!--#region Performance e Outros -->

<details id="out-performance"><summary>Performance</summary>

<br/>

<p>
Performance é uma feature. Desejável, não obrigatório.<br/>
Definir o que seria performance.
</p>

</details>

<!--#endregion -->

<!--#region AsNoTracking -->

<details id="out-asnotracking"><summary>AsNoTracking</summary>

<br/>

<p>Tracking</p>
<p>Metadados: informações a mais utilizadas pelo <b>EF</b></p>
<p>AsNoTracking não traz metadados</p>

</details>

<!--#endregion -->

<!--#region Async e Await -->

<details id="out-async-await"><summary>Async e Await</summary>

<br/>

<p><b>Task - System.Threading.Tasks</b></p>
<p>Tarefas. Permite execuções em paralelo.</p>
<p><b>Async</b> e <b>Await</b> dependem do método como <b>Task</b>. Com isso, outros métodos podem chamar esse método ao mesmo tempo e aguardar sua execução.</p>

<p>Sem <b>await</b> todas as instruções do método são executadas mesmo que algumas não estejam concluídas.</p>

</details>

<!--#endregion -->

<!--#region Eager Loading VS Lazy Loading -->

<details id="out-loading"><summary>Eager Loading VS Lazy Loading</summary>

<br/>

<p>Lazy Loading: Carregamento preguiçoso</p>

</details>

<!--#endregion -->

<!--#endregion -->
