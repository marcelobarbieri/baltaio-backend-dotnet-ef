<h1>Fundamentos do Entity Framework</h1>

> As aulas assistidas foram organizadas nos **commits**

<!--#region Sumário -->

<h2>Sumário</h2>

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
