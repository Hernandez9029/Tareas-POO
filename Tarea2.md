# Tarea 2
Aqui se encuentran los trabajos de la tarea 2

## 2.1 Declaración de clases: atributos, métodos, encapsulamiento
#### Clases y estructuras
Las clases y estructuras se usan el la POO y son estructuras que encapsulan datos, dichos datos son parte de estas clases o estructuras y son lo que conocemos como **_atributos y métodos_**. Estas clases o estructuras se utilizan para crear objetos, declarando variables y asignandole a estas los datos de la clase, funciona como un raferencia. Se utiliza la clase como un tipo de dato, de esta manera, un objeto de la clase "Person" **(suponiendo que creamos una clase con ese nombre)** es del **_tipo de dato_** Person, el objeto en cuestion es una variable que podemos declarar con el nombre que queramos.

#### Encapsulamiento
Es una manera de proteger los datos de una clase o estructura, especificando de que manera se puede acceder a los datos o no. No esta previsto el uso de métodos y variables fuera de una clase para alterar la misma, de esta manera se preven muchos posibles errores.

#### Miembros
Los métodos, propiedades, eventos y constructores se declaran dentro de un tipo de dato **(una clase)** y a esos datos de les llama **_"Miembros"_** de la clase. Una lista de los tipos de miembros:
+ Campos
+ Constantes
+ Propiedades
+ Métodos
+ Constructores
+ Eventos
+ Finalizadores
+ Indizadores
+ Operadores
+ Tipos anidados

#### Accesibilidad
Existen métodos y propiedades que se crean con el fin de invocarlos fuera de la clase o estructura **(se le llama códido de cliente)**, mientras que otros se crean para usarse únicamente dentro de la clase o estructura. El que se hará con los métodos o propiedades se llama **_Accesibilidad_**, como se podrá suponer, es definir si se tendrá acceso con los datos fuera de la clase o no. Esto sirve para el caso que necesites accesar a datos desde fuera de la clase a pesar de estar encapsulados. Se define el tipo de accesibilidad con los **_Modificadores de acceso_** public, protected, internal, protected internal, private y private protected, el que más se usa es private.

#### Herencia
Se trata de una clase que adquiere todos los miembros de otra **(excepto constructores y destructores)**. Puedes declarar las clases de diferentes maneras, para cambiar cosas como que un método de la clase no tenga implementación **(se hace con abstract)** o que no se pueda heredar de ella **(declarandola con sealed)**. A una clase que hereda puedes agregarle más miembros, la herencia es para no tener que copiar código en quien sabe cuantas clases, creando una clase base que tenga miembros que necesites en otras.

#### Interfaces
También se puede heredar **_interfaces_**. Las clases y estructuras heredan todos los métodos de dicha interfaz. Mediante ella puedes hacer cosas como incluír varios miembros de algunas clase.

#### Tipos genéricos
Implementan el concepto de parámetros de tipo que aplazan la declaración del tipo de una clase o método, de esta manera se permiten varios tipos usando una sola clase.

#### Tipos estáticos
Las clases pueden declararse como **_static_** y dicha clase solo puede contener miembros estáticos y no se puede usar el _new_ para crear una instancia de ellas. Los miembros de la clase estática son accesibles de manera _"global"_ en cualquier parte del programa usando su nombre.

#### Tipos anidados
Independientemente de si es una clase o estructura, el tipo anidado se establece de manera predeterminada con private. También puedes ponerles un modificador de acceso como public, protected, internal, protected internal, private o private protected.

#### Tipos parciales
Con ellos puedes definir parte de una clase, estructura o método en dos diferentes archivos de código, una parte en un archibo y la otra en otro independiente del primero.

#### Inicializadores de objeto
Con ellos se crean instancias de objetos **(o conjuntos de objetos)** de alguna clase o estructura para inicializarlos sin llamar explícitamente a su constructor.

#### Tipos anónimos
Se utilizan cuando es innecesario o de plano es inconveniente crear una clase con nombre, como al crear una lista de estructuras de datos que no se conservan.

#### Métodos de extensión
Permiten agregar métodos a las clases existentes sin crear otra clase completamente nueva que derive de esta. Se les llama como si fueran métodos de instancia.

#### Variables locales con asignación implícita
Son variables locales que no especifican de que tipo son. Para hacer esto, se inicializan con _**var**_, esto le dice al compilador que infiera el tipo de la variable usando las expresiones u operaciones que realize dicha variable, basicamente, mira sus datos y con base a ellos le asigna un tipo de variable.

## 2.2 Instanciación de una clase
Cuando se crean una clase, a momento de crear un objeto referenciando a dicha clase, se dice que se crea un objeto del _**tipo**_ de esa clase, para la creación de estos objetos se usa el _**new**_ que indica de que tipo es el objeto que se esta creando.

## 2.3 Referencia al objeto actual

        public Contacto(string nombre, string co, string cel)
        {
            this.nombre = nombre;
            correo = co;
            celular = cel;
        }

        public void imprime()
        {
            Console.WriteLine("{0}, {1}, {2}", nombre, correo, celular);
        }
## 2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.
Se pueden declarar los parámetros para un método mediante **palabras clave** como params, in, ref y out. De esta manera pueden cambiar el comportamiento de los parámetros, para, por ejemplo, los siguientes casos:

+ **Params:** Este define que un parámetro tomará un número variable de argumentos.
+ **in:** El parámetro se pasará por medio de referencia, sin embargo, solo se podrá leer con el método llamado.
+ **ref:** Indica que un parámetro se pasa mediante referencia y no mediante un valor.
+ **out:** Hace que los argumentos pasen por referencia, se diferencia de ref porque esta no requiere que se inicialice la variable antes de pasarla.

 ## 2.5 Constructores y destructores: declaración, uso y aplicaciones.
Los constructores no son nadamas que métodos pertenecientes a una clase, cuando se hace la herencia entre clases no se heredan los constructores, pero puedes heredar construtores de otra manera. Los constructores tienen el nombre de la clase a la que pertenecen e inicializan los miembros de la misma, puedes crear varios constructores con el mismo nombre, mientras los miembros que se inicialicen sean diferentes. Un constructor predeterminado es aquel que no toma ningún parámetro. A menos que la clase sea **static** a una clase sin constructor se le asigna uno predeterminado automaticamente. puedes convertir el constructor a pruvado para evitar que se creen instancias de clase. Cuando se trata de constructores para los tipo **struct** no se puede tener un constructor predeterminado, el compilador ya lo proporciona, este constructor inicializa los campos del struct con los valores predeterminados. Se puede alterar el constructor con los modificadores de acceso **public, private, protected, internal o protectedinternal** para definir como se construye la clase.
