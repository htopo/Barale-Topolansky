# Issues

### Labels

Para los issues, definimos inicialmente 7 labels que nos van a ayudar a identificar rápidamente el contexto del issue. Los issues podrán tener tantos labels cómo le correspondan.

![](https://lh5.googleusercontent.com/GOmlfSMmmwFsGNaTAYPBvaXkQUZThz4fRAf0EnxXeRYSdsQpnsQkR_U6zggY-Behm6SMw6Csus-uir4EqPXpRUzY4aWNvVg0XnirN7eP9gYgdfGdjMlNSwG0G-pER9sWAKo_HAalnijvpGPoqhu6yVg)Ejemplo: Un issue podría ser un bug de frontend, que necesite más información para ser accionable.

### Severidad de issues

Para que el tester pueda asignar una severidad a los issues, definimos 4 labels que representan la severidad de los mismos. Estos labels son:
Critico, Mayor, Menor y Leve, por lo tanto, además de los labels definidos anteriormente, cada issue va a tener su correspondiente label de severidad.

### Prioridad de issues

Una vez que el tester haya asignado una severidad a los issues, el product owner asignará una prioridad a los mismos. Para esto, una vez listados los issues, el product owner los ordenará de mayor a menor prioridad, y se asignará un número a cada issue, de acuerdo a su posición en la lista. Por ejemplo, si el issue con mayor prioridad es el número 1, el issue con menor prioridad será el número 4. Según nuestro criterio de prioridad, una prioridad 1 implica que es un issue que perjudica la funcionalidad de la aplicación, y que debe ser resuelto lo antes posible. Una prioridad 4 implica que es un issue que no perjudica la funcionalidad de la aplicación, y que puede ser resuelto en un futuro.

## Identificación de issues

Para la búsqueda de issues, principalmente nos basamos en 3 aspectos en la solución:

1. Buscamos en la usabilidad del frontend, simulando ser un usuario, en búsqueda de bugs, inconsistencias, o cosas a mejorar que podrían facilitar el uso de la aplicación
2. Analizamos la arquitectura de la solución, para encontrar aspectos a mejorar en cuanto a patrones de diseño y buenas prácticas.
3. Utilizamos alguna herramienta para analizar el código y ver posibles incumplimientos de principios de clean code y estándares propios de los lenguajes/frameworks utilizados.

### Issues encontrados


- 1. Para ciertos roles de usuario no se precargan los datos personales en la sección Mis datos, y para dichos casos no se puede ingresar información, ya que da un internal server error.
- 1. No funciona el registro de usuarios.
- 2. Si se inicia una sesión como rol artista, no se puede cerrar sesión.
- 2. El importador/exportador de conciertos no funciona.
- 3. Utilizar estándares de codificación.
- 3. Mejorar manejo de excepciones.
- 3. Al cambiar la contraseña de un usuario o sus datos, no redirecciona a la página principal, lo cual es confuso para el usuario y poco intuitivo, ya que normalmente un usuario solo cambia su contraseña o datos una vez.
- 3. Al intentar crear un usuario, concierto, solista o usuario y no se ingresan todos los datos, el sistema no muestra un mensaje de error que no especifica nada y dice [object Object].
- 3. Se exponen los ids de las entidades en la página.
- 3. No existe un botón para volver, lo cual no hace que la navegación sea intuitiva.
- 4. Refactorizar la api.
- 4. Mejorar la generación de tokens.
- 4. Refactiorizar la capa de data access.
- 4. Corregir errores de gramática.
- 4. Corregir inconsistencias en el lenguaje de la aplicación.
- 3. Al cambiar la contraseña de un usuario, se limpian los campos contraseña anterior y nueva contraseña, pero no el campo confirmar contraseña.


