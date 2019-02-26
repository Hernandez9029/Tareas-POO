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
Es una manera de esconder los datos (atributos y métodos) en los llamados objetos. Esto para evitar problemas de dependencia de un fragmento de código con otro, o sea, para modularizar el código. De esta manera, se tiene el código separado en pequeños fragmentos **_"Independientes"_**, aunque no son realmente 100% independientes, de serlo, no interactuarían con el código y serían inutiles, lo que se intenta es que estos fragmentos esten lo menos conectados posible **_-no que no lo esten-_** para no depender tanto de otros, y de esta manera, al cambiar un dato en algún fragmento, esto no afecte en todo el código, la importancia de esto se aprecia en códigos grandes.

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
**UML** _(Lenguaje Unificado de Modelado)_ comenzó a gestarse en 1994, cuando Jim Rumbaugh se unió a la compañía Rational Software Corporation fundada por Grady Booch, dos respetados investigadores en el área de desarrollo de notaciones para el análisis y diseño de sistemas orientados a objetos, cuya herramienta era Rational Rose.

El objetivo de los dos investigadores era unificar dos métodos que habían desarrollado: el método Booch, que describe conjunto de objetos y sus relaciones  y el OMT (Object Modelling Tool) de Rumbaugh, orientada a objetos,  que combinaban notaciones provenientes de modelado orientado a objetos, a datos, a componentes y a flujos de trabajos. En esa misma época otro reputado investigador,  Ivar Jacobson,  cuya metodología es más centrada al usuario y a casos de uso (use case), se unió  a Rational Software y se incluyeron ideas suyas. Estas tres personas son conocidas como los “tres amigos”. Construyeron lo que hoy conocemos como UML.

Este lenguaje manejaba diversos métodos, técnicas y aspectos en común pero utilizando diversas notaciones; inconvenientes para el aprendizaje, aplicaciones y uso de herramientas y además competía entre distintos enfoques, por lo tanto debía establecer una notación estándar. Que se fue fomentando hasta lograr la aceptación de **OMG** _(Grupo de administración de objetos)_ como notación estándar, el estándar líder en la industria para la programación de objetos distribuidos, quienes lo adoptaron para el análisis y el diseño orientado a objetos.

Es el primer método en publicar su propia notación, incluyendo la notación para la mayoría de la información de requisitos, análisis y diseño. El lenguaje de modelado unificado se usa para entender, diseñar, configurar, mantener y controlar la información sobre los sistemas a construir. Y pretende unificar las experiencias pasadas sobre técnicas de modelado e incorporar las mejores prácticas actuales en un acercamiento estándar.

## Tipo de sistema en que se utiliza UML

Los lenguajes orientados a objetos dominan el mundo de la programación porque modelan los objetos del mundo real. UML es una combinación de varias notaciones orientadas a objetos: diseño orientado a objetos, técnica de modelado de objetos e ingeniería de software orientada a objetos.

UML usa las fortalezas de estos tres enfoques para presentar una metodología más uniforme que sea más sencilla de usar. UML representa buenas prácticas para la construcción y documentación de diferentes aspectos del modelado de sistemas de software y de negocios.

## Tipos de diagramas UML

UML usa elementos y los asocia de diferentes formas para formar diagramas que representan aspectos estáticos o estructurales de un sistema, y diagramas de comportamiento, que captan los aspectos dinámicos de un sistema.

### Diagramas UML estructurales

+ __Diagrama de clases:__ El diagrama UML más comúnmente usado, y la base principal de toda solución orientada a objetos. Las clases dentro de un sistema, atributos y operaciones, y la relación entre cada clase. Las clases se agrupan para crear diagramas de clases al crear diagramas de sistemas grandes.

+ __Diagrama de componentes:__ Muestra la relación estructural de los elementos del sistema de software, muy frecuentemente empleados al trabajar con sistemas complejos con componentes múltiples. Los componentes se comunican por medio de interfaces.

+ __Diagrama de estructura compuesta:__ Los diagramas de estructura compuesta se usan para mostrar la estructura interna de una clase.

+ __Diagrama de implementación:__ Ilustra el hardware del sistema y su software. Útil cuando se implementa una solución de software en múltiples máquinas con configuraciones únicas.

+ __Diagrama de objetos:__ Muestra la relación entre objetos por medio de ejemplos del mundo real e ilustra cómo se verá un sistema en un momento dado. Dado que los datos están disponibles dentro de los objetos, estos pueden usarse para clarificar relaciones entre objetos.

+ __Diagrama de paquetes:__ Hay dos tipos especiales de dependencias que se definen entre paquetes: la importación de paquetes y la fusión de paquetes. Los paquetes pueden representar los diferentes niveles de un sistema para revelar la arquitectura. Se pueden marcar las dependencias de paquetes para mostrar el mecanismo de comunicación entre niveles.

## Herramientas para el modelado de UML

Una herramienta UML es una aplicación de software que utilizan los analistas y programadores informáticos, les facilitan el trabajo con todo tipo de diagramas UML, tales como diagramas de estructura, diagramas de comportamiento o diagramas de interacción.

**Algunas herramientas son:**
+ Lucidchart
+ MagicDraw
+ Papyrus UML
+ Modelio
+ StarUML

