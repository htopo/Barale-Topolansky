# Explicación del tablero y su vínculo con el proceso de ingeniería

En el proceso de ingeniería, hablamos de los pasos que vamos a seguir para lograr el desarrollo de las nuevas funcionalidades. Este proceso fue finalmente concluido en un tablero. En este documento vamos a ir en profundidad en cuanto al flujo de los tickets en el tablero y el significado de cada columna.

## Backlog:

Esta columna actúa como una lista de pendientes priorizada. Aquí se agregan issues que contienen en su descripción los nuevos requerimientos tal cual fueron entregados al equipo. El product owner es responsable de priorizarlos. Una vez priorizados, el PO toma la tarea más prioritaria y en base a esta lleva a cabo la fase de definición de requerimientos (CCC). Una vez los requerimientos están definidos, el issue correspondiente es quitado de esta columna, y marcado con la label “Addressed”.
Para aclarar, esto significa que estos issues ya no serán parte del tablero, dado que en la columna CCC, se crean otros issues que son los que van a ser usados en el flujo.

## CCC:

En esta columna comienza el trabajo sobre los issues con los que vamos a tratar en esta entrega, dado que son features. En la fase de definición de requerimientos, el desarrollador genera para cada user story, un issue en el tablero para la parte de frontend y otro para la parte de backend. Estos representan “sub issues” (Github no permite agregar “sub issues”, por lo que estos deben ser referenciados mediante links en el issue de la user story.) correspondientes al issue de la user story, y son estos los que van a aparecer en nuestro tablero, mientras que el issue de la user story no va a ser utilizado en el tablero.
Deben usar la label correspondiente (Frontend o Backend) y dentro de cada uno el desarrollador puede tomar notas o consideraciones a tener en cuenta para la implementación.

## Test Cases Implementation:

Es importante notar que los tickets de frontend no van a pasar por esta columna, dado que vamos a implementar casos de prueba solamente para el backend, como se describe en el documento del proceso de ingeniería.
Los issues de backend son movidos hacia esta columna cuando un desarrollador es asignado (Cualquier miembro de nuestro equipo puede auto asignarse un issue o asignarse a otro). Una vez la implementación de los casos de prueba está completa, el ticket de backend el issue pasa a application implementation.

## Application implementation:

Los issues de frontend pasan de CCC directamente a esta columna cuando un desarrollador es asignado a la tarea, mientras que los de backend vienen de la columna anterior, por lo que los tickets de front end siempre llegan antes que los de backend a esta columna.
En la entrega anterior, como usábamos TDD, habíamos decidido juntar esta columna con la anterior, dado que en la práctica, consideramos que el límite entre las dos etapas es difuso. Para esta entrega, al ser BDD el marco de trabajo, el límite se vuelve más claro y eso motivó a independizar esta columna de la anterior.

## Refactoring & Peer Review:

Para que una tarea sea movida en el tablero a esta columna, el desarrollador asignado debe crear un pull request en github, de la rama feature correspondiente a develop. Se mueven en conjunto las tareas de backend y frontend asociadas al pull request hacia esta columna.
En esta fase se analiza tanto el código escrito como los tests generados y se decide si se deben aplicar mejoras para favorecer la mantenibilidad, performance o cualquier otro atributo de calidad qué aplique. Si aplica, se realiza un refactor del código, de no aplicar, las tareas pasan a Done.
Este análisis lo hace por una parte el desarrollador responsable de la tarea, y por otra parte, otro desarrollador del equipo que revisa el código escrito, también considerando aspectos relacionados a clean code y a los estándares de codificación de los lenguajes utilizados. De encontrar aspectos a mejorar, este último los deja como comentarios en el pull request.

## Done:

Por último, para una tarea pasar a esta columna, el pull request creado en la columna anterior debe estar aprobado al menos por un miembro del equipo distinto al desarrollador asignado a la tarea, y haber corrido con éxito las acciones. Es entonces cuando el pull request es mergeado a develop por cualquier miembro del equipo. Las tareas de backend y frontend asociadas al pull request son movidas en conjunto hacia esta columna.
Como consecuencia, a esta columna pasan las tareas para las cuales ya no hay trabajo a ser realizado, o al menos por el momento no se conocen errores o partes faltantes en la implementación.

En conclusión, tenemos un flujo distinto para tickets de backend y de frontend, que explicamos en detalle para cada columna del tablero. De todas formas, estos comienzan juntos en CCC y terminan juntos en Done.
