# Arquitetura da Solução

<img src="img/Componentes.png"/>

## Diagrama de Classes

<img src="img/Diagrama de classes.png"/>

## Modelo ER e Esquema Relacional

<img src="img/Modelo ER.png"/>

## Modelo Físico (DDL)

Entregar um arquivo banco.sql contendo os scripts de criação das tabelas do banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.
- ARQUIVO JÁ INSERIDO NA PASTA SOLICITADA.

## Instruções SQL de Manipulação do BD (DML)

Entregar um arquivo dml.sql contendo os scripts de manipulação de banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.
- ARQUIVO JÁ INSERIDO NA PASTA SOLICITADA.

## Tecnologias Utilizadas

As tecnologias utilizadas foram: Visual Code, EntityFramework. Bootstrap, SQL server, google chrome, ASP.NET MVC.

## Hospedagem

A hospedagem na Web foi implantada na Azure em um aplicativo ASP.NET controlado por dados no Serviço de Aplicativo e conectá-lo ao Banco de Dados SQL do Azure.

E o lançamento da plataforma foi feito pelos seguintes passos


A hospedagem na Web foi implantada em um aplicativo ASP.NET controlado por dados no Serviço de Aplicativo e conectá-lo ao Banco de Dados SQL do Azure.

Executar o aplicativo

Abra o arquivo no Visual Studio.

Tipo Ctrl+F5 para executar o aplicativo sem depuração. O aplicativo é exibido no navegador padrão.

Selecione o link Criar novo e crie alguns itens de tarefas.

Teste os links Editar, Detalhes e Excluir.

O aplicativo usa um contexto de banco de dados para se conectar com o banco de dados. Neste exemplo, o contexto do banco de dados usa uma cadeia de conexão chamada MyDbConnection. Essa cadeia de conexão é definida no arquivo Web. config e é referenciada no arquivo Models/MyDatabaseContext.cs. O nome da cadeia de conexão é usado mais adiante no tutorial para conectar o aplicativo do Azure a um Banco de Dados SQL do Azure.

Publicar um aplicativo ASP.NET no Azure

No Gerenciador de Soluções, clique com botão direito no projeto e selecione Publicar.

Selecione Azure como o destino e clique em Avançar.

Verifique se o Serviço de Aplicativo do Azure (Windows) está selecionado e clique em Avançar.

Entrar e adicionar um aplicativo

Na caixa de diálogo Publicar, clique em Entrar.

Entre na sua assinatura do Azure. Se você já entrou em uma conta da Microsoft, verifique se a conta tem sua assinatura do Azure. Se a conta da Microsoft conectada não tiver sua assinatura do Azure, clique nela para adicionar a conta correta.

No painel Instâncias do Serviço de Aplicativo, clique em +.

Configurar o nome do aplicativo Web

Você pode manter o nome do aplicativo Web gerado ou alterá-lo para outro nome exclusivo (caracteres válidos são a-z, 0-9 e -). O nome do aplicativo Web é usado como parte da URL padrão para seu aplicativo (<app_name>.azurewebsites.net, onde <app_name> é o nome do aplicativo Web). O nome do aplicativo Web precisa ser exclusivo em todos os aplicativos no Azure.

Observação

Ainda não selecione Criar.

Criar um grupo de recursos

Um grupo de recursos é um contêiner lógico no qual os recursos do Azure, como aplicativos Web, bancos de dados e contas de armazenamento, são implantados e gerenciados. Por exemplo, é possível excluir posteriormente todo o grupo de recursos com uma única etapa simples.

Ao lado de Grupo de Recursos, clique em Novo.

Nomeie o grupo de recursos.

Criar um plano de Serviço de Aplicativo

Um plano do Serviço de Aplicativo especifica o local, tamanho e recursos do farm de servidores Web que hospeda o aplicativo. É possível economizar dinheiro ao hospedar vários aplicativos configurando os aplicativos Web para compartilhar um plano do Serviço de Aplicativo.

Os Planos do Serviço de Aplicativo definem:

Região (por exemplo: Norte da Europa, Leste dos EUA ou Sudeste Asiático)

Tamanho da instância (pequena, média ou grande)

Contagem da escala (1 a 20 instâncias)

SKU (Gratuito, Compartilhado, Básico, Standard ou Premium)

Ao lado de Plano de Hospedagem, clique em Novo.

Na caixa de diálogo Configurar Plano do Serviço de Aplicativo, configure o novo plano do Serviço de Aplicativo com as seguintes definições e clique em OK:

Configuração  Valor sugerido para obter mais informações

Plano do Serviço de Aplicativo  myAppServicePlan  Planos do Serviço de Aplicativo

Localidade  Europa Ocidental  Regiões do Azure

Tamanho  Grátis  Tipos de preço

Clique em Criar e aguarde até que os recursos do Azure sejam criados.

A caixa de diálogo publicar mostrará os recursos que você configurou. Clique em Concluir.

