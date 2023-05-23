# Métricas

### Nota:

Dado que en las entregas anteriores no registramos fecha de entrada al backlog, fecha de inicio de trabajo y fecha de fin, para esta entrega vamos a agregar esta información a los en los issues (tanto en los bugs como en las user stories).

Para esto, nos vamos a basar en:

* Las fechas correspondientes a la creación de cada issue, para la fecha de inicio de las user story, dado que esa es la fecha en la que se comenzó con CCC.
* Como se utilizó TDD para la corrección de bugs, usaremos las fechas correspondientes al primer commit para la fecha de inicio de los bugs.
* Las fechas de comienzo de la entrega correspondiente (para la fecha de entrada al backlog de los issues)
* Las fechas en las que el pull request correspondiente a la funcionalidad/bug fue mergeado. (Para la fecha de fin)

## Lead Time:

A la fecha de fin de cada issue le restamos la fecha en que fue agregado al backlog.

* (Bug) Logout artistas: 18/4/2023 - 12/4/2023 = 6 días
* (Bug) Botón para registrarse: 18/4/2023 - 12/4/2023 = 6 días
* (User story) Alta/Baja snacks: 12/5/2023 - 18/4/2023 = 24 días
* (User story) Compra de snacks: 23/5/2023 - 18/4/2023 = 35 dias
  Lead time promedio: 17,75 días
  Lead time promedio (bugs): 6 días
  Lead time promedio (User stories): 29,5 días

## Cycle Time:

A la fecha de fin de cada issue le restamos la fecha de inicio.

* (Bug) Logout artistas: 18/4/2023 - 18/4/2023 = 0 días, 15 minutos. (dado el registro de esfuerzo de la entrega 2)
* (Bug) Botón para registrarse: 18/4/2023 - 18/4/2023 = 0 días, 15 minutos. (dado el registro de esfuerzo de la entrega 2)
* (User story) Alta/Baja snacks: 12/5/2023 (fin del dia) - 12/5/2023 (comienzo del dia) =~ 1 dia
* (User story) Compra de snacks: 23/5/2023 - 20/5/2023 = 3 dias
  Cycle time promedio =~ (0.01 + 0.01 + 3 + 1)/4 = 1 día
  Cycle time promedio (bugs) = 0 días, 15 minutos
  Cycle time promedio (User stories) = 2 días

## Eficiencia de flujo:

La eficiencia de flujo se calcula como el touch time sobre lead time, pero como nosotros no registramos datos para calcular touch time, vamos a calcular flow efficiency haciendo cycle time sobre lead time, que es el estimado más cercano que podemos lograr con nuestros datos, dado que lead time >= cycle time >= touch time.

* (Bug) Logout artistas: 15 minutos/6 días = 0.01/6 = 0.0016
* (Bug) Botón para registrarse: 15 minutos/6 días = 0.0016
* (User story) Alta/Baja snacks: 1 dia/24 días = 0.0416
* (User story) Compra de snacks: 3 dias/35 dias = 0.0857

## Deployment frequency (Frecuencia de entrega):

El tiempo que consideramos para esto va desde la entrega de corrección de bugs (2) hasta esta entrega (4), lo que corresponde al periodo en que nuestro equipo entregó ya sean user stories o bug fixes. (Nota: en la entrega 4 nuestro equipo entregó la user story que faltaba de la entrega anterior).
Tenemos entonces:

* Entrega 2: 1 semana, 2 bug fixes
* Entrega 3: 2 semanas, 1 user story
* Entrega 4: 1 semana, 1 user story
  Total: 4 semanas, 4 deployments (entregas)
  Frecuencia de entrega: 4/4 = 1 entrega por semana
