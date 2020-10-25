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