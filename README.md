# Proyecto Administrador de tareas

### Descripción:
Esta es una aplicación de escritorio para administrar tareas, creada con C# y WinForms, utilizando SQLite como base de datos para la persistencia y el patrón MVVM para la separación de la lógica de negocio, la interacción con la base de datos y la vista.

### Características:
Agregar, Editar y Eliminar Tareas con los siguientes campos:

- Descripción: Campo obligatorio, alfanumérico.
- Estado: Obligatorio, con opciones Pendiente, En Proceso y Finalizada.
- Prioridad: Obligatorio, con opciones Alta, Media y Baja.
- Fecha de Compromiso: Obligatoria, debe ser una fecha futura o igual a la fecha actual.
- Notas: Campo opcional para información adicional sobre la tarea.

## Filtros

Filtrar las tareas mostradas en la tabla por:
  - **Estado**: Pendiente, En Proceso, Finalizada.
  - **Prioridad**: Alta, Media, Baja.
  - **Fecha de Compromiso**: Selecciona una fecha específica de las disponibles en la lista de tareas mediante un ComboBox.


## Validaciones:

Los campos obligatorios deben estar completos antes de guardar o editar una tarea.
Solo se pueden editar las tareas en estado Pendiente o En Proceso.
Las tareas en estado En Proceso no pueden eliminarse.
Confirmación antes de eliminar cualquier tarea.
Visualización de tareas en un DataGridView, ordenadas por fecha de compromiso (ascendente), con filtros por estado, prioridad y fecha.

## Requisitos del Sistema
.NET Framework 8.0
SQLite (incluido en el proyecto)
Visual Studio 2019 o superior

## Configuración del Entorno de Desarrollo

Instalación de Dependencias

#### Clonar el repositorio:

bash
Copy code
git clone https://github.com/jeancv24/Proyecto-Administrador-de-tareas.git
Abrir el proyecto en Visual Studio:

Navega a la carpeta del proyecto y abre el archivo .sln en Visual Studio.
Restaurar paquetes NuGet:

Visual Studio restaurará automáticamente los paquetes necesarios, incluidos los relacionados con SQLite.
Configurar la base de datos SQLite:

No es necesario realizar configuraciones adicionales, ya que SQLite está integrado en el proyecto. La base de datos se creará automáticamente al iniciar la aplicación.

### Ejecución del Proyecto

#### Ejecutar la aplicación:

En Visual Studio, presiona F5 o haz clic en el botón Run.
La aplicación se iniciará y podrás ver la interfaz gráfica para administrar las tareas.

##### Agregar Tareas:

Ingresa una descripción, selecciona un estado, prioridad, fecha de compromiso y notas (si es necesario), y haz clic en Agregar.

##### Editar Tareas:

Selecciona una tarea que esté en estado Pendiente o En Proceso, haz clic en Editar. Después de hacer los cambios, haz clic en Guardar Cambios.

##### Eliminar Tareas:

Solo las tareas en estado Pendiente o Finalizada pueden ser eliminadas. Para hacerlo, selecciona una tarea y presiona Eliminar.

## Explicación Técnica

### Patrones de Arquitectura

MVVM (Model-View-ViewModel): El proyecto sigue el patrón MVVM para separar las interacciones entre la vista, la lógica de negocio y la interacción con la base de datos:
Model: Define la estructura de los datos (por ejemplo, el modelo Task).
View: Representa la interfaz gráfica (WinForms) que el usuario interactúa.
ViewModel: Contiene la lógica de negocio, gestiona la interacción entre la vista y el modelo, y maneja las acciones de la base de datos.

### Base de Datos

Se utiliza SQLite como base de datos embebida, lo que facilita la persistencia de las tareas sin necesidad de configurar un servidor externo. La base de datos se crea automáticamente y se guarda en el directorio local del usuario.

### Validaciones y Restricciones

Las tareas no pueden ser guardadas si los campos obligatorios no están completos.
Las tareas en estado En Proceso no se pueden eliminar para evitar perder datos que estén en curso.
El DateTimePicker está configurado para solo aceptar fechas a partir del día actual, y se valida que la fecha de compromiso sea futura o igual a la actual.

## Componentes Visuales
Se utiliza WinForms para crear una interfaz simple y amigable. Los componentes incluyen TextBox, ComboBox, DateTimePicker, y DataGridView para visualizar y gestionar las tareas.

Elementos visuales en idioma español

## Guía de Estilo de Código

#### Convenciones de Nombres:

- Clases: Nombres de clases en PascalCase.
- Métodos: Nombres de métodos en PascalCase.
- Variables: Nombres de variables en camelCase.
- Constantes: Nombres de constantes en UPPER SNAKE CASE.

### Estructura del Código:

Nomengratugra en idioma ingles

Separar la lógica de negocio del código de la vista.

Cada método debe realizar una sola tarea. Si un método crece en complejidad, considera dividirlo en varios métodos.
Los eventos en la vista solo deben delegar el trabajo al ViewModel, manteniendo el código de la vista lo más limpio posible.

#### Comentarios:

Comentarios en idioma español

Utilizar comentarios siempre que sea posible, pero siendo conciso para entender el codigo sin problemas.

## Errores y Excepciones:

Manejar errores comunes (como intentar eliminar una tarea en estado "En Proceso") y mostrar mensajes claros a los usuarios.