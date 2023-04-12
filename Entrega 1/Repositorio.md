## Repositorio


### Branching

Creamos un repositorio en GitHub, cuyo enlace se encuentra al inicio del informe.

El modelo de ramificación que utilizaremos es GitFlow, el cual consiste en utilizar dos ramas principales:

* Main: Es la rama principal que contiene el código estable y listo para ser liberado.
* Develop: Es la  que se utiliza como base para el desarrollo del software. Se utiliza para el trabajo en curso y para integrar cambios de diferentes ramas de características.

### Gitflow

El flujo de trabajo para añadir nuevas características al repositorio es el siguiente:

1. Se crea una nueva rama desde develop, cuyo nombre debe seguir el siguiente formato: (tipo de cambio)/(nombre del cambio), por ejemplo: feature/nombre-del-ticket, bugfix/nombre-del-ticket, hotfix/nombre-del-ticket.
2. Se desarrolla la característica en la rama.
3. Se hace pull request a develop en donde se debe especificar brevemente lo que se hizo en la rama y las decisiones de diseño que se tomaron al realizar dichos cambios. Acto seguido, se requiere una revisión de código de parte de una persona distinta a la que realiza el requisito,y si se aprueban los cambios, se hace merge a develop. Esto se asegura con una configuración de github, que no permite mergear pull requests que no hayan sido aprobadas.

### Commits

Para mantener el repositorio consistente y prolijo, decidimos utilizar convenciones para los commits. Los vamos a escribir en idioma español, utilizando el imperativo.

Ejemplo correcto: “Agregar x cosas”

Ejemplo incorrecto: “Agregue x cosas”
