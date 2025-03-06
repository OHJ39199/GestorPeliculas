# Gestor de Películas - Proyecto MAUI - Andres Caso Iglesias
=====================================================

## Descripción del Proyecto
---------------------------

Este proyecto es una aplicación de gestión de películas desarrollada con .NET MAUI. Permite a los usuarios realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre una base de datos de películas a través de una API REST.

## Características Principales
---------------------------

### 1. Interfaz de Usuario

- Diseño de dos columnas para una experiencia de usuario intuitiva XD
- Control de entrada para IDs de películas
- Visualización de resultados 

### 2. Operaciones CRUD

- **Obtener Todas las Películas**: Lista completa de películas en la base de datos
- **Obtener Película por ID**: Búsqueda de una película específica
- **Añadir Nueva Película**: Inserción de nuevos registros de películas
- **Actualizar Película**: Modificación de datos de películas existentes
- **Eliminar Película**: Eliminación de registros de películas

### 3. Manejo de API

- Utilización de `HttpClient` para comunicación con API REST
- Serialización y deserialización JSON para intercambio de datos

### 4. Manejo de Errores

- Validación de entradas de usuario
- Mensajes de error informativos para operaciones fallidas

## Tecnologías Utilizadas
-------------------------

- **.NET MAUI**: Framework para desarrollo de aplicaciones multiplataforma
- **C#**: Lenguaje de programación principal
- **XAML**: Lenguaje de marcado para la interfaz de usuario
- **MVVM**: Patrón de diseño Model-View-ViewModel

## Estructura del Proyecto
-------------------------

- **Models**: Definición de la clase `Film`
- **ViewModels**: Lógica y comandos (MainViewModel)
- **Views**: Interfaz de usuario (MainView)

## Funcionalidades Destacadas
---------------------------

1. **Búsqueda Dinámica**: Permite a los usuarios buscar películas por ID en tiempo real
2. **Actualización en Tiempo Real**: La interfaz se actualiza inmediatamente después de cada operación
3. **Manejo de Errores Robusto**: Proporciona feedback claro al usuario sobre el resultado de cada acción

## Objetivo del Proyecto
-----------------------

El propósito principal de esta aplicación es demostrar la implementación de operaciones CRUD en una aplicación .NET MAUI, ilustrando buenas prácticas de programación y diseño de interfaces de usuario para aplicaciones multiplataforma.
