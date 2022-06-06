# Plano de Teste de Software

# Resumo


<table>
  <tr>
   <th>USER STORY </th>
   <th>Qual o valor para o Usuário?</th>
   <th>Qual o valor para o Negócio?</th>
  </tr>
 
 <tr>
    <td>Eu enquanto usuário, 
     quero poder me cadastrar em um site
     para poder postar comentários, poder salvar imagens de ocorrências astronômicas e quero poder cadastrar ocorrências astronômicas.
  </td>
    <td>Agregar atualizações referente à ocorrências astronômicas gerais e locais.
  </td>
   <td>Permitir compartilhar conhecimento com outras pessoas interessadas em ocorrências astronômicas.Para poder salvar e acessar minhas informações e dados independente do lugar ao qual o site for acessado.Para poder ver e compartilhar novas imagens sobre ocorrências astronômicas e para poder ver e compartilhar novas ocorrências astronômicas.
  </td>
 </tr>
</table>


# Cadastrar Novo Membro
 <li>Dado que (Given) possua as informações pessoais como Usuário, Nome, E-mail, senha e CEP</li>
 <li>Quando (When) fizer o cadastro</li>
 <li>Então (Then) as informações devem ser armazenadas no banco de dados</li>
 
# Cadastrar Card
 <li>Dado (Given) das informações de ocorrências astronomicas como Nome, Descrição, Data, Localização, Palavras-Chaves e Mais informações</li>
 <li>Quando (When) estiver logado</li>
 <li>Então (Then) as informações devem ser armazenadas no banco de dados e o card será gerado</li>

# Cadastrar Comentário no Blog
 <li>Dado (Given)  dos comentários</li>
 <li>Quando (When) estiver logado</li>
 <li>Então (Then) as informações devem ser armazenadas no banco de dados e o comentário será exibido</li>

# Cadastrar Imagem na Galeria
 <li>Dado que (Given) a imagem será incluida junto com um nome </li>
 <li>Quando (When) estiver logado</li>
 <li>Então (Then) as informações devem ser armazenadas no banco de dados e imagem será exibida</li>
