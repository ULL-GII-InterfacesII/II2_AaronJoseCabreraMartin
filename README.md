# II2_AaronJoseCabreraMartin

---

## 1)a)

En el apartado 1)a) como es l�gico al no a�adir f�sicas a ninguno de los dos objetos, no se mueve ninguno.

![imagen](/1a.png)

## 1)b)

En el apartado 1)b) nos pide a�adirle f�sicas a la esfera, para ello, clickearemos en la esfera, luego en AddComponent, RigidBody

Observamos como la esfera cae por el efecto de la gravedad

![gif](/1b.gif)


## 1)c)

En el apartado 1)c) nos pide a�adirle f�sicas al cubo, para ello, seguiremos el mismo proceso que con la esfera

Observamos como tanto la esfera como el cubo cae por el efecto de la gravedad

![gif](/1c.gif)


## 1)d)

Para a�adir masa a la esfera, vamos a la esfera y en su apartado de rigidbody podemos observar que hay un campo llamado mass que por defecto viene a 1 unidad. Para hacer que la esfera tenga 10 veces m�s masa que el cubo cambiaremos el valor de mass a 10 unidades

![imagen](/1d1.png)

Observamos como tanto la esfera como el cubo caen a la vez por el efecto de la gravedad

![gif](/1d2.gif)

Tambi�n he deformado algo el terreno para observar como colisionan 
![gif](/1d3.gif)

## 1)e)

Primero para eliminar las f�sicas del cubo; debemos ir al cubo, buscar su rigidbody y eliminar este componente.

![imagen](/1e1.png)

Luego, en el mismo cubo en la zona de _"Box Collider"_ encontraremos una casilla en la que podremos marcar Is Trigger o no. La dejamos activa.

![imagen](/1e2.png)

Si ejecutamos este ser�a el resultado

![gif](/1e3.gif)

Podemos observar que al cubo no se le aplican las f�sicas, si el cubo y la esfera entrasen en contacto con una colisi�n se llamar�an a las funciones OnTriggerEnter, OnTriggerExit y OnTriggerStay ya que estar�an colisionando un rigidbody y un objeto IsTrigger, estos m�todos representan que existe una colisi�n pero que esta no produce una reacci�n f�sica.

## 1)f) 
Para volver a activarle las f�sicas al cubo seguimos los pasos que mostr� anteriormente.
![gif](/1f1.gif)

Podemos observar que el cubo al llegar al suelo, lo atraviesa y contin�a cayendo. He bajado un poco la c�mara para observar que sigue cayendo incluso al atravesar el suelo. Porque ahora le afecta la gravedad pero no colisiona con otros objetos en el sentido f�sico sino que los atraviesa y llama a las funciones Trigger mencionadas anteriormente, estas se llaman siempre que un GameObject colisiona con otro GameObject.

## 1)g)
Desactivamos el IsTrigger del cubo, comprobamos la masa de la esfera y la dejamos a 10 unidades ya que el cubo pesa 1, al igual que expliqu� en apartados anteriores. Ahora para desactivar la rotaci�n sobre el plano XZ del cubo, vamos hasta la secci�n de las propiedades de su rigidbody y marcamos las casillas freze-rotation XZ.

![imagen](/1g1.png)

He colocado un plano algo inclinado para provocar que ambos objetos roten.
Este ser�a el resultado:

![gif](/1g2.gif)

Podemos observar que el cubo no rota en el plano XZ pero en el eje Y si, justo al final cuando el cubo llega al suelo y la esfera lo rota ligeramente.

## 2)a)

Primero cre� un GameObject cubo al que llamare _"CubePlayer"_, luego cre� un script llamado _"CharacterControllerCube"_. 
Para conseguir desplazar el cubo con el script tenemos que acceder a su __Transform__ porque este no posee f�sicas. Si tuviera f�sicas deber�amos usar su __Rigidbody__ y usar el m�todo _"addforce"_ para no confundir al motor de f�sicas.
Para desplazar al cubo simplemente a�adir� un atributo privado de tipo Transform y al que llamar� tf_, en el m�todo _Start()_ inicializar� a tf_ con la referencia que devuelve el m�todo **_GetComponent<Transform>()_**, este m�todo nos devolver� una referencia al transform del objeto al que le a�adamos este script. Y por �ltimo en el m�todo _Update()_ a�adir� la siguiente sentencia: `tf_.Translate( Vector3.forward * Time.deltaTime);`
En la sentencia observamos que accedemos al m�todo Translate y le pasamos un Vector3.forward que quiere decir un vector que apunta a lo que nuestro GameObject tiene enfrente, adem�s ese vector es multiplicado por un escalar, un n�mero, _Time.delteTime_ el cual es desde el frame que nos encontramos, el tiempo que se tarda en generar el siguiente frame. Lo har� as� por si se produce una bajada de FPS que se calcule bien la posici�n en la que deber�a quedar.
![imagen](/2a1.png)
**Muy importante:** no olvidar debemos a�adir el script a los componentes del GameObject _"CubePlayer"_ podemos a�adirlo simplemente arrastrando el script hasta el nombre del dicho GameObject en la columna de objetos 3D. Sino, nuestro script no ser� ejecutado.
![gif](/2a2.gif)
Podemos observar que el CuboPlayer atraviesa el otro cubo, esto es as� porque CuboPlayer no tiene f�sicas, no es un RigidBody.

