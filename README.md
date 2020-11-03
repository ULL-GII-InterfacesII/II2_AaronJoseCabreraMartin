# II2_AaronJoseCabreraMartin

---

## 1)a)

En el apartado 1)a) como es lógico al no añadir físicas a ninguno de los dos objetos, no se mueve ninguno.

![imagen](/1a.png)

## 1)b)

En el apartado 1)b) nos pide añadirle físicas a la esfera, para ello, clickearemos en la esfera, luego en AddComponent, RigidBody

Observamos como la esfera cae por el efecto de la gravedad

![gif](/1b.gif)


## 1)c)

En el apartado 1)c) nos pide añadirle físicas al cubo, para ello, seguiremos el mismo proceso que con la esfera

Observamos como tanto la esfera como el cubo cae por el efecto de la gravedad

![gif](/1c.gif)


## 1)d)

Para añadir masa a la esfera, vamos a la esfera y en su apartado de rigidbody podemos observar que hay un campo llamado mass que por defecto viene a 1 unidad. Para hacer que la esfera tenga 10 veces más masa que el cubo cambiaremos el valor de mass a 10 unidades

![imagen](/1d1.png)

Observamos como tanto la esfera como el cubo caen a la vez por el efecto de la gravedad

![gif](/1d2.gif)

También he deformado algo el terreno para observar como colisionan 
![gif](/1d3.gif)

## 1)e)

Primero para eliminar las físicas del cubo; debemos ir al cubo, buscar su rigidbody y eliminar este componente.

![imagen](/1e1.png)

Luego, en el mismo cubo en la zona de _"Box Collider"_ encontraremos una casilla en la que podremos marcar Is Trigger o no. La dejamos activa.

![imagen](/1e2.png)

Si ejecutamos este sería el resultado

![gif](/1e3.gif)

Podemos observar que al cubo no se le aplican las físicas, si el cubo y la esfera entrasen en contacto con una colisión se llamarían a las funciones OnTriggerEnter, OnTriggerExit y OnTriggerStay ya que estarían colisionando un rigidbody y un objeto IsTrigger, estos métodos representan que existe una colisión pero que esta no produce una reacción física.

## 1)f) 
Para volver a activarle las físicas al cubo seguimos los pasos que mostré anteriormente.
![gif](/1f1.gif)

Podemos observar que el cubo al llegar al suelo, lo atraviesa y continúa cayendo. He bajado un poco la cámara para observar que sigue cayendo incluso al atravesar el suelo. Porque ahora le afecta la gravedad pero no colisiona con otros objetos en el sentido físico sino que los atraviesa y llama a las funciones Trigger mencionadas anteriormente, estas se llaman siempre que un GameObject colisiona con otro GameObject.

## 1)g)
Desactivamos el IsTrigger del cubo, comprobamos la masa de la esfera y la dejamos a 10 unidades ya que el cubo pesa 1, al igual que expliqué en apartados anteriores. Ahora para desactivar la rotación sobre el plano XZ del cubo, vamos hasta la sección de las propiedades de su rigidbody y marcamos las casillas freze-rotation XZ.

![imagen](/1g1.png)

He colocado un plano algo inclinado para provocar que ambos objetos roten.
Este sería el resultado:

![gif](/1g2.gif)

Podemos observar que el cubo no rota en el plano XZ pero en el eje Y si, justo al final cuando el cubo llega al suelo y la esfera lo rota ligeramente.

## 2)a)

Primero creé un GameObject cubo al que llamare _"CubePlayer"_, luego creé un script llamado _"CharacterControllerCube"_. 
Para conseguir desplazar el cubo con el script tenemos que acceder a su __Transform__ porque este no posee físicas. Si tuviera físicas deberíamos usar su __Rigidbody__ y usar el método _"addforce"_ para no confundir al motor de físicas.
Para desplazar al cubo simplemente añadiré un atributo privado de tipo Transform y al que llamaré tf_, en el método _Start()_ inicializaré a tf_ con la referencia que devuelve el método **_GetComponent<Transform>()_**, este método nos devolverá una referencia al transform del objeto al que le añadamos este script. Y por último en el método _Update()_ añadiré la siguiente sentencia: `tf_.Translate( Vector3.forward * Time.deltaTime);`
En la sentencia observamos que accedemos al método Translate y le pasamos un Vector3.forward que quiere decir un vector que apunta a lo que nuestro GameObject tiene enfrente, además ese vector es multiplicado por un escalar, un número, _Time.delteTime_ el cual es desde el frame que nos encontramos, el tiempo que se tarda en generar el siguiente frame. Lo haré así por si se produce una bajada de FPS que se calcule bien la posición en la que debería quedar.
![imagen](/2a1.png)
**Muy importante:** no olvidar debemos añadir el script a los componentes del GameObject _"CubePlayer"_ podemos añadirlo simplemente arrastrando el script hasta el nombre del dicho GameObject en la columna de objetos 3D. Sino, nuestro script no será ejecutado.
![gif](/2a2.gif)
Podemos observar que el CuboPlayer atraviesa el otro cubo, esto es así porque CuboPlayer no tiene físicas, no es un RigidBody.

