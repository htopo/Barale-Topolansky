# Tablero y su vínculo con el proceso de ingeniería:

Para esta entrega encontramos que debíamos modificar nuestro proceso de ingeniería. Dado que vamos a trabajar con bugs identificados en el proyecto, el tablero ágil que definimos en la primera entrega ya no es suficiente porque no puede reflejar en profundidad el flujo de los tickets de reparación de bugs.

Es por esto que quisimos llevar nuestro proceso más hacia BDD, aunque con algunas consideraciones que tomamos a la hora de redefinir el tablero. Además de esto, dado que se va a estar programando y trabajaremos con pull requests en github, se sumará la columna `In review` justo antes de Done. Los detalles de esta columna se encuentran en el documento de configuración del pipeline y su vínculo con el tablero.

En primer lugar consideramos que un bug se produce por una falla en la implementación de un requisito bien definido, por lo que los tickets asociados a reparación de bugs no necesitan una columna para definir requerimientos. Es por esto que decidimos no utilizar la primera columna de BDD (CCC) en el nuevo tablero.

Por otro lado, BDD propone las etapas de “Test cases implementation” para el desarrollo de pruebas automáticas y “App implementation” para el desarrollo de la funcionalidad. Debido a esto, y a que vamos a utilizar TDD como método de desarrollo, decidimos unificar estas dos etapas en una columna llamada `TDD`. Creemos que de esta forma se representa mejor la realidad del trabajo, dado que si bien TDD implica que se comienza con los tests y se termina con el desarrollo, estas etapas tienen un límite que no es claro, siendo más bien una zona difusa.

El resto de las columnas que propone BDD las adoptaremos directamente. En definitiva, estaremos utilizando una adaptación de BDD que se refleja de la siguiente forma en nuestro tablero:

Backlog → TDD (Test cases & App implementation) → Testing → Refactoring In Review → Done
