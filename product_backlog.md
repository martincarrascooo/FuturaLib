# Product Backlog

## Índice
1. [Introducción](#1-introducción)
   1. [Nombre del Proyecto](#11-nombre-del-proyecto)
   2. [Fecha de Creación/Actualización](#12-fecha-de-creaciónactualización)
2. [Descripción del Proyecto](#2-descripción-del-proyecto)
   1. [Descripción](#21-descripción)
   2. [Visión del Producto](#22-visión-del-producto)
3. [Product Backlog](#3-product-backlog)
   1. [Lista de Historias de Usuario](#31-lista-de-historias-de-usuario)
   2. [Notas y Detalles Adicionales](#32-notas-y-detalles-adicionales)
4. [Criterios de Aceptación](#4-criterios-de-aceptación)
5. [Priorización y Planificación](#5-priorización-y-planificación)

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

- **Historia de Usuario 3: Registro de Préstamos y Devoluciones**
  - Descripción:  Como bibliotecario, quiero poder registrar préstamos de libros a los usuarios, realizar 
un seguimiento de las fechas de vencimiento y gestionar las devoluciones.
  - Criterios de Aceptación:
    1. Debe existir un formulario de registro de préstamos.
    2. El formulario debe incluir información del libro, usuario y fecha de vencimiento.
    3. Los préstamos deben registrarse con la fecha actual y una fecha de vencimiento.
  - Prioridad: Alta
  - Estimación: 8 puntos
  - Tareas Técnicas:
    1. Diseñar e implementar el formulario de registro de préstamos.
    2. Crear la lógica backend para procesar y almacenar la información de préstamos.
    3. Implementar la lógica de seguimiento de fechas de vencimiento.

- **Historia de Usuario 4: Gestión de Usuarios**
  - Descripción:  Como bibliotecario, quiero poder agregar, editar y eliminar información de usuarios, 
incluyendo nombre, número de identificación y detalles de contacto.
  - Criterios de Aceptación:
    1. Debe existir una interfaz de administración de usuarios.
    2. Se deben proporcionar funciones para agregar, editar y eliminar usuarios.
    3. La información del usuario debe incluir nombre, número de identificación y detalles de 
contacto.
  - Prioridad: Alta
  - Estimación: 6 puntos
  - Tareas Técnicas:
    1. Crear la interfaz de administración de usuarios.
    2. Implementar funciones para agregar, editar y eliminar usuarios.
    3. Diseñar e implementar la lógica backend para gestionar usuarios.

- **Historia de Usuario 5: Interfaz de Usuario Intuitiva**
  - Descripción: Como usuario, quiero una interfaz de usuario fácil de entender y navegar para poder utilizar el sistema de manera eficiente.
  - Criterios de Aceptación:
    1. La interfaz debe ser limpia y fácil de navegar.
    2. Las funciones principales deben ser fácilmente accesibles desde la interfaz principal.
    3. Se deben utilizar elementos visuales y de diseño para mejorar la usabilidad.
  - Prioridad: Alta
  - Estimación: 4 puntos
  - Tareas Técnicas:
    1. Diseñar una interfaz de usuario con un enfoque en la usabilidad.
    2. Crear un diseño coherente para todas las pantallas del sistema.
    3. Realizar pruebas de usuario para optimizar la experiencia de usuario.

- **Historia de Usuario 6: Notificaciones de Vencimiento de Préstamos**
  - Descripción: Como usuario, quiero recibir notificaciones sobre el vencimiento de mis préstamos para evitar retrasos y multas.
  - Criterios de Aceptación:
    1. Los usuarios deben recibir notificaciones por correo electrónico o en la interfaz del sistema.
    2. Las notificaciones deben enviarse cuando faltan 3 días para la fecha de vencimiento.
    3. Los usuarios pueden optar por desactivar las notificaciones si lo desean.
  - Prioridad: Baja
  - Estimación: 7 puntos
  - Tareas Técnicas:
    1. Implementar un sistema de notificaciones dentro de la aplicación.
    2. Crear una función para enviar correos electrónicos automáticos.
    3. Permitir a los usuarios configurar sus preferencias de notificación.

- **Historia de Usuario 7: Registro de Historial de Préstamos**
  - Descripción: Como bibliotecario, quiero llevar un registro detallado de todos los préstamos y devoluciones para mantener un control eficiente sobre los recursos de la biblioteca.
  - Criterios de Aceptación:
    1. Debe existir una sección de historial de préstamos en la interfaz del usuario.
    2. El historial debe mostrar información detallada de cada préstamo y devolución.
    3. Los usuarios pueden filtrar el historial por diferentes criterios.
  - Prioridad: Media
  - Estimación: 5 puntos
  - Tareas Técnicas:
    1. Diseñar e implementar una sección de historial en la interfaz.
    2. Crear un sistema backend para almacenar y recuperar datos de préstamos.
    3. Implementar funciones de filtrado y búsqueda en el historial.

- **Historia de Usuario 8: Estadísticas de Uso**
  - Descripción: Como bibliotecario, quiero tener acceso a estadísticas sobre el uso de la biblioteca para mejorar la gestión y planificación de recursos.
  - Criterios de Aceptación:
    1. Debe existir una sección de estadísticas en la interfaz de administración.
    2. Las estadísticas deben incluir información sobre los libros más prestados y la actividad de préstamos por usuario.
    3. Los datos estadísticos deben actualizarse en tiempo real.
  - Prioridad: Baja
  - Estimación: 9 puntos
  - Tareas Técnicas:
    1. Implementar un sistema de recolección de datos para estadísticas.
    2. Desarrollar una interfaz de usuario para visualizar las estadísticas.
    3. Garantizar la actualización en tiempo real de los datos.

- **Historia de Usuario 9: Seguridad del Sistema**
  - Descripción: Como administrador del sistema, quiero asegurarme de que todos los datos y transacciones dentro del sistema sean seguros y estén protegidos.
  - Criterios de Aceptación:
    1. Todos los datos confidenciales deben almacenarse de manera segura utilizando prácticas de cifrado.
    2. Se debe implementar un sistema de autenticación seguro para garantizar el acceso solo a usuarios autorizados.
    3. Debe haber registros de actividad que registren intentos de acceso no autorizados.
  - Prioridad: Media
  - Estimación: 7 puntos
  - Tareas Técnicas:
    1. Implementar medidas de seguridad para la protección de datos.
    2. Desarrollar un sistema de autenticación y autorización robusto.
    3. Crear un sistema de registro y seguimiento de la actividad del usuario.

- **Historia de Usuario 10: Integración con Sistema de Catálogo en Línea**
  - Descripción: Como bibliotecario, quiero que el sistema de gestión de la biblioteca esté integrado con el sistema de catálogo en línea para una gestión eficiente y actualizada de los recursos.
  - Criterios de Aceptación:
    1. Debe establecerse una conexión bidireccional con el sistema de catálogo en línea.
    2. La información sobre nuevos libros en el catálogo en línea debe actualizarse automáticamente en el sistema de gestión de biblioteca.
    3. Se debe proporcionar una interfaz para revisar y gestionar la información importada.
  - Prioridad: Media
  - Estimación: 7 puntos
  - Tareas Técnicas:
    1. Desarrollar la integración con el sistema de catálogo en línea.
    2. Automatizar la actualización de la información del catálogo.
    3. Crear una interfaz para la gestión de datos sincronizados.

### 3.2 Notas y Detalles Adicionales
- Descripción del Entorno de Desarrollo: El proyecto se desarrollará en C# utilizando el framework .NET y la tecnología WinForms para la creación de una aplicación de escritorio. La elección de estos lenguajes y entorno se basa en la experiencia previa del equipo en proyectos similares donde estas tecnologías demostraron ser eficientes y robustas.
- Patrón de Arquitectura: La aplicación seguirá una arquitectura Modelo-Vista-Presentador (MVP) que ofrece una estructura organizativa clara y modular. El patrón MVP proporciona una separación clara de las responsabilidades facilitando el mantenimiento, la escalabilidad y la prueba de la aplicación.
- Control de Versiones: Para gestionar el código fuente y colaborar eficientemente se utilizará Git como sistema de control de versiones alojando el repositorio en GitHub. Esto permitirá un desarrollo colaborativo, seguimiento de cambios y una gestión efectiva de problemas y solicitudes de extracción.

## 4. Criterios de Aceptación
| Historia de Usuario | Criterios de Aceptación |
|---------------------|-------------------------|
| 1. Registro de Libros | 1. Debe existir un formulario de registro de libros.<br>2. El formulario debe incluir campos para título, autor, género y cantidad de ejemplares.<br>3. Se deben realizar validaciones para asegurar la integridad de la información ingresada. |
| 2. Búsqueda de Libros | 1. Debe haber un campo de búsqueda en la interfaz.<br>2. Los resultados de la búsqueda deben mostrar información relevante de los libros.<br>3. La búsqueda debe ser sensible a mayúsculas y minúsculas. |
| Registro de Préstamos y Devoluciones | 1. Debe existir un formulario de registro de préstamos.<br>2. El formulario debe incluir información del libro, usuario y fecha de vencimiento.<br>3. Los préstamos deben registrarse con la fecha actual y una fecha de vencimiento. |
| Gestión de Usuarios | 1. Debe existir una interfaz de administración de usuarios.<br>2. Se deben proporcionar funciones para agregar, editar y eliminar usuarios.<br>3. La información del usuario debe incluir nombre, número de identificación y detalles de contacto. |
| Interfaz de Usuario Intuitiva | 1. La interfaz debe ser limpia y fácil de navegar.<br>2. Las funciones principales deben ser fácilmente accesibles desde la interfaz principal.<br>3. Se deben utilizar elementos visuales y de diseño para mejorar la usabilidad. |
| Notificaciones de Vencimiento de Préstamos | 1. Los usuarios deben recibir notificaciones por correo electrónico o en la interfaz del sistema.<br>2. Las notificaciones deben enviarse cuando faltan 3 días para la fecha de vencimiento.<br>3. Los usuarios pueden optar por desactivar las notificaciones si lo desean. |
| Registro de Historial de Préstamos | 1. Debe existir una sección de historial de préstamos en la interfaz del usuario.<br>2. El historial debe mostrar información detallada de cada préstamo y devolución.<br>3. Los usuarios pueden filtrar el historial por diferentes criterios. |
| Estadísticas de Uso | 1. Debe existir una sección de estadísticas en la interfaz de administración.<br>2. Las estadísticas deben incluir información sobre los libros más prestados y la actividad de préstamos por usuario.<br>3. Los datos estadísticos deben actualizarse en tiempo real. |
| Seguridad del Sistema | 1. Todos los datos confidenciales deben almacenarse de manera segura utilizando prácticas de cifrado.<br>2. Se debe implementar un sistema de autenticación seguro para garantizar el acceso solo a usuarios autorizados.<br>3. Debe haber registros de actividad que registren intentos de acceso no autorizados. |
| Integración con Sistema de Catálogo en Línea | 1. Debe establecerse una conexión bidireccional con el sistema de catálogo en línea.<br>2. La información sobre nuevos libros en el catálogo en línea debe actualizarse automáticamente en el sistema de gestión de biblioteca.<br>3. Se debe proporcionar una interfaz para revisar y gestionar la información importada. |

## 5. Priorización y Planificación
- Se utilizará la priorización de Alta, Media, y Baja.
- Se estimará el esfuerzo en puntos de historia de usuario.

| Historia de Usuario                        | Prioridad | Estimación |
|--------------------------------------------|-----------|------------|
| Registro de Libros                         | Alta      | 5 puntos   |
| Gestión de Usuarios                        | Alta      | 8 puntos   |
| Registro de Préstamos y Devoluciones       | Alta      | 5 puntos   |
| Interfaz de Usuario Intuitiva              | Alta      | 4 puntos   |
| Registro de Historial de Préstamos         | Media     | 5 puntos   |
| Seguridad del Sistema                      | Media     | 7 puntos   |
| Integración con Sistema de Catálogo en Línea| Media     | 7 puntos   |
| Notificaciones de Vencimiento de Préstamos | Baja      | 7 puntos   |
| Búsqueda de Libros                         | Baja      | 7 puntos   |
| Estadísticas de Uso                        | Baja      | 9 puntos   |
