# Product Backlog

## Índice
1. Introducción
   1.1. Nombre del Proyecto
   1.2. Fecha de Creación/Actualización
2. Descripción del Proyecto
   2.1. Descripción
   2.2. Visión del Producto
3. Product Backlog
   3.1. Lista de Historias de Usuario
      - Historia de Usuario 1: Registro de Libros
      - Historia de Usuario 2: Búsqueda de Libros
      - Historia de Usuario 3: Registro de Préstamos y Devoluciones
      - Historia de Usuario 4: Gestión de Usuarios
      - Historia de Usuario 5: Interfaz de Usuario Intuitiva
      - Historia de Usuario 6: Notificaciones de Vencimiento de Préstamos
      - Historia de Usuario 7: Registro de Historial de Préstamos
      - Historia de Usuario 8: Estadísticas de Uso
      - Historia de Usuario 9: Seguridad del Sistema
      - Historia de Usuario 10: Integración con Sistema de Catálogo en Línea
   3.2. Notas y Detalles Adicionales
4. Criterios de Aceptación
5. Priorización y Planificación

## 1. Introducción
### 1.1 Nombre del Proyecto
FuturaLib: Sistema de Gestión de Biblioteca

### 1.2 Fecha de Creación/Actualización
23 de enero de 2023

## 2. Descripción del Proyecto
### 2.1 Descripción
Desarrollar un sistema de gestión de biblioteca que permita a los bibliotecarios y usuarios llevar un registro de los libros en la biblioteca, realizar préstamos y devoluciones y gestionar los datos de los usuarios.

### 2.2 Visión del Producto
Proporcionar una interfaz de usuario intuitiva y funcionalidades clave para administrar eficientemente la biblioteca.

## 3. Product Backlog
### 3.1 Lista de Historias de Usuario
- **Historia de Usuario 1: Registro de Libros**
  - Descripción: Como bibliotecario quiero poder agregar nuevos libros al catálogo incluyendo información como título, autor, género y número de ejemplares disponibles.
  - Criterios de Aceptación:
    1. Debe existir un formulario de registro de libros.
    2. El formulario debe incluir campos para título, autor, género y cantidad de ejemplares.
    3. Se deben realizar validaciones para asegurar la integridad de la información ingresada.
  - Prioridad: Alta
  - Estimación: 5 puntos
  - Tareas Técnicas:
    1. Diseñar e implementar el formulario de registro de libros.
    2. Crear la lógica backend para procesar y almacenar la información.
    3. Implementar validaciones para prevenir datos incorrectos o incompletos.

- **Historia de Usuario 2: Búsqueda de Libros**
  - Descripción: Como usuario quiero poder buscar libros en el catálogo por título o autor para encontrar rápidamente la información que necesito.
  - Criterios de Aceptación:
    1. Debe haber un campo de búsqueda en la interfaz.
    2. Los resultados de la búsqueda deben mostrar información relevante de los libros.
    3. La búsqueda debe ser sensible a mayúsculas y minúsculas.
  - Prioridad: Media
  - Estimación: 3 puntos
  - Tareas Técnicas:
    1. Integrar un campo de búsqueda en la interfaz.
    2. Desarrollar la lógica backend para realizar búsquedas eficientes.
    3. Implementar la visualización de resultados en la interfaz.

- *(Continúa con el resto de las historias de usuario)*

### 3.2 Notas y Detalles Adicionales
- Descripción del Entorno de Desarrollo: El proyecto se desarrollará en C# utilizando el framework .NET y la tecnología WinForms para la creación de una aplicación de escritorio. La elección de estos lenguajes y entorno se basa en la experiencia previa del equipo en proyectos similares donde estas tecnologías demostraron ser eficientes y robustas.
- Patrón de Arquitectura: La aplicación seguirá una arquitectura Modelo-Vista-Presentador (MVP) que ofrece una estructura organizativa clara y modular. El patrón MVP proporciona una separación clara de las responsabilidades facilitando el mantenimiento, la escalabilidad y la prueba de la aplicación.
- Control de Versiones: Para gestionar el código fuente y colaborar eficientemente se utilizará Git como sistema de control de versiones alojando el repositorio en GitHub. Esto permitirá un desarrollo colaborativo, seguimiento de cambios y una gestión efectiva de problemas y solicitudes de extracción.

## 4. Criterios de Aceptación
*(Detalles de los criterios para cada historia de usuario)*

## 5. Priorización y Planificación
- Se utilizará la priorización de Alta, Media, y Baja.
- Se estimará el esfuerzo en puntos de historia de usuario.
