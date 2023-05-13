## Configuración del pipeline y su vínculo con el tablero

Cuando un ticket pasa de `Application implementation` a `Refactoring & Peer Review`, el desarrollador a cargo debe abrir un pull request en github, desde la rama en la que se está trabajando a `develop`.

Al abrirlo, el desarrollador se encuentra con que deben cumplirse dos condiciones para poder hacer el merge. Estas condiciones son reglas que agregan al repositorio en github. En primer lugar, las github actions configuradas deben terminar de ejecutarse y tener un resultado exitoso. Estas consisten en disparar un build y los tests automáticos, por lo que no debe haber errores de compilación y deben pasar todos los tests.

Por otro lado, un miembro del equipo distinto al creador del pull request, debe revisar los cambios en el código para dejar comentarios en caso de tener alguna sugerencia o encontrar algún error/mala práctica, o aprobar los cambios para permitir hacer merge. Una vez se cumplen estas dos condiciones, el desarrollador a cargo hace merge con develop y la tarjeta pasa de `Refactoring & Peer Review` a `Done`.
