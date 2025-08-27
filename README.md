# Empresa-System

Sistema de gestión de empleados, departamentos, salarios y auditoría.

---

## Estructura del repositorio

- `/app` → Código de la aplicación (Visual Studio / C#)
- `/db`  → Scripts SQL de base de datos, triggers, inserts

---

## Requisitos

- Visual Studio 2022 o superior
- MySQL 8.0+ o XAMPP
- GitHub (para clonar el repositorio)

---

## Clonar el repositorio

Descargar el proyecto desde GitHub:
https://github.com/henryfabricio27-droid/Empresa-System.git


## Ejecutar la base de datos

1. Abrir MySQL Workbench o phpMyAdmin.  
2. Ejecutar el script `/db/empresa_schema.sql`.  
3. Verificar que las tablas y datos se hayan cargado correctamente.

---

## Ejecutar la aplicación

1. Abrir `/app` en Visual Studio.  
2. Compilar el proyecto (Build).  
3. Ejecutar con F5 o botón Start.  
4. La aplicación se conectará automáticamente a la base de datos.

---

## Usuarios de prueba

| Usuario      | Contraseña   | Empleado          |
|-------------|-------------|-----------------|
| cperez      | 1234seguro  | Carlos Pérez     |
| mgonzalez   | clave5678   | María González   |
| jramirez    | pass9012    | Jorge Ramírez    |
| lfernandez  | lucia4321   | Lucía Fernández  |

---

## Ramas y versionado

- `main` → versión estable  
- `readme` → cambios en documentación  
- `issues` → documentación y gestión de problemas  
- Tags de versiones: `v1.0`, `v1.1`, etc.  

**Flujo recomendado:**  
1. Crear ramas para cada funcionalidad (`feature/app-login`, `feature/db-auditoria`).  
2. Subir cambios a GitHub y abrir Pull Requests (PR) hacia `main`.  
3. Hacer merge cuando los cambios estén aprobados.

---

## Auditoría de salarios

Los cambios en la tabla `salaries` se registran automáticamente en la tabla `Log_AuditoriaSalarios` mediante trigger, registrando:  
- Usuario que hizo el cambio  
- Fecha de actualización  
- Detalle del cambio  
- Nuevo salario  
- Número de empleado (`emp_no`)
