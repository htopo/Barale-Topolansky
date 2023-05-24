Feature: Comprar snack
    Como espectador del sistema
    Quiero poder comprar un nuevo snack junto con el ticket 
    Para poder consumir en el concierto

@compraValida
Scenario: Comprar snack válido con todos los datos
    Given El id del concierto "4"
    And la cantidad de tickets "2"
    And el nombre del primer snack "Helado"
    And la cantidad del primer snack "2"
    And el precio del primer snack "100"
    And el nombre del segundo snack "Chocolate"
    And la cantidad del segundo snack "1"
    And el precio del segundo snack "50"
    When compro un "Tickets" con esos valores
    Then Veo como resultado el mensaje de éxito con código "200"