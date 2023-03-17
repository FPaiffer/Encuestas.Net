# Encuestas.Net
Pasos para correcta ejecución:
1- Compilar Solucion
2- Seleccionar el Proyecto Encuestas.Net.Api como Proyecto de Inicio
3- Posicionarse en el proyecto Encuestas.Net.Infrastructure.Data y ejecutar Las Migraciones Correspondientes 
todo esto asumiendo que exixte una conexión Localhost a sql server, de lo contrario cambiar el ConnectionStrings en appsettings.json
migraciones:
Add-Migration comentarioMigracionX -o Migrations
Update-Database
4-ejecutar el Proyecto Api y el proyecto Presentation
