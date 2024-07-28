# Proyecto final - Programación en Nuevas Tecnologías
## Sistema de Gestión de Espacios de Estacionamiento

![Estado del proyecto](https://img.shields.io/badge/estado-en%20desarrollo-yellow)

## Alcance
&nbsp;&nbsp;&nbsp;&nbsp;Desarrollar una aplicación web en ASP.NETCore que permita gestionar los espacios de un estacionamiento.   

&nbsp;&nbsp;&nbsp;&nbsp;**Requerimientos del proyecto**:  
- Aplicación de un patrón de diseño MVC (Model-View-Controller)  
- Autenticación y Autorización de usuarios  
- Visualización en tiempo real de la disponibilidad de espacios.
- Reserva de espacios por un período determinado
- Pago en línea y generación de comprobantes
  
## Modelado de la Base de Datos
A continuación se muestra el diagrama del modelado de la base de datos utilizado en este proyecto:

![Modelado de la Base de Datos](images/modelo_bd.png)

## Tecnologías
- **Backend:** ASP .NET Core 8.0
- **Frontend:** Razor Pages, Bootstrap 5.1
- **Base de Datos:** SQL SERVER
- **ORM:** Entity Framework Core
- **Autenticación y Autorización:** ASP .NET Identity
- **IDE:** Visual Studio 2022

## Instalación
Sigue estos pasos para configurar el proyecto en tu entorno local:

1. Clona el repositorio:
    ```bash
    git clone https://github.com/gianninac/MVC_Estacionamiento.git
    ```
2. Abre el proyecto en Visual Studio 2022.
3. Restaura los paquetes NuGet:
    ```bash
    dotnet restore
    ```

## Configuración
1. Configura la cadena de conexión en el archivo `appsettings.json`:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=your_server_name;Database=your_database_name;Trusted_Connection=True;"
      }
    }
    ```
2. Aplica las migraciones de Entity Framework para crear la base de datos:
    ```bash
    dotnet ef database update
    ```

## Uso
Para ejecutar la aplicación, utiliza el comando:
```bash
dotnet run
