# VirtualCards
## Web API que gera cartões virtuais vinculados ao endereço de e-mail e depois lista os cartões gerados.

Um dos meus primeiros projetos em C#. Foi de fato um desafio. Tive que aprender uma nova linguagem e toda a sua sintaxe
em 3 dias e meio. Mas o aprendizado foi gigante. E gostei do resultado, já estou ansioso para descobrir o que posso fazer
com mais tempo de estudo.

A API tem 2 endpoints:

Um método Post que gera o cartão virtual e recebe como parâmetro o endereço de e-mail do usuário. O cartão virtual é gerado
com um número aleatório de 4 dígitos. 

E um método Get que configurei para listar todos os cartões virtuais gerados para um determinado endereço de e-mail ordenados
pela data de criação.

Tecnologias utilizadas:

* C#
* .NET
* Entity Framework
