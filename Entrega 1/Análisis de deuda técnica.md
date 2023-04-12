# Análisis de deuda técnica

Para este análisis, llevamos a cabo dos actividades:

* Testing exploratorio
  * Testear la aplicación en busca de posibles bugs y puntos de mejora.
* Análisis del código
  * Analizar el código fuente de la aplicación en busca de malas prácticas, incumplimientos de clean code o principios de diseño, inconsistencias o posibles bugs. Separando el análisis en backend y frontend.

A medida que se ejecutaron estas actividades, fuimos generando issues en el repositorio, donde se puede ver en detalle la deuda técnica encontrada.

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
