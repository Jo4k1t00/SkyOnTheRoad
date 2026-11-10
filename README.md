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

## Mi Experiencia y aporte
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

##### FakePlayerTarget (jugador señuelo para utilizar las nubes)

<img width="523" height="218" alt="image" src="https://github.com/user-attachments/assets/ab667a7b-c5eb-4403-b118-eb8248d7ec0a" />

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


### Montaje de unity

Después de todo este código hay que compilar todo lo codificado en cada sección de la jerarquia

<img width="342" height="432" alt="image" src="https://github.com/user-attachments/assets/9aec0246-7769-4194-b3aa-1e6fad9e3361" />

#### Plataformas

##### PlatformManager

<img width="472" height="543" alt="image" src="https://github.com/user-attachments/assets/09bb7201-f85e-4445-be01-5e494c5ee21e" />

<img width="251" height="20" alt="image" src="https://github.com/user-attachments/assets/398292d3-26e3-4aec-bf22-3b50343159d2" />

#### OneWayPlatform 

<img width="470" height="132" alt="image" src="https://github.com/user-attachments/assets/5decf32a-397b-4407-99ca-d082d04cb349" />

#### Player

Se necesito de un sistema de partículas, el personaje y su animacion

##### Orden

<img width="482" height="321" alt="image" src="https://github.com/user-attachments/assets/05773d04-39a9-4154-83e9-3f8be1ad5750" />

##### Configuración del script Jugador dentro

<img width="457" height="605" alt="image" src="https://github.com/user-attachments/assets/97eecd2b-b47e-459b-ac7a-d775b60c2e54" />

##### Animacion

<img width="1206" height="357" alt="image" src="https://github.com/user-attachments/assets/8d97c04e-c038-48cf-b0b3-80bf067e69f2" />

#### Puntaje

##### ScoreManager

<img width="476" height="152" alt="image" src="https://github.com/user-attachments/assets/3f8e0f63-462f-47de-a685-1fcbd972df4f" />

##### Monedas

<img width="471" height="736" alt="image" src="https://github.com/user-attachments/assets/ba560a55-4092-4745-bb47-ee9bd471049f" />

##### GameManager

<img width="475" height="142" alt="image" src="https://github.com/user-attachments/assets/5a0ca970-2521-43db-829c-7ddc6c5365f2" />

#### Menú

##### Pausa

<img width="461" height="192" alt="image" src="https://github.com/user-attachments/assets/3eb62d7c-5cc7-4f29-a6db-27ea36a3b1d2" />

##### MenuManager

<img width="461" height="170" alt="image" src="https://github.com/user-attachments/assets/a3706c20-e16d-493a-ba8e-1bf91bb789b8" />

#### Nubes

##### Gestor de nube (CloudManager In-Game)

<img width="476" height="416" alt="image" src="https://github.com/user-attachments/assets/8a0a41d7-8a08-4a68-a5ff-2d5111699091" />

##### Gestor de nube (CloudManager Menu)

<img width="475" height="417" alt="image" src="https://github.com/user-attachments/assets/be2bf789-2477-4750-867c-0035ed62815a" />

#### Cámara en Y

<img width="457" height="215" alt="image" src="https://github.com/user-attachments/assets/dbd8080c-35e4-429d-ae16-61ecc3e95011" />

#### Implementacion de botones (especificar cada boton con su interaccion especifica)

<img width="442" height="140" alt="image" src="https://github.com/user-attachments/assets/fb135c38-8dea-4f1d-91a3-60d2ec4a6175" />

<img width="450" height="130" alt="image" src="https://github.com/user-attachments/assets/74114f89-61e5-4bb6-b412-ef367bdd4b2b" />

<img width="443" height="135" alt="image" src="https://github.com/user-attachments/assets/d048f738-1c2b-47df-bf99-a18d4953855c" />

<img width="442" height="133" alt="image" src="https://github.com/user-attachments/assets/3d6c1d0d-46c6-472b-b676-0f3a2d1e5f55" />

<img width="445" height="141" alt="image" src="https://github.com/user-attachments/assets/eccb2d3a-8330-4e8d-ab97-57c4b96ad269" />

### Modelado del personaje (Tim)

Modele al personaje y configure sus huesos para animar su salto y sistema de caida.

#### Personaje (Personaje modelado y construido por huesos para animacion)

<img width="1587" height="623" alt="Jumperin" src="https://github.com/user-attachments/assets/86ba55dd-6e15-4caf-9dc4-a477643321dc" />

<img width="273" height="492" alt="Enfoque" src="https://github.com/user-attachments/assets/402c5aae-ec8a-4c66-bc3c-cd9405778f24" />

<img width="465" height="516" alt="Captura de pantalla 2026-07-21 010624" src="https://github.com/user-attachments/assets/f933f2b4-ac10-445a-9d5c-fb2e41cd96b2" />

#### Moneda (Modelo de moneda)

<img width="517" height="617" alt="image" src="https://github.com/user-attachments/assets/b3e16dbe-2da1-4a38-8c8b-40bd67707f97" />

<img width="512" height="577" alt="image" src="https://github.com/user-attachments/assets/f0e1f3ec-db6e-43e0-85b4-7711740ce95f" />
