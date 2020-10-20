# Traducción de voz en tiempo real con Azure Cognitive Services

### Creamos el servicio de Voz 
* Nos dirigimos al [portal de Azure](https://portal.azure.com/)
* Iniciamos sesión con la cuenta que tiene la suscripción.
* Damos clic en +, Crear un Recurso
    - Escribimos "Speech" en la barra de búsqueda
    - Seleccionamos Speech
    - Clic en Crear
    - Llenamos los datos solicitados:
       - Nombre: `speech01`
       - Suscripción: Cuenta que tiene la suscripción
       - Ubicación: Por default
       - Plan de Tarifa: F0
       - Grupo de recursos: `nubers-speech` (Crear nuevo) o elegir uno ya creado.
Esperamos en lo que se configura nuestro grupo de recursos (3min)

###  Obteniendo las credenciales del API Cognitive Services Speech

- Vamos a grupo de recursos y damos clic
- Seleccionamos `nubers-speech`
- Del lado izquierdo en la sección **ADMINISTRACIÓN DE RECURSOS** seleccionamos **Claves y punto de conexión**
- Copiamos la Key 1, Key 2 (Posteriormente usaremos 1 de las 2) y copiamos la región.

### Configuración del entorno de desarrollo

En el training podrás encontrar una manera, sin embargo como tu Sherpa te puedo mostrar otra forma de hacerlo sin que te cobren Azure y es a través de GitHub Codespaces, si bien lo debes hacer como lo marca el training puedes solicitar el acceso a Codespaces para que en un futuro no dependas del servicio de VisualStudio Code en la Nube. 

Aunque como lo mencioné **DEBES HACERLO COMO LO INDICA EL TRAINING** a menos que tengas ya habilitada la beta de Codespaces entonces hazlo como quieras. **NO RESUELVO DUDAS SOBRE ESTE PUNTO**

#### Configuración vía GitHub Codespaces
* ##### Solicitar el acceso a GitHub Codespaces
    Si quieres solicitar el acceso debes hacer lo siguiente:
    - Ingresar a la [página oficial](https://github.com/features/codespaces)
    - Posteriormente seleccionar **Request early access*
    - Una vez aprobado te llegará un correo (Este proceso suele tardar bastante, así que ten paciencia)
    - Si ya te llego el correo de aceptación continúa con la configuración, **si no te llegó o ya tardó mucho, continúa con el ejercicio en VS Code** tal y como lo mencioné desde el principio.

* ##### Configuración de GitHub CodeSpaces
    Escribimos en la terminal: 
    - Nos vamos a nuestro proyecto con `cd Nombre del proyecto` (En mi caso es necesario)
    - `dotnet new terminal `  

    Con esto hemos configurado la estructura de un proyecto en C#
    - Ahora abrimos `Program.cs` y pegamos el código proporcionado en este gist.
    - En la terminal agregamos lo siguiente `dotnet add package Microsoft.CognitiveServices.Speech` para instalar el paquete de los servicios cognitivos de Speech. 
    - Ahora agregamos la clave de la suscripción dónde están las siguientes palabras (Línea 15)  `Clave 1` y la región en la palabra `region` de nuestro recurso en Azure. 
    - Agregamos la localización de nuestro archivo de audio (Línea 18), en este caso es `hola.wav`
    - Listo es hora de probar el código

* #### Configuración vía VS Code Online (Tal y como lo especifica el training)
    * 1.- Abrir una pestaña o ventana del explorador y entrar a [Visual Studio Code en línea](https://online.visualstudio.com/login).
    * 2.- Creamos un entorno: 
        - Seleccionas tu plan de facturación
        - Escribimos la ubicación del servicio
        - Más detalles y agregamos el grupo de recursos.
        - Damos clic en crear y llenamos lo siguiente: 
            - Link de Repo: https://github.com/MicrosoftLearning/SpeechToTextCS
            - Valores predeterminados
        - Crear y esperamos a que finalice la creación del entorno (Demora unos 5min)
    * 3.- Una vez que está creado damos clic en Conectar y esperamos un poco más.

    * ##### Código  (Tal y como lo especifica el training)
        * Nos vamos al menú-> Ver->Seleccionamos Terminal (La cual deberá ser Bash)
        
        Escribimos en la terminal: 
        - `dotnet new console `
        Con esto hemos configurado la estructura de un proyecto en C#
        - Ahora abrimos `Program.cs` y pegamos el código proporcionado en este gist.
        - En la terminal agregamos lo siguiente `dotnet add package Microsoft.CognitiveServices.Speech` para instalar el paquete de los servicios cognitivos de Speech. 
        - Ahora agregamos la clave de la suscripción dónde están las siguientes palabras (Línea 15)  `Clave 1` y la región en la palabra `region` de nuestro recurso en Azure. 
        - Agregamos la localización de nuestro archivo de audio (Línea 18), en este caso es `hola.wav`

### Probamos el Código 

- Por último escribimos en la terminal `dotnet run` para ejecutar nuestro código.

**Listo, de esta manera logramos transcribir a texto un audio con los servicios cognitivos de Azure.**

![](https://raw.githubusercontent.com/FernandaOchoa/InnovaccionNube/main/SpeechC/images/speech.PNG?token=ACFTV5JYEO3XDGDLZIDNI6S7TBOIE)
