# .NET Softplan Challnge

## Aten��o
* Garanta que tenha o [docker](https://www.docker.com/) instalado. 
* Antes de executar o comando abaixo verifique se est� com as portas 8001 e 8002 liberadas no docker.

## Rodar a aplica��o
```
> git clone https://github.com/medidrones/Desafio-Softplan
> cd DesafioSoftplan
> docker-compose up -d
```
## Caminhos
* Api1: http://localhost:8001/swagger
* Api2: http://localhost:8002/swagger

## O Desafio
Voc� dever� criar duas API's uma com dois endpoints e outra com um endpoint:

#### API 1
1) Retorna taxa de juros  
Responde pelo path relativo "/taxaJuros"
Retorna o juros de 1% ou 0,01 (fixo no c�digo)
* Exemplo: /taxaJuros Resultado esperado: 0,01

#### API 2  
1) Calcula Juros
Responde pelo path relativo "/calculajuros"
Ela faz um c�lculo em mem�ria, de juros compostos, conforme abaixo: Valor Final =
Valor Inicial * (1 + juros) ^ Tempo
Valor inicial � um decimal recebido como par�metro.
Valor do Juros deve ser consultado na API 1.
Tempo � um inteiro, que representa meses, tamb�m recebido como par�metro.
^ representa a opera��o de pot�ncia.
Resultado final deve ser truncado (sem arredondamento) em duas casas decimais.

* Exemplo: /calculajuros?valorinicial=100&meses=5 Resultado esperado: 105,10

2) Show me the code  
Este responde pelo path relativo /showmethecode Dever� retornar a url de onde
encontra-se o fonte no github
