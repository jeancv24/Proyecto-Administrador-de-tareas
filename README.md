# Proyecto Administrador de tareas

### Descripci�n:
Esta es una aplicaci�n de escritorio para administrar tareas, creada con C# y WinForms, utilizando SQLite como base de datos para la persistencia y el patr�n MVVM para la separaci�n de la l�gica de negocio, la interacci�n con la base de datos y la vista.

### Caracter�sticas:
Agregar, Editar y Eliminar Tareas con los siguientes campos:

- Descripci�n: Campo obligatorio, alfanum�rico.
- Estado: Obligatorio, con opciones Pendiente, En Proceso y Finalizada.
- Prioridad: Obligatorio, con opciones Alta, Media y Baja.
- Fecha de Compromiso: Obligatoria, debe ser una fecha futura o igual a la fecha actual.
- Notas: Campo opcional para informaci�n adicional sobre la tarea.

## Filtros

Filtrar las tareas mostradas en la tabla por:
  - **Estado**: Pendiente, En Proceso, Finalizada.
  - **Prioridad**: Alta, Media, Baja.
  - **Fecha de Compromiso**: Selecciona una fecha espec�fica de las disponibles en la lista de tareas mediante un ComboBox.


## Validaciones:

Los campos obligatorios deben estar completos antes de guardar o editar una tarea.
Solo se pueden editar las tareas en estado Pendiente o En Proceso.
Las tareas en estado En Proceso no pueden eliminarse.
Confirmaci�n antes de eliminar cualquier tarea.
Visualizaci�n de tareas en un DataGridView, ordenadas por fecha de compromiso (ascendente), con filtros por estado, prioridad y fecha.

## Requisitos del Sistema
.NET Framework 8.0
SQLite (incluido en el proyecto)
Visual Studio 2019 o superior

## Configuraci�n del Entorno de Desarrollo

Instalaci�n de Dependencias

#### Clonar el repositorio:

bash
Copy code
git clone https://github.com/jeancv24/Proyecto-Administrador-de-tareas.git
Abrir el proyecto en Visual Studio:

Navega a la carpeta del proyecto y abre el archivo .sln en Visual Studio.
Restaurar paquetes NuGet:

Visual Studio restaurar� autom�ticamente los paquetes necesarios, incluidos los relacionados con SQLite.
Configurar la base de datos SQLite:

No es necesario realizar configuraciones adicionales, ya que SQLite est� integrado en el proyecto. La base de datos se crear� autom�ticamente al iniciar la aplicaci�n.

### Ejecuci�n del Proyecto

#### Ejecutar la aplicaci�n:

En Visual Studio, presiona F5 o haz clic en el bot�n Run.
La aplicaci�n se iniciar� y podr�s ver la interfaz gr�fica para administrar las tareas.

##### Agregar Tareas:

Ingresa una descripci�n, selecciona un estado, prioridad, fecha de compromiso y notas (si es necesario), y haz clic en Agregar.

##### Editar Tareas:

Selecciona una tarea que est� en estado Pendiente o En Proceso, haz clic en Editar. Despu�s de hacer los cambios, haz clic en Guardar Cambios.

##### Eliminar Tareas:

Solo las tareas en estado Pendiente o Finalizada pueden ser eliminadas. Para hacerlo, selecciona una tarea y presiona Eliminar.

## Explicaci�n T�cnica

### Patrones de Arquitectura

MVVM (Model-View-ViewModel): El proyecto sigue el patr�n MVVM para separar las interacciones entre la vista, la l�gica de negocio y la interacci�n con la base de datos:
Model: Define la estructura de los datos (por ejemplo, el modelo Task).
View: Representa la interfaz gr�fica (WinForms) que el usuario interact�a.
ViewModel: Contiene la l�gica de negocio, gestiona la interacci�n entre la vista y el modelo, y maneja las acciones de la base de datos.

### Base de Datos

Se utiliza SQLite como base de datos embebida, lo que facilita la persistencia de las tareas sin necesidad de configurar un servidor externo. La base de datos se crea autom�ticamente y se guarda en el directorio local del usuario.

### Validaciones y Restricciones

Las tareas no pueden ser guardadas si los campos obligatorios no est�n completos.
Las tareas en estado En Proceso no se pueden eliminar para evitar perder datos que est�n en curso.
El DateTimePicker est� configurado para solo aceptar fechas a partir del d�a actual, y se valida que la fecha de compromiso sea futura o igual a la actual.

## Componentes Visuales
Se utiliza WinForms para crear una interfaz simple y amigable. Los componentes incluyen TextBox, ComboBox, DateTimePicker, y DataGridView para visualizar y gestionar las tareas.

Elementos visuales en idioma espa�ol

## Gu�a de Estilo de C�digo

#### Convenciones de Nombres:

- Clases: Nombres de clases en PascalCase.
- M�todos: Nombres de m�todos en PascalCase.
- Variables: Nombres de variables en camelCase.
- Constantes: Nombres de constantes en UPPER SNAKE CASE.

### Estructura del C�digo:

Nomengratugra en idioma ingles

Separar la l�gica de negocio del c�digo de la vista.

Cada m�todo debe realizar una sola tarea. Si un m�todo crece en complejidad, considera dividirlo en varios m�todos.
Los eventos en la vista solo deben delegar el trabajo al ViewModel, manteniendo el c�digo de la vista lo m�s limpio posible.

#### Comentarios:

Comentarios en idioma espa�ol

Utilizar comentarios siempre que sea posible, pero siendo conciso para entender el codigo sin problemas.

## Errores y Excepciones:

Manejar errores comunes (como intentar eliminar una tarea en estado "En Proceso") y mostrar mensajes claros a los usuarios.