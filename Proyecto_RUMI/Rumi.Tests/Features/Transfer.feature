Feature: Transfer

Como usuario del sistema
Quiero poder transferir fondos a otros usuarios
Para poder compartir mi dinero

@tag1
 Scenario: Transferencia exitosa
        Given que soy un usuario con saldo de 1000
        When realizo una transferencia a 2 de 500
        Then el saldo de mi cuenta debería ser 500
        Then debería ver un mensaje de éxito

 Scenario: Transferencia con saldo insuficiente
        Given que soy un usuario con saldo de 100
        When realizo una transferencia a 2 de 500
        Then el saldo de mi cuenta debería ser 100
        Then debería ver un mensaje de Saldo insuficiente

 Scenario: Transferencia a usuario inexistente
        Given que soy un usuario con saldo de 1000
        When realizo una transferencia a 9999 de 500 // ID de usuario inexistente
        Then el saldo de mi cuenta debería ser 1000
        Then debería ver un mensaje de Receptor no encontrado

 Scenario: Transferencia a si mismo
        Given que soy un usuario con saldo de 1000
        When realizo una transferencia a 1 de 500 // Transferencia a si mismo
        Then el saldo de mi cuenta debería ser 1000
        Then debería ver un mensaje de El usuario no es válido

 Scenario: Superar limite de transferencias
        Given que soy un usuario con saldo de 1000
        When realizo una transferencia a 2 de 500
        And realizo una transferencia a 3 de 500
        And realizo una transferencia a 4 de 500 // Simula superar el límite (ajusta según tu límite)
        Then el saldo de mi cuenta debería ser 0 // Si el límite se maneja correctamente
        Then debería ver un mensaje de Se ha superado el límite de transferencias
