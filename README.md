 Store API - ASP.NET Core

API REST desarrollada como proyecto de práctica para aprender desarrollo backend con ASP.NET Core.
La aplicación permite gestionar productos mediante un CRUD completo y utiliza una arquitectura en capas para mantener el código organizado y escalable.

---

 Tecnologías utilizadas

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* Swagger / OpenAPI
* Arquitectura en capas (Controllers, Services, Interfaces, DTOs)

---

 Estructura del proyecto

El proyecto está organizado para separar responsabilidades y facilitar el mantenimiento.

Controllers
Contienen los endpoints de la API y reciben las peticiones HTTP.

Services
Contienen la lógica de negocio de la aplicación.

Interfaces
Definen contratos para los servicios y facilitan la inyección de dependencias.

DTOs
Objetos utilizados para transferir datos entre el cliente y la API.

Entities
Modelos que representan las tablas de la base de datos.

Data
Contiene el DbContext que conecta la aplicación con la base de datos.

---

# Funcionalidades

* Crear productos
* Obtener todos los productos
* Obtener un producto por ID
* Actualizar productos
* Eliminar productos
* Documentación automática de la API con Swagger

---

 Endpoints de la API

 Obtener todos los productos

GET
/api/productos

Devuelve una lista con todos los productos registrados.

---

## Obtener un producto por ID

GET
/api/productos/{id}

Devuelve un producto específico según su identificador.

---

## Crear un producto

POST
/api/productos

Ejemplo de request:

```json
{
  "nombre": "Laptop",
  "precio": 1200,
  "stock": 5
}
```

---

 Actualizar un producto

PUT
/api/productos/{id}

Ejemplo:

```json
{
  "nombre": "Laptop Gamer",
  "precio": 1500,
  "stock": 3
}
```

---

## Eliminar un producto

DELETE
/api/productos/{id}

Elimina un producto del sistema.

---

 Documentación de la API

La documentación interactiva de la API está disponible mediante Swagger.

Al ejecutar el proyecto se puede acceder desde:

/swagger

Desde ahí se pueden probar todos los endpoints directamente desde el navegador.

---

 Cómo ejecutar el proyecto

1. Clonar el repositorio

git clone <url-del-repositorio>

2. Abrir el proyecto en Visual Studio

3. Configurar la cadena de conexión en:

appsettings.json

4. Ejecutar las migraciones de Entity Framework

Add-Migration InitialCreate
Update-Database

5. Ejecutar el proyecto

Al iniciar la aplicación se abrirá automáticamente Swagger para probar los endpoints.

---

 Objetivo del proyecto

Este proyecto fue desarrollado como práctica para aprender:

* Desarrollo de APIs REST
* Uso de Entity Framework Core
* Arquitectura en capas
* Uso de DTOs
* Documentación con Swagger

