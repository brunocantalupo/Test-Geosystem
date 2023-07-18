

Para el desarollo de la solucion, en primer lugar se realizo el diagrama entidad relacion, en donde tuve en cuenta los siguientes puntos:

- En cada plan, los abonados pueden contratar un servicio base y agregar tantos servicios como desee.
- Cada zona tiene una unica infraestructura.
- Las promociones se aplican al monto total de un plan, teniendo en cuenta cuantos servicios adicionales tiene contratados dicho plan.
- El atributo "AditionalMountZone" de la entidad "Zone" representa el procentaje de aumento que tienen los servicios en esa zone.
- El atrinuto "Discount" de la entidad "Promo" representa el porcentaje de descuento que tiene la promocion.

Luego, realice la implementacion de arquitectura de N capas en un proyecto .NET, en donde se puede ver el proyecto dividido en 3 capas:

- Capa de acceso a datos: Define las entidades y las consultas a la base de datos
- Capa de Servicios: Define los servicios necesarios para obtener datos calculados y hacer validaciones. 
- Capa de presentacion

Dentro de la capa de servicios, se definieron dos rutinas:

- getTotalMountToPay, el cual recibe un cliente y se calcula el monto total a pagar para un plan contratado. Se tiene en cuenta el porcentaje de aumento que cuenta la zona
en la que se presenta el cliente y el descuento de la promocion, en caso de que la cantidad de servicios adicionales sean suficientes para aplicar una promocion vigente.
- CheckServiceInInfrastructure, el cual recibe un cliente y un servicio. Se verifica si el servicio que llega como parametro es permitido por la infraestructura de la zona
del cliente. Este servicio sera referenciado para verificar si un servicio esta habilitado para agregar a un plan.

Dentro de la capa de acceso a datos, se definieron los metodos que se consumen dentro de los servicios para las referencias a la base de datos.
Debido a que en este test no se requiere conexion a la base de datos, se simula las querys con consultas SQL.