## 2)b)

Para graduar la velocidad, añadiré un atributo público de tipo float llamado velocity_, lo haré público para poder acceder a este desde el inspector de objetos.

El atributo velocity_ lo inicializaré con el valor 1.5F en el método _Start()_ y en el update, en la sentencia de *"tf_.Translate"* añadire el atributo velocity_ como otro escalar que multiplica al Vector3, así este atributo afectará linealmente a la velocidad de desplazamiento del objeto.

![imagen](/2b1.png)

Si ejecutamos este sería el resultado:

![gif](/2b2.gif)

Podemos editar el atributo velocity desde el inspector, si por ejemplo le ponemos un valor de 10 unidades este sería el resultado:

![gif](/2b3.gif)

## 2)c)

Para escuchar que hace el usuario tenemos la clase __Input__. Utilizando el método _"GetKey"_ de esta clase podemos detectar si un usuario está pulsando la tecla concreta que le pasemos.
Como he decidido que voy a utilizar las flechas de dirección, en Update() situaré 4 sentencias if para detectar que tecla o teclas está pulsando el usuario y desplazar el CubePlayer en consecuencia.

![imagen](/2c1.png)

También he añadido unos Debug.log() para saber que flecha está detectando en cada momento.

![gif](/2c2.gif)

---
# Ejercicios hechos la siguiente semana
---

## 2)d)
En el ejercicio 2d nos pide que añadamos la posibilidad de rotar al personaje sobre sí mismo para poder girar. Usaré las teclas _"**a**"_ y _"**d**"_ para esto. Simplemente cuando detecte que el jugador las pulsa llamaré al método rotate.

![imagen](/2d1.png)
![gif](/2d2.gif)

## 3)a)
En este apartado se nos pide crear varias esferas. **Todas** las esferas deben cambiar de color cada vez que entren en contacto con el jugador. Además si se trata de una **esfera de tipo A** si mientras el jugador están en contacto se pulsa la barra espaciadora el jugador la impulsa hacia fuera de él.

Inicialmente, lo haré con una esfera normal y con una esfera tipo A para programar su comportamiento. Ya que, una vez tenga sus scripts simplemente habrá que crear nuevas esferas y añadirles el script.

Para detectar la colisión entre una esfera y el cubo jugador debemos usar la función `OnTriggerEnter` la cual recibe un _Collider_. Lo primero que hago es comprobar que ese collider tiene la etiqueta **_Player_** y si es así accedo al _Render_ para cambiar el color del material. Este script lo llevarán **todas** las esferas.

![imagen](/3a1.png)
![gif](/3a2.gif)

Para la parte de impulsar hacia fuera del jugador las esferas del tipo A me pareció más adecuado añadir un `OnTriggerStay` en el script que controla el cubo judador. Simplemente si detectamos una colisión continuada (Stay) tipo trigger, el objeto contra el que colisionamos tiene la etiqueta _"EsferasA"_ y el jugador esta pulsando la tecla espacio, le aplicamos una fuerza tipo Explosión al otro objeto.

![imagen](/3a3.png)
![gif](/3a4.gif)
En el gif podemos observar que la primera esfera, que es de tipo A al pulsar el espacio sale volando pero la segunda esfera que no es de tipo A no ocurre nada al pulsar el espacio.

He añadido además que se eliga un color aleatorio cada vez que el jugador entra en contacto con una esfera, para que no siempre sea amarillo.

## 3)b)

A las esferas les he colocado un rigidbody para que respondan a la física.
Para los cilindros he creado un script llamado Runaway que básicamente calcula la distancia entre el jugador y el cilindro y si esta es menor que cierto valor *"distanciaMinima_"* aplica una fuerza proporcional a la distancia y en dirección al jugador.

![imagen](/3b1.png)
![gif](/3b2.gif)

## 3)c)

Como segundo objeto controlable he puesto un cilindro que se controla con las teclas I, J, L y M. 
Para detectar los dos tipos de colisiones he puesto los 3 métodos de los dos tipos de colisiones:

1. Las colisiones físicas: 
	- `OnCollisionEnter`
	- `OnCollisionStay` 
	- `OnCollisionExit` 

2. Las trigger: 
	- `OnTriggerEnter`
	- `OnTriggerStay`
	- `OnTriggerExit`

![imagen](/3c1.png)
![gif](/3c2.gif)

En el gif se puede observar como se imprime por pantalla el nombre de los objetos con los que choca la cápsula.

## 3)d)

En el último apartado se nos pide crear unos cubos que aumenten de tamaño cuando cualquier esfera se les acerque y que disminuya cuando el jugador se acerque.
Para llevar a cabo esto usaré el metodo `LocalScale` del transform.
Como en el enunciado dice _"esferas"_ he tenido que usar 2 vectores uno para las esferas tipo A y otro para las normales porque recupero estos objetos a través de sus etiquetas.

![imagen](/3d1.png)
![gif](/3d2.gif)
En el gif podemos observar que el cubo deja de enconger cuando el jugador se aleja.

![gif](/3d3.gif)
En el gif podemos observar que el cubo deja de agrandarse cuando la esfera se aleja.