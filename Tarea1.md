# Tareas-POO
Tareas de Programación Orientada a Objetos
# Tarea 1
Aqui estan todas las actividades de la tarea 1, empezando por conceptos.

## Paradigma
El paradigma de la **POO** es un estilo de programación en el que se trabajo con _"Objetos"_, los cuales poseen atributos y metodos, estos mismo se encuentran dentro de clases, y con estas herramientas fundamentales se crean dichos objetos y se trabaja con ellos.

## Abstracción
La abstracción es el proceso mental de "tomar" las caracteristicas más importantes o fundamentales de un objeto, aquellas que lo definen como tal y lo diferencian de los demás.

+ Un ejemplo es un auto, tiene sus propias caracteristicas, que en POO son atributos, como el color, marca, kilometraje y año.
+ Otro ejemplo es una casa, de ella la información que podemos abstraer es el color de su pintura, el material del que se fabricó o su código postal.

# ¿Por qué decimos que la _Clase_ es el mecanismo de abstracción de los lenguajes POO?
Se dice que la clase es un mecanismo de abstracción porqué abstrae las caracteristicas más importante de los objetos, las que necesitamos, eso lo hacemos mediante atributos, las acciones que pueden realizar dichos objetos los llamamos métodos y esta información que abstraemos la colocamos dentro de clases.

# Concepto de encapsulamiento explicado con dos imagenes

## Encapsulamiento
Es una manera de esconder los datos (atributos y métodos) en los llamados objetos. Esto para evitar problemas de dependencia de un fragmento de código con otro, o sea, para modularizar el código. De esta manera, se tiene el código separado en pequeños fragmentos **_"Independientes"_**, aunque no son realmente 100% independientes, de serlo, no interactuarían con el código y serían inutiles, lo que se intenta es que estos fragmentos esten lo menos conectados posible _-no que no lo esten_ para no depender tanto de otros, y de esta manera, al cambiar un dato en algún fragmento, esto no afecte en todo el código, la importancia de esto se aprecia en códigos grandes.

### _Sistema sin encapsulamiento_
![sinencap](https://user-images.githubusercontent.com/47732464/53306394-6466d000-3841-11e9-9c42-1dc0afa1fd3c.JPG)

### _Sistema con encapsulamiento_
![clasecoche](https://user-images.githubusercontent.com/47732464/53306395-69c41a80-3841-11e9-8561-e080650f3c04.png)

![objeto automovil](https://user-images.githubusercontent.com/47732464/53306393-63ce3980-3841-11e9-97a2-00bf6185f060.png)

![coches](https://user-images.githubusercontent.com/47732464/53306418-b6a7f100-3841-11e9-9184-a92c9d5eb7c2.png)

## Herencia
La herencia es cuando, como su nombre lo dice, hacemos que una clase *_Herede_* los atributos y métodos de otra. A la clase de la cual se heredan atributos se llama *_Clase Padre_* y a la que hereda dichos atributos se le llama *_Clase Hija_*. A la clase hija podemos agregarle más atributos y métodos de los que ya obtuvo por medio de la herencia, esto con el proposito de no tener que copiar y pegar innecesariamente todo el código de una clase en otra.

![herencia1](https://user-images.githubusercontent.com/47732464/53305745-0edaf500-383a-11e9-8b59-85a6fdccceba.JPG)
![herencia2](https://user-images.githubusercontent.com/47732464/53305746-0edaf500-383a-11e9-92c5-8cd55e94e9e5.JPG)

# Historia de UML
**"The Three Amigos"** (los tres amigos) de la ingeniería de software, como se los conocía, habían desarrollado otras metodologías. Se asociaron para brindar claridad a los programadores creando nuevos estándares. La colaboración entre Grady, Booch y Rumbaugh fortaleció los tres métodos y mejoró el producto final.

Los esfuerzos de estos pensadores derivaron en la publicación de los documentos UML 0.9 y 0.91 en 1996. Pronto se hizo evidente que varias organizaciones, incluidas Microsoft, Oracle e IBM, consideraron que UML era esencial para su propio desarrollo de negocios. Ellos, junto con muchas otras personas y compañías, establecieron los recursos necesarios para desarrollar un lenguaje de modelado hecho y derecho. "Los tres amigos" publicaron la Guía del usuario para el Lenguaje Unificado de Modelado en 1999, y una actualización que incluye información sobre UML 2.0 en la segunda edición de 2005.
