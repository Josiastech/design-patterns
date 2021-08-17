# Patrones de diseño C#

## Singleton
Singleton es un patrón de diseño de creación que garantiza que solo exista un objeto de su tipo y proporciona un único punto de acceso a él para cualquier otro código.

El patrón tiene prácticamente los mismos pros y contras que las variables globales. Aunque son muy útiles, rompen la modularidad de su código.

No puede usar una clase que depende del Singleton en otro contexto. También tendrás que tomar la clase Singleton. La mayoría de las veces, esta limitación aparece durante la creación de la prueba unitaria.

## Prototype
Prototype es un patrón de diseño de creación que nos permite copiar objetos existentes sin el código dependiendo de sus clases.