Feature: Borrar snack
    Como administrador del sistema
    Quiero poder eliminar un snack
    Para poder mantener actualizado el catálogo de productos

@eliminarSnack
Scenario: Eliminar un snack correctamente
    Given Un snack con el nombre "lays"
    When Elimino un "Snacks" con ese nombre
    Then Veo el mensaje de éxito con el código "200"
