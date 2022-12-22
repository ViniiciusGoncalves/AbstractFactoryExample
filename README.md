# Intenção

Fornece uma interface para criação de familías de objetos relacionados ou dependentes sem específicar suas classes concretas.

# Motivação

Construção de interfaces de usuário que suportem diferentes estilos de interação, permitindo diferentes apresentações e comportamentos para os widgets de cada estilo

# Aplicabilidade

Use o padrão Abstract Factory quando:

<ul>
  <li>Um sistema não deve depender de como seus produtos são criados, compostos e representados.</li>
  <li>Um sistema deve ser configurado como um produto de uma família de múltiplos produtos.</li>
  <li>Uma biblioteca de classes é fornecida, mas não se quer revelar suas implementações, apenas suas interfaces</li>
</ul>

# Estrutura 

![abstract-factory-uml](https://user-images.githubusercontent.com/81978099/209192481-58e907c6-0137-4252-851a-ac25d3137410.png)

# Consequencias

O padrão Abstract Factory tem os seguintes benefícios:

<ul>
  <li>Usando o Factory Method temos o nosso código de criação em um objeto ou método, evitando assim a duplicação e além disso temos um local único para fazer manutenção. O padrão também nos dá um código flexível e extensível para o futuro.</li>
  <li>Ele promove harmonia entre produtos. Quando o objetos-produtos numa família são projetados para trabalharem juntos, é importante que uma aplicação use objetos de somente uma família de cada vez. Abstract Factory torna fácil assegurar isso.</li>
</ul>


