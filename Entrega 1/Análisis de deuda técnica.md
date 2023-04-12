# Análisis de deuda técnica

Para este análisis, llevamos a cabo dos actividades:

* Testing exploratorio
  * Testear la aplicación en busca de posibles bugs y puntos de mejora.
* Análisis del código
  * Analizar el código fuente de la aplicación en busca de malas prácticas, incumplimientos de clean code o principios de diseño, inconsistencias o posibles bugs. Separando el análisis en backend y frontend.

A medida que se ejecutaron estas actividades, fuimos generando issues en el repositorio, donde se puede ver en detalle la deuda técnica encontrada.


## Testing exploratorio

* Objetivo: Evaluar el funcionamiento de la aplicación e identificar errores en caso de haberlos.
* Fecha: 10/04/2023
* Tester: Agustin
* Descripción de la tarea: Se usará la aplicación, simulando ser usuarios de distintos roles, intentando usar las diferentes características que provee la aplicación, de esta manera podremos identificar errores y reportarlos.
* Duración: 3 horas.
* Ambiente de Prueba: Windows 10, Chrome
* Conclusiones: Se intentó simular diferentes casuísticas de uso de la aplicación, y se encontraron varios errores, los cuales se describen y categorizan a continuación (algunos de los errores pueden pertenecer a más de una categoría):

### Errores de inconsistencia en el idioma de la aplicación:

Se encontraron varias inconsistencias en el idioma de la aplicación, ya que en algunos casos se encontraban textos en inglés, y en otros en español. Los errores encontrados son los siguientes:

- En los filtros dice filters en lugar de filtros.
- Boton de inicio de sesión en inglés.
- Error de inicio de sesión al ingresar datos incorrectos en inglés.
- Al cambiar la contraseña de un usuario, al intentar utilizar la contraseña anterior, el sistema muestra un error en inglés que dice "The password is incorrect".
- Al intentar borrar algo, ya sea un concierto, un artista, un genero, una banda, un solista o un usuario, los botones de confirmar o cancelar el borrado están en inglés.
- En la sección de mis datos, dice change data, en lugar de cambiar datos.
- En la sección de cambiar contraseña, dice change password, en lugar de cambiar contraseña.

### Errores gramaticales:

- Falta tilde en Administración.
- En la confirmación del borrado, al texto "Estas seguro que deseas borrar?" le falta el signo de apertura de interrogación.
- Falta el tilde en la palabra Género en casi todos lados, a excepción del botón que lleva a la sección de géneros.
- Cuando se ingresa a la pantalla para agregar algo, el titulo dice insertar en lugar de agregar.

### Errores de usabilidad:

- No funciona el registro de usuarios.
- Al cambiar la contraseña de un usuario, se limpian los campos contraseña anterior y nueva contraseña, pero no el campo confirmar contraseña.
- Para ciertos roles de usuario no se precargan los datos personales en la sección Mis datos, y para dichos casos no se puede ingresar información, ya que da un internal server error.
- El importador/exportador de conciertos no funciona.
- Al cambiar la contraseña de un usuario o sus datos, no redirecciona a la página principal, lo cual es confuso para el usuario y poco intuitivo, ya que normalmente un usuario solo cambia su contraseña o datos una vez.
- Si se inicia una sesión como rol artista, no se puede cerrar sesión.

### Errores de interfaz:

- Al intentar crear un usuario, concierto, solista o usuario y no se ingresan todos los datos, el sistema no muestra un mensaje de error que no especifica nada y dice [object Object].
- Se exponen los ids de las entidades en la página.
- Al cambiar datos de un usuario, sin ingresar nuevos datos, se muestra un mensaje de éxito.
- No existe un botón para volver, lo cual no hace que la navegación sea intuitiva.

## Análisis de calidad de código de frontend

Para este análisis utilizamos la herramienta tslint, que es un analizador estático de código para typescript.

En general se encontraron una gran cantidad de inconsistencias en el código. El resultado de la ejecución de tslint muestra que este proyecto de angular fue desarrollado sin linters y sin respetar estándares de código bien definidos.

La lista de inconsistencias es muy larga y no aportaría valor listarla completa en este documento, pero en general encontramos lo siguiente:

* Hay strings usando comillas dobles en algunos archivos y comillas simples en otros, lo cual resulta en un código inconsistente.
* Hay un mal uso de los tipos de variables. Más específicamente, se utiliza “var” o “let” para valores que nunca cambian, donde debería utilizarse “const”.
* En el código se encuentran logueos a consola (console.log), los cuales son utilizados por los desarrolladores para encontrar bugs, pero no es deseable que queden permanentemente en la aplicación porque no son de utilidad para el usuario.
* El uso del punto y coma es inconsistente, falta punto y coma en muchos lugares.
* Hay muchos espacios vacíos al final de las líneas.

Fue creado el issue “Utilizar estándares de código”, que detalla los puntos anteriores para darle seguimiento a estos problemas.


## Análisis de calidad de código de backend

En cuanto al manejo de excepciones, observamos que se captura una excepción de tipo “Exception”, es decir, una excepcion genérica. Esto no es deseable porque no permite identificar el tipo de excepción que se está capturando y manejar cada error de la forma correspondiente, lo cual empobrece el manejo de errores.

En algunas partes de la aplicación se encontró código repetido, lo cual se debe evitar. Esto se puede solucionar introduciendo abstracciones que permitan reutilizar código. Por ejemplo, esta solución aplica en data access, donde todas las clases implementan un metodo identico llamado "Save".

En cuanto a data access, salvo por el codigo repetido mencionado anteriormente, no se encontraron grandes problemas de calidad de código, aunque si notamos cierta logica minima que deberia ser movida a la capa de negocio.

En cuanto a la api, se encontró un uso redundante de los filtros ciertos casos. Por ejemplo en ArtistsController, el filtro de excepciones se aplica a todo el controller y a su vez al metodo GetArtistById, lo cual no es necesario dado que ya se aplica al controller.

Por otro lado, se encontró un posible riesgo de seguridad en la api, dado que el token de las sesiones es generado por la función GenerateRandomToken() que utiliza la función Random() de C#. Esta función genera números pseudoaleatorios que son predecibles, lo que facilita a los atacantes adivinar el token. Además, el conjunto de caracteres utilizado para generar el token no es suficiente.

Se crearon los siguientes issues para darle seguimiento a estos problemas de backend:

* “Mejorar manejo de excepciones” - Para no capturar excepciones genericas.
* “Refactorizar data access” - Para resolver el problema de código repetido.
* “Refactorizar api” - Para quitar la redundancia en los filtros.
* “Mejorar generación de tokens” - Para mejorar la seguridad en la generación de tokens.
