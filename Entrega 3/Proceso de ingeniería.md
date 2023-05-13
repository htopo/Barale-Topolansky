# Pequeña guia definición/uso del proceso de ing en el contexto de kanban

Para esta entrega encontramos que debíamos redefinir nuestro proceso de ingeniería. Dado que vamos a trabajar en el desarrollo de nuevas features, el [tablero que definimos en la entrega anterior](https://github.com/htopo/Barale-Topolansky/blob/main/Entrega%202/Tablero%20y%20proceso%20de%20ingenier%C3%ADa.md) ya no es suficiente, dado que en esta entrega queremos completar el ciclo de BDD. En este documento describimos los pasos que vamos a seguir, con el objetivo de instanciar un tablero a partir de ellos.

Comenzaremos con la fase de definición de requerimientos. Este paso comienza cuando el equipo toma acción sobre los nuevos requerimientos que le fueron entregados. Con estos requerimientos, nuestro product owner genera un issue en el repositorio y entrega de esta forma al equipo la user story en forma de narrativa, que tiene un título y una descripción del feature usando el template de “como, quiero, para”.
Con esto a la vista, un desarrollador conversa con el product owner y genera (también en la issue) los criterios de aceptación en forma de escenarios, que incluyen un título, y una descripción usando el template “dado, cuando, entonces”.
El resultado de este paso es una nueva issue en github con la user story completa, incluyendo narrativa y escenarios.

El paso implementación de casos de prueba comienza cuando se tiene la user story completa, producto del paso anterior. Un desarrollador de nuestro equipo crea una branch nueva e implementa ahí los casos de prueba en specflow (para la parte de backend) en función de la user story.
Como resultado de este paso, obtenemos los casos de prueba implementados para la nueva funcionalidad en lenguaje Gherkin.

Cuando se tiene el resultado del paso anterior, comienza el paso de implementación de la aplicación. Aquí un desarrollador escribe el código necesario en .NET Core (C#) y Angular (js) para cumplir los objetivos de la funcionalidad y pasar los casos de prueba del paso anterior en el caso del backend. Como resultado de esta fase, tenemos frontend y backend funcionando de la nueva feature.

Con la feature ya implementada, el desarrollador corre los tests automáticos y se asegura que pasen. Si estos no pasan, corrige la implementación para que pasen.

Todo esto se traduce finalmente al tablero, que describimos en el documento de explicación del tablero y su vínculo con el proceso de ingeniería.
