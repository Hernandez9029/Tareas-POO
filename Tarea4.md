### 1.1. ¿Qué valores imprimen las lineas (1) y (2) ?
Regresa 10 y 10.
### 1.2.  Redefine el método Display en el espacio indicado, una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2) ?
10 y 15.
### 1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?
Virtual.

### 2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?
El método **Afina** esta con **void**, se le debe cambiar a **string**, de lo contrario no se reconocera el tipo de dato del nombre.

### 2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?
El método Display y el método Afina, retornan los valores que deseamos imprimir, el nombre del musico y si este afina.

### 2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?
No se le ponen porque al ser un método abstracto no tiene **cuerpo ó llaves**. Si lo ponemos como virtual entonces si se podría.

### 2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?
Nesecitará que le pongamos llaves y retorne un valor.