## 2)b)

Para graduar la velocidad, a�adir� un atributo p�blico de tipo float llamado velocity_, lo har� p�blico para poder acceder a este desde el inspector de objetos.

El atributo velocity_ lo inicializar� con el valor 1.5F en el m�todo _Start()_ y en el update, en la sentencia de *"tf_.Translate"* a�adire el atributo velocity_ como otro escalar que multiplica al Vector3, as� este atributo afectar� linealmente a la velocidad de desplazamiento del objeto.

![imagen](/2b1.png)

Si ejecutamos este ser�a el resultado:

![gif](/2b2.gif)

Podemos editar el atributo velocity desde el inspector, si por ejemplo le ponemos un valor de 10 unidades este ser�a el resultado:

![gif](/2b3.gif)

## 2)c)

Para escuchar que hace el usuario tenemos la clase __Input__. Utilizando el m�todo _"GetKey"_ de esta clase podemos detectar si un usuario est� pulsando la tecla concreta que le pasemos.
Como he decidido que voy a utilizar las flechas de direcci�n, en Update() situar� 4 sentencias if para detectar que tecla o teclas est� pulsando el usuario y desplazar el CubePlayer en consecuencia.

![imagen](/2c1.png)

Tambi�n he a�adido unos Debug.log() para saber que flecha est� detectando en cada momento.

![gif](/2c2.gif)

---
# Ejercicios hechos la siguiente semana
---

## 2)d)
En el ejercicio 2d nos pide que a�adamos la posibilidad de rotar al personaje sobre s� mismo para poder girar. Usar� las teclas _"**a**"_ y _"**d**"_ para esto. Simplemente cuando detecte que el jugador las pulsa llamar� al m�todo rotate.

![imagen](/2d1.png)
![gif](/2d2.gif)

## 3)a)
En este apartado se nos pide crear varias esferas. **Todas** las esferas deben cambiar de color cada vez que entren en contacto con el jugador. Adem�s si se trata de una **esfera de tipo A** si mientras el jugador est�n en contacto se pulsa la barra espaciadora el jugador la impulsa hacia fuera de �l.

Inicialmente, lo har� con una esfera normal y con una esfera tipo A para programar su comportamiento. Ya que, una vez tenga sus scripts simplemente habr� que crear nuevas esferas y a�adirles el script.

Para detectar la colisi�n entre una esfera y el cubo jugador debemos usar la funci�n `OnTriggerEnter` la cual recibe un _Collider_. Lo primero que hago es comprobar que ese collider tiene la etiqueta **_Player_** y si es as� accedo al _Render_ para cambiar el color del material. Este script lo llevar�n **todas** las esferas.

![imagen](/3a1.png)
![gif](/3a2.gif)

Para la parte de impulsar hacia fuera del jugador las esferas del tipo A me pareci� m�s adecuado a�adir un `OnTriggerStay` en el script que controla el cubo judador. Simplemente si detectamos una colisi�n continuada (Stay) tipo trigger, el objeto contra el que colisionamos tiene la etiqueta _"EsferasA"_ y el jugador esta pulsando la tecla espacio, le aplicamos una fuerza tipo Explosi�n al otro objeto.

![imagen](/3a3.png)
![gif](/3a4.gif)
En el gif podemos observar que la primera esfera, que es de tipo A al pulsar el espacio sale volando pero la segunda esfera que no es de tipo A no ocurre nada al pulsar el espacio.

He a�adido adem�s que se eliga un color aleatorio cada vez que el jugador entra en contacto con una esfera, para que no siempre sea amarillo.

## 3)b)

A las esferas les he colocado un rigidbody para que respondan a la f�sica.
Para los cilindros he creado un script llamado Runaway que b�sicamente calcula la distancia entre el jugador y el cilindro y si esta es menor que cierto valor *"distanciaMinima_"* aplica una fuerza proporcional a la distancia y en direcci�n al jugador.

![imagen](/3b1.png)
![gif](/3b2.gif)

## 3)c)

Como segundo objeto controlable he puesto un cilindro que se controla con las teclas I, J, L y M. 
Para detectar los dos tipos de colisiones he puesto los 3 m�todos de los dos tipos de colisiones:

1. Las colisiones f�sicas: 
	- `OnCollisionEnter`
	- `OnCollisionStay` 
	- `OnCollisionExit` 

2. Las trigger: 
	- `OnTriggerEnter`
	- `OnTriggerStay`
	- `OnTriggerExit`

![imagen](/3c1.png)
![gif](/3c2.gif)

En el gif se puede observar como se imprime por pantalla el nombre de los objetos con los que choca la c�psula.

## 3)d)

En el �ltimo apartado se nos pide crear unos cubos que aumenten de tama�o cuando cualquier esfera se les acerque y que disminuya cuando el jugador se acerque.
Para llevar a cabo esto usar� el metodo `LocalScale` del transform.
Como en el enunciado dice _"esferas"_ he tenido que usar 2 vectores uno para las esferas tipo A y otro para las normales porque recupero estos objetos a trav�s de sus etiquetas.

![imagen](/3d1.png)
![gif](/3d2.gif)
En el gif podemos observar que el cubo deja de enconger cuando el jugador se aleja.

![gif](/3d3.gif)
En el gif podemos observar que el cubo deja de agrandarse cuando la esfera se aleja.