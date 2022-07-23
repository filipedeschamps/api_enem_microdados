# API Microdados ENEM 2021
Essa é uma API criada para realizar resgate de dados que estão presentes no arquivo disponibilizado pelo [INEP](https://www.gov.br/inep/pt-br), de forma a criar automatizações para quem pretende usar o serviço. O projeto será **Open Source**, já que não há viabilidade para manter os custos de manter a aplicação ASP. Net Core e MySql aberta publicamente online. Desse modo, esse repositório será um **modelo** para criação de API's baseada nos [microdados do ENEM](https://www.gov.br/inep/pt-br/acesso-a-informacao/dados-abertos/microdados/enem).

## Os dados
Os dados estão sendo disponibilizado em um arquivo [.CSV](https://pt.wikipedia.org/wiki/Comma-separated_values) com espaço em armazenamento de 1,2GB, tendo isso em vista, é inviável utilizar para o desenvolvimento do projeto um banco de dados com mais de **um milhão de linhas**. Desse modo, foi criado uma pasta "Others", que será responsável por disponbilizar as 1.000 linhas limitadas que estamos utilizando e um **dicionário de ajuda**.

## Como rodar o projeto?

Faça o remote para o repositório do GitHub na pasta que gostaria:
```git
git remote add origin "https://github.com/OtavioVB/api_enem_microdados.git"
```

Faça o clone do repositório
```git
git clone
```

Crie um Banco de Dados MySql e Importe por meio do arquivo .csv os dados.


# Referências
- [Microdados ENEM](https://www.gov.br/inep/pt-br/acesso-a-informacao/dados-abertos/microdados/enem);