Feature: Crear snack
    Como administrador del sistema
    Quiero poder eliminar un snack
    Para poder mantener actualizado el catálogo de productos

@eliminarSnack
Scenario: Eliminar un snack correctamente
    Given El nombre "Doritos"
    When Elimino un "Snacks" con ese nombre
    Then Veo el mensaje de éxito con el código "200"
