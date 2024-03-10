# Gestion-Articulos
Aplicacion en Winforms, C# .Net Framework, SQLServer, ADO.NET

# Descripcion de la aplicación
En esta aplicación, desarrollé un sistema para gestionar artículos, con funcionalidades para insertar nuevos artículos,
editar, eliminar y seleccionar artículos de una base de datos.
Esta aplicacion esta construida aplicando arquitectura en capas, donde existen las capas de Modelo y Control. Delegando asi a cada capa la tarea que le corresponde.
Se aplica POO, conceptos como herencia, sobreescritura, metodos estaticos, privados, publicos. Manejo de eventos en formularios y validaciones entre otras.

# Dar de alta a nuevo articulo
En la aplicación, el usuario puede dar de alta un nuevo artículo presionando en el boton con leyenda "Nuevo artículo".
Este botón abre un nuevo formulario, donde se deben ingresar todos los datos correspondientes.
Se aplican una serie de validaciones, para evitar errores al cargar un nuevo articulo. Por ejemplo, que no queden casillas vacias,
que el precio ingresado sea correcto, aceptando solo numeros con decimales, entre otras.
Además, cuenta con la posibilidad de ingresar imagenes de forma local, validando tambien las extensiones de las mismas.
Al finalizar la carga de datos, se habilita el boton "Guardar articulo", el cual desarrolla la lógica para insertar
el nuevo articulo en la base de datos.
Luego de guardar los datos, se actualiza la lista de articulos. Esto es asi, para que la informacion que se muestra en la aplicacion sea la real.

# Editar artículo
El usuario puede editar el articulo, presionando el boton "Editar articulo", habilitando una lista de articulos para que el usuario seleccione 
cual desea editar. Luego de seleccionar el articulo de la lista, en la parte inferior de la misma, aparece un boton con la leyenda "Editar articulo>" 
el cual se encarga de tomar los datos de dicho articulo y cargarlo en un formulario para facilitar los campos de edicion que desee el usuario.
Al finalizar, luego de aplicar las validaciones correspondiente, puede guardar el articulo.
Luego de guardar los datos, se actualiza la lista de articulos. Esto es asi, para que la informacion que se muestra en la aplicacion sea la real.

# Eliminar articulo
El usuario puede eliminar un articulo determinado, presionando el boton "Eliminar articulo", se habilita la lista de articulos completa, para que 
seleccione el articulo que desea elimnar, luego de seleccionarlo, al presionar el boton "Eliminar" que se encuentra en la parte inferior de la lista
se procede a eliminar dicho articulo, como validacion, se le pide al usuario que confirme dicha accion, para asi evitar la eliminacion no deseada de un articulo.
Luego de eliminar el/los articulos, se actualiza la lista de articulos, para que la informacion que se muestra en la aplicacion sea la real.

# Funcionalidad de filtrado
En esta aplicación, tenemos una funcionalidad importante donde se puede aplicar dos tipos de filtros, un filtro rápido y un filtro avanzado.
Al aplicar un filtro rápido, el usuario ingresa un texto en una caja de texto, a medida que vaya ingresando caracter por caracter,
la tabla donde se muestran todos los artículos, va mostrando las coincidencias que encuentre en los nombres de cada artículo.
En cambio, al aplicar un filtro avanzado, el usuario tiene la posibilidad de filtrar por Marca de articulo, Categoria a la que pertenece y aplicar un orden
en el listado por el precio de cada articulo, ya sea de menor a mayor o viceversa.