the resources you've created

Criar um servidor e um banco de dados

Antes de criar um banco de dados, você precisará ter um servidor SQL lógico. Um servidor SQL lógico é um constructo lógico que contém um grupo de bancos de dados gerenciados como um grupo.

Na caixa de diálogo publicar, role para baixo até a seção Dependências de Serviço. Ao lado de Banco de Dados do SQL Server, clique em Configurar.

Observação

Configure o Banco de Dados SQL da página Publicar em vez da página Serviços Conectados.

Selecione o Banco de Dados SQL do Azure e clique em Avançar.

Na caixa de diálogo Configurar Banco de Dados SQL do Azure, clique em +.

Ao lado de Servidor de banco de dados, clique em Novo.

Esse nome do servidor é usado como parte da URL padrão do servidor, <server_name>.database.windows.net. Ele precisa ser exclusivo em todos os servidores do SQL do Azure. Altere o nome do servidor para um valor desejado.

Adicione um nome de usuário administrador e a senha. Para requisitos de complexidade de senha, consulte Política de Senha.

Lembre desse nome de usuário e senha. Você precisará deles para gerenciar o servidor mais tarde.

Importante

Mesmo que a senha nas cadeias de conexão esteja mascarada (no Visual Studio e também no Serviço de Aplicativo), o fato de que ela foi mantida em algum lugar aumenta a superfície de ataque do seu aplicativo. O Serviço de Aplicativo pode usar identidades de serviço gerenciadas para eliminar esse risco removendo a necessidade de manter os segredos na configuração de aplicativo ou no código. Para saber mais, confira as Próximas etapas.

Clique em OK.

Na caixa de diálogo Banco de Dados SQL do Azure, mantenha o Nome de Banco de Dados padrão gerado. Selecione Criar e aguarde até que os recursos de banco de dados sejam criados.

Configurar a conexão de banco de dados

Quando o assistente terminar de criar os recursos de banco de dados, clique em Avançar.

Em Nome da cadeia de conexão de banco de dados, digite MyDbConnection. Esse nome deve corresponder à cadeia de conexão que está referenciada em Models/MyDatabaseContext.cs.

Em Nome de usuário da conexão de banco de dados e Senha de conexão de banco de dados, digite o nome de usuário e a senha do administrador usados em Criar um servidor.

Verifique se a opção Configurações do Aplicativo Azure está selecionada e clique em Concluir.

Observação

Se você vir Arquivos de segredos do usuário local, deverá ter configurado o Banco de Dados SQL na página Serviços Conectados em vez da página Publicar.

Aguarde até que o assistente de configuração seja concluído e clique em Fechar.

Implantar o aplicativo ASP.NET

Na guia Publicar, role de volta para cima e clique em Publicar. Após o aplicativo ASP.NET ser implantado no Azure. Seu navegador padrão é iniciado com a URL para o aplicativo implantado.

Adicione alguns itens de tarefas.

Acessar o banco de dados localmente

O Visual Studio permite que você explore e gerencie seu novo banco de dados no Azure com facilidade no Pesquisador de Objetos do SQL Server. O novo banco de dados já abriu seu firewall para o aplicativo do Serviço de Aplicativo que você criou. Mas para acessá-lo do seu computador local (por exemplo, do Visual Studio), você precisa abrir um firewall para o endereço IP público do computador local. Se o seu provedor de serviços de Internet alterar seu endereço IP público, você precisará reconfigurar o firewall para acessar o banco de dados do Azure novamente.

Criar uma conexão de banco de dados

No menu Visualizar, selecione Pesquisador de objetos do SQL Server.

Na parte superior do Pesquisador de Objetos do SQL Server, clique no botão Adicionar SQL Server.

Configurar a conexão de banco de dados

Na caixa de diálogo Conectar, expanda o nó Azure. Todas as suas instâncias de Banco de Dados SQL no Azure são listadas aqui.

Selecione o banco de dados criado anteriormente. A conexão criada antes é automaticamente preenchida na parte inferior.

Digite a senha de administrador de banco de dados que você criou anteriormente e clique em Conectar.

Permitir conexão do cliente a partir de seu computador

A caixa de diálogo Crie uma nova regra de firewall é aberta. Por padrão, um servidor só permite conexões com os respectivos bancos de dados nos serviços do Azure, como o aplicativo do Azure. Para se conectar ao banco de dados fora do Azure, crie uma regra de firewall no nível do servidor. A regra de firewall permite o endereço IP público do seu computador local.

A caixa de diálogo já está preenchida com o endereço IP público do seu computador.

Certifique-se de que Adicionar meu IP do cliente está selecionado e clique em OK.

Quando o Visual Studio terminar de criar a configuração de firewall para a instância do Banco de dados SQL, sua conexão aparecerá no Pesquisador de Objetos do SQL Server.

