# 1.0 Clase Base y Derivada
#### Clase Base
Se le llama de diferentes maneras, clase base, clase madre o clase padre, y es la clase de la cual heredarán otras clases (las clases derivadas), en la clase base se encuentran los atributos y métodos _"generales"_ que queremos que las demas clase tengan.

#### Clase Derivada
La clase derivada (también llamada clase hija) es la clase que hereda los métodos y atributos de la clase base, por eso el nombre de _"derivada"_, ya que deriva de la clase base. A partir de los atributos y métodos que herada la clase derivada se crean nuevos para el propocito que queramos, pero la heredación es para ahorrarnos el tener que repetir código.

 # 2.0 y 3.0 Diagrama UML 
 ![FiguraUML](https://github.com/Hernandez9029/Imagenes_POO/blob/master/umlclassFigura.JPG)

# 4.0 Herencia
#### Herencia simple
Es la _**"Herencia"**_ o el traspaso de los _miembros_ de una clase a otra, por miembros quiere decir los métodos y atributos entre otras cosas. Hay una clase base, esta es la clase de la cual otras clases van a heredar miembros, de esta forma se entiende que muchas clases pueden heredar de la misma clase, sin embargo, esto no es herencia multiple. **En C# no se hace herencia multiple, solo herencia simple.**

#### Herencia multiple
Es basicamente lo mismo que la herencia simple, la diferencia esta en la forma de heredar. Mientras en la herencia simple hay muchas clases heredando miembros de una sola clase base, en la herencia multiple hay una clase heredando miembros de varias clases al mismo tiempo.

# 5.2 Palabra base
Nos sirve para que un constructor herede de otro constructor, a diferencia de con **this**, con **base** se le dice al programa que se refiere al constructor de la clase base y no a otro constructor que pudiesemos tener con el mismo nombre.
