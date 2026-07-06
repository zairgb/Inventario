# 📦 Sistema de Inventario

![.NET](https://img.shields.io/badge/.NET-9.0-purple)
![C#](https://img.shields.io/badge/C%23-Language-blue)
![Estado](https://img.shields.io/badge/Estado-En%20desarrollo-orange)
![Licencia](https://img.shields.io/badge/Licencia-PCA-red)

Sistema de Inventario desarrollado en **C#** y **.NET** como aplicación de consola. Este proyecto forma parte de mi ruta de aprendizaje en .NET y tiene como objetivo simular la administración de productos en un almacén o tienda.

---

# 📖 Descripción

Esta aplicación permite administrar un inventario de productos mediante un menú interactivo.

Cada producto cuenta con información como:

- ID
- Nombre
- Descripción
- Categoría
- Precio
- Cantidad en existencia

El proyecto implementa un CRUD completo y servirá como base para futuras versiones utilizando bases de datos y APIs REST.

---

# 🎯 Objetivos del proyecto

Con este proyecto se busca fortalecer conocimientos sobre:

- Programación Orientada a Objetos.
- Organización de proyectos en .NET.
- CRUD de datos.
- Colecciones (`List<T>`).
- LINQ.
- Serialización JSON.
- Manejo de archivos.
- Validación de datos.
- Arquitectura por capas.

---

# ✨ Funcionalidades

- ➕ Agregar productos.
- 📋 Mostrar inventario.
- 🔍 Buscar productos.
- ✏️ Editar productos.
- ❌ Eliminar productos.
- 📥 Registrar entrada de mercancía.
- 📤 Registrar salida de mercancía.
- 💾 Guardar inventario en JSON.
- 📂 Cargar inventario desde JSON.
- 📊 Generar reportes del inventario.

---

# 🛠️ Tecnologías utilizadas

- C#
- .NET
- Programación Orientada a Objetos
- LINQ
- System.Text.Json
- Manejo de archivos

---

# 📁 Estructura del proyecto

```text
SistemaInventario/
│
├── Models/
│   └── Producto.cs
│
├── Services/
│   └── InventarioService.cs
│
├── Data/
│   └── productos.json
│
├── Program.cs
└── README.md
```

---

# ▶️ Cómo ejecutar el proyecto

## Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/SistemaInventario.git
```

## Entrar al proyecto

```bash
cd SistemaInventario
```

## Ejecutar

```bash
dotnet run
```

---

# 💻 Menú principal

```text
==================================
      SISTEMA DE INVENTARIO
==================================

1. Agregar producto
2. Mostrar productos
3. Buscar producto
4. Editar producto
5. Eliminar producto
6. Entrada de mercancía
7. Salida de mercancía
8. Guardar inventario
9. Cargar inventario
10. Reportes
0. Salir
```

---

# 📦 Modelo de producto

Cada producto contiene la siguiente información:

| Campo | Descripción |
|--------|-------------|
| ID | Identificador único |
| Nombre | Nombre del producto |
| Descripción | Descripción breve |
| Categoría | Clasificación del producto |
| Precio | Precio unitario |
| Cantidad | Existencias disponibles |

Ejemplo:

```text
ID: 1

Nombre: Laptop Lenovo

Descripción: Laptop Ryzen 7

Categoría: Computadoras

Precio: $18,500

Cantidad: 8
```

---

# 📊 Reportes

El sistema permitirá generar estadísticas como:

- Número total de productos.
- Valor total del inventario.
- Productos sin existencias.
- Producto más caro.
- Producto más económico.
- Precio promedio.
- Productos con bajo inventario.
- Productos ordenados por precio.
- Productos ordenados por categoría.

---

# 🧠 Conceptos aplicados

Durante el desarrollo se practicarán los siguientes temas:

- Variables
- Métodos
- Clases
- Objetos
- Encapsulamiento
- List<T>
- LINQ
- foreach
- switch
- while
- Serialización JSON
- Manejo de archivos
- Validaciones
- Arquitectura por capas

---

# 📊 Estado del proyecto

| Funcionalidad | Estado |
|---------------|--------|
| Agregar producto | ✅ |
| Mostrar productos | ✅ |
| Buscar producto | ✅ |
| Editar producto | ✅ |
| Eliminar producto | ✅ |
| Entrada de mercancía | ✅ |
| Salida de mercancía | ✅ |
| Guardar en JSON | ✅ |
| Cargar desde JSON | ✅ |
| Reportes | ⏳ |

**Leyenda**

- ✅ Completado
- 🚧 En desarrollo
- ⏳ Pendiente

---

# 📖 Lo que aprenderé

Con este proyecto reforzaré conocimientos sobre:

- Programación Orientada a Objetos.
- Organización de proyectos en carpetas.
- Implementación de un CRUD.
- Uso de LINQ para consultas.
- Persistencia de datos mediante JSON.
- Validación de entradas del usuario.
- Diseño de aplicaciones de consola.

---

# 🚀 Próximas mejoras

- Validación completa de datos.
- Manejo de excepciones.
- Exportar inventario a Excel.
- Exportar reportes a PDF.
- Agregar proveedores.
- Agregar historial de movimientos.
- Implementar SQLite.
- Integrar Entity Framework Core.
- Migrar a SQL Server.
- Crear una API REST con ASP.NET Core.
- Desarrollar un frontend en Angular.

---

# 📸 Capturas

Cuando el proyecto esté terminado puedes agregar imágenes como:

```text
images/
│
├── menu.png
├── agregar-producto.png
├── inventario.png
├── reportes.png
└── buscar-producto.png
```

Ejemplo:

```markdown
## Menú principal

![Menú](./images/menu.png)

## Inventario

![Inventario](./images/inventario.png)

## Reportes

![Reportes](./images/reportes.png)
```

---

# 🎓 Ruta de aprendizaje

Este proyecto forma parte de una serie de aplicaciones desarrolladas para aprender .NET.

| Proyecto | Estado |
|----------|--------|
| ✅ 01 - Calculadora | Finalizado |
| ✅ 02 - Agenda Electrónica | Finalizado |
| 🚧 03 - Sistema de Inventario | En desarrollo |
| ⏳ 04 - Cajero Automático | Pendiente |
| ⏳ 05 - API REST | Pendiente |
| ⏳ 06 - Sistema de Ventas | Pendiente |

---

# 🤝 Contribuciones

Las sugerencias y mejoras son bienvenidas.

Si deseas contribuir:

1. Haz un **Fork** del proyecto.
2. Crea una nueva rama.
3. Realiza tus cambios.
4. Envía un **Pull Request**.

---

# 👨‍💻 Autor

**Jair**

Proyecto desarrollado como parte de mi aprendizaje de **C#**, **.NET** y desarrollo de aplicaciones empresariales.

---

# ⭐ Apoya el proyecto

Si este proyecto te resultó útil o te ayudó a aprender, considera darle una ⭐ al repositorio.

¡Gracias por visitar este proyecto!
````
