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

Podemos observar que el cubo al llegar al suelo desaparece
