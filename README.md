# DbzGraphQl

Api básica utilizando GraphQl para consulta de dados.

### Getting-started

Para realizar uma consulta, basta rodar a aplicação e utilizar o Postman
para enviar uma requisição para a api.

Fazer um Post com o seguinte conteúdo:
{
"query": "query {saiyajin(id: \"1\") { name, power, saiyajinLevel, enemies  } }"
}
