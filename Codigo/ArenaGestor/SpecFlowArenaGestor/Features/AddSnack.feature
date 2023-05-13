Feature: Crear snack
    Como administrador del sistema
    Quiero poder agregar un nuevo snack con descripción y precio obligatorios 
    Para poder verlo en el sistema

@creacionValida
Scenario: Crear válido con todos los datos
    Given El nombre "Doritos"
    And El precio "200"
    When Creo un "Snacks" con esos valores
    Then Veo el mensaje de éxito con el código "201"