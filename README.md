# SkyOnTheRoad
Trabajo de proyecto movil

<img width="692" height="388" alt="GIFMobileGame" src="https://github.com/user-attachments/assets/894ec5a2-a147-4dbb-8c3e-8a5ebeefc11a" />

Una frase: Gameplay interactivo del juego mobile, con el movimiento del telefono controlas al jugador para poder saltar entre plataformas y llegar mas alto, buscando mantenerte concentrado y ser preciso con los saltos y no caerte para perder.

## Como Jugar
[APK](https://jo4k1t00.github.io/PortafolioJoakito/SkyOnTheRoad.apk)

## Controles
Se requiere un dispositivo móvil que cuente con un sensor de giroscopio integrado por hardware. Esto es indispensable para validar la precisión de las mecánicas de control basadas en movimiento.

## Requisitos e instalación
Unity 6000.0.72f1 (esto si quieres revisarlo desde el proyecto creado, si quieres jugarlo vuelve al APK)

## Mi aporte
Me encargue de llevar la idea a lo largo del proyecto de nota de mi ramo de videojuegos móviles de la universidad Bernardo O'higgins, un trabajo individual el cual consistia en la utilizacion de las herramientas dispuestas que nos dio el profesor, el cual hice:

### Programación

Programe cada seccion de las interacciones, entre ellas estan coleccion, control de personaje, salto, spawn de plataformas, nubes, puntaje y uso de canvas:

#### Menu

##### MenuManager (Control principal de los botones del menu)

<img width="750" height="720" alt="image" src="https://github.com/user-attachments/assets/0ac309f9-5516-4cd3-bcb7-1243fd5cf68d" />

##### MenuCloudMover (Sistema de nubes con movimiento por medio del menu)

<img width="536" height="405" alt="image" src="https://github.com/user-attachments/assets/2dce3085-f4a9-4dff-b9a1-78a612927663" />

##### PausarJuego (reproduce el sonido y genera el panel de pausa)

<img width="616" height="401" alt="image" src="https://github.com/user-attachments/assets/acf213c4-ef29-4dc0-9c51-70868abbd338" />

#### Nubes de fondo 

##### CloudManager (Controlador de nubes)

<img width="557" height="622" alt="image" src="https://github.com/user-attachments/assets/8ad089b9-b23f-4c2c-8cba-d2ecc3a347df" />

<img width="582" height="342" alt="image" src="https://github.com/user-attachments/assets/349536c5-c794-462c-94ee-cb6b67e38009" />

##### CloudLimpiador (control total de limpieza de nubes)

<img width="451" height="302" alt="image" src="https://github.com/user-attachments/assets/f02ae353-b6a2-44ae-8376-fecdc17e64fb" />

#### In-Game

##### PlayerJumper (Control del personaje y su control de salto)

<img width="616" height="587" alt="image" src="https://github.com/user-attachments/assets/23bfdaea-6ebb-42a7-8317-4e6ddab330a5" />

<img width="588" height="546" alt="image" src="https://github.com/user-attachments/assets/355b4570-18c2-4dc5-826e-b29240176b15" />

<img width="657" height="720" alt="image" src="https://github.com/user-attachments/assets/8d7624e2-3639-4f13-8dc3-c9df10bd6352" />

##### PlatformManager (Generacion de plataformas)

<img width="548" height="517" alt="image" src="https://github.com/user-attachments/assets/431ef0d3-5c8e-40bc-910b-952a2f9c5815" />

<img width="612" height="727" alt="image" src="https://github.com/user-attachments/assets/71c01610-25b1-40c5-aeea-80faac235310" />

##### OneWayPlatform (Condiciones de plataformas, si es el inicial o no)

<img width="261" height="115" alt="image" src="https://github.com/user-attachments/assets/55ba5a52-25ff-4685-b089-54cc8660e28e" />

##### Destroyer (destruirlo si tiene el OneWayPlatform)

<img width="485" height="178" alt="image" src="https://github.com/user-attachments/assets/7f5c02b3-da24-44c4-ab33-f956a54fba9b" />

##### CameraFollowY (Perseguidor de la camara al personaje)

<img width="590" height="732" alt="image" src="https://github.com/user-attachments/assets/b958ad95-762e-4b52-bd7d-40887b92cd24" />

##### GameManager (Las monedas recolectadas, se acumulan y genera una explosion de particulas con un sonido)

<img width="577" height="703" alt="image" src="https://github.com/user-attachments/assets/a407072e-7ec0-458a-a2bb-c7614893c1b5" />

<img width="405" height="397" alt="image" src="https://github.com/user-attachments/assets/7072afa2-8d34-4458-88fc-5634d436f176" />

##### Coin (Monedas coleccionables)

<img width="562" height="357" alt="image" src="https://github.com/user-attachments/assets/9414912b-c179-4e59-98a3-6ce72e7f3e90" />

##### GameOverTrigger (sistema de Gameover para generar el panel y detener el juego)

<img width="608" height="582" alt="image" src="https://github.com/user-attachments/assets/8b83385b-3f48-4a52-b9ee-d1645c1560b9" />

<img width="617" height="357" alt="image" src="https://github.com/user-attachments/assets/5269b13f-cc6b-4953-8a52-b30b933e0357" />

##### ScoreManager (Acumulacion de metros, imprime la cantidad de metros logrados al subir)

<img width="500" height="636" alt="image" src="https://github.com/user-attachments/assets/74fcf35d-d34e-4fa3-a943-5a63334b3db6" />

##### SafeArea (Ajuste de Canva para la camara)

<img width="582" height="702" alt="image" src="https://github.com/user-attachments/assets/b5988197-6411-40bd-a786-88c92604f791" />

### Modelado del personaje

#### Personaje (Personaje modelado y construido por huesos para animacion)
<img width="1587" height="623" alt="Jumperin" src="https://github.com/user-attachments/assets/86ba55dd-6e15-4caf-9dc4-a477643321dc" />

<img width="273" height="492" alt="Enfoque" src="https://github.com/user-attachments/assets/402c5aae-ec8a-4c66-bc3c-cd9405778f24" />

<img width="465" height="516" alt="Captura de pantalla 2026-07-21 010624" src="https://github.com/user-attachments/assets/f933f2b4-ac10-445a-9d5c-fb2e41cd96b2" />

