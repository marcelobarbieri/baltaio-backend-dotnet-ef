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

<!--#endregion -->