Aqui, você pode executar as operações de banco de dados mais comuns, como executar consultas, criar exibições, procedimentos armazenados e, muito mais.

Expanda sua conexão >Bancos de dados><seu banco de dados>>Tabelas. Clique com o botão direito do mouse na tabela Todoes e selecione Exibir Dados.

Atualizar aplicativo com Migrações do Code First

Use as ferramentas conhecidas no Visual Studio para atualizar o banco de dados e o aplicativo no Azure. Nesta etapa, você usará Migrações do Code First no Entity Framework para fazer uma alteração no seu esquema de banco de dados e publicá-lo no Azure.

Para obter mais informações sobre como usar as Migrações do Entity Framework Code First, consulte Introdução ao Entity Framework 6 Code First usando MVC 5.

Atualizar seu modelo de dados

Abra Models\Todo.cs no editor de códigos. Adicione a seguinte propriedade à classe ToDo:

Executar Migrações do Code First localmente

Execute alguns comandos para fazer as atualizações para seu banco de dados local.

A partir do menu Ferramentas clique em Gerenciador de Pacotes NuGet>Console do Gerenciador de Pacotes.

Na janela do Console do Gerenciador de Pacotes, habilite as Migrações do Code First:

PowerShell

Enable-Migrations

Adicione uma migração:

PowerShell

Add-Migration AddProperty

Atualize o banco de dados local:

PowerShell

Update-Database

Digite Ctrl+F5 para executar o aplicativo. Teste os links editar, detalhes e criar.

Se o aplicativo for carregado sem erros, as Migrações do Code First tiveram êxito. No entanto, sua página ainda tem a mesma aparência porque a lógica de aplicativo ainda não está usando essa nova propriedade.

Usar a nova propriedade

Faça algumas alterações em seu código para usar a propriedade Done. Para simplificar este tutorial, somente as exibições Index e Create serão alteradas para observar a propriedade em ação.

Abra Controllers\TodosController.cs.

Localize o Create() método na linha 52 e adicione Done à lista de propriedades no atributo Bind. Quando terminar, a assinatura do método Create() deverá ter o seguinte código:

C#

public ActionResult Create([Bind(Include = "Description,CreatedDate,Done")] Todo todo)

Abra Views\Todos\Create.cshtml.

No código do Razor, você deve ver um elemento <div class="form-group"> que usa model.Description e outro elemento <div class="form-group"> que usa model.CreatedDate. Imediatamente após esses dois elementos, adicione outro elemento <div class="form-group"> que usa model.Done:

C#

<div class="form-group">

@Html.LabelFor(model => model.Done, htmlAttributes: new { @class = "control-label col-md-2" })

<div class="col-md-10">

<div class="checkbox">

@Html.EditorFor(model => model.Done)

@Html.ValidationMessageFor(model => model.Done, "", new { @class = "text-danger" })

</div>

</div>

</div>

Abra Views\Todos\Index.cshtml.

Procure o elemento vazio <th></th>. Logo acima desse elemento, adicione o seguinte código do Razor:

C#

Copiar

<th>

@Html.DisplayNameFor(model => model.Done)

</th>

Localize o elemento <td> que contém os métodos auxiliares Html.ActionLink(). Acima disto <td>, adicione outro elemento <td> com o seguinte código Razor:

C#

<td>

@Html.DisplayFor(modelItem => item.Done)

</td>

Isso é tudo o que você precisa para ver as alterações nas exibições Index e Create.

Digite Ctrl+F5 para executar o aplicativo.

Agora você pode adicionar um item de tarefas e marcar Concluído. Em seguida, ele deverá aparecer na sua página inicial como um item concluído. Lembre-se de que a exibição Edit não mostra o campo Done, porque você não alterou a exibição Edit.

Habilitar Migrações do Code First no Azure

Agora que a alteração de código funciona, incluindo a migração de banco de dados, publique-a no aplicativo do Azure e atualize o Banco de Dados SQL com as Migrações do Code First também.

Exatamente como antes, clique com o botão direito do mouse no projeto e selecione Publicar.

Clique em Mais ações>Editar para abrir as configurações de publicação.

Open publish settings

Na lista suspensa MyDatabaseContext, selecione a conexão de banco de dados para o Banco de Dados SQL do Azure.

Selecione Executar o Migrations do Code First (executado na inicialização do aplicativo) e, em seguida, clique em Salvar.

Publicar suas alterações

Agora que você habilitou as Migrações do Code First no aplicativo do Azure, publique as alterações de código.

Na página de publicação, clique em Publicar.

Tente adicionar os itens pendentes outra vez, selecione Concluído e os itens deverão aparecer na sua página inicial como um item concluído.

Observe que todos os itens de tarefas existentes ainda são exibidos. Quando você republicar seu aplicativo ASP.NET, os dados existentes no Banco de Dados SQL não serão perdidos. Além disso, as Migrações do Code First apenas alteram o esquema de dados e deixam os dados existentes intactos.
