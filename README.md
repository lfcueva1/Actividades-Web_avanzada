# Actividades-Web_avanzada
Tareas web avanzada
Este proyecto es una aplicación de consola simple en C# que demuestra el uso de herencia y 
polimorfismo en la programación orientada a objetos. La aplicación incluye las clases Empleado, 
Gerente, y la interfaz IMostrarInformacion.

Estructura del proyecto
IMostrarInformacion.cs: Este archivo contiene la definición de la interfaz IMostrarInformacion, que proporciona un método MostrarInformacionGeneral para mostrar información general de un objeto.
Empleado.cs: En este archivo, se encuentra la implementación de la clase Empleado, que implementa la interfaz IMostrarInformacion. La clase Empleado tiene propiedades como Nombre y Salario y un 
método para mostrar información general del empleado.

Gerente.cs: Este archivo contiene la implementación de la clase Gerente, que hereda de la clase Empleado e implementa la interfaz IMostrarInformacion. Además de las propiedades de un empleado 
regular, un gerente tiene una propiedad adicional llamada Departamento. También se proporciona una implementación específica del método MostrarInformacionGeneral para mostrar información de un 
gerente.

Program.cs: Este archivo contiene el punto de entrada principal del programa. Se crea una instancia de Empleado y otra de Gerente, y se llama a un método que demuestra el uso del polimorfismo al 
mostrar información general de diferentes tipos de empleados.

Como usar mi proyecto
1. Descarga el codigo en tu maquina local
2. Abre el proyecto en tu entorno de desarrollo C# preferido.
3. Compila y ejecuta la aplicación.
