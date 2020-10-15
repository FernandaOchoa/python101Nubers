using System;

using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
namespace HelloWorld {
    class Program {
        // Accesamos a los servicios con una función Async
        static async Task Main() {
            await RecognizeSpeechAsync();
        }
        static async Task RecognizeSpeechAsync() {
            // Configuramos la información para accesar a los servicios.
            // Podemos usar la Clave 1 o Clave 2 que hemos creado con Servicio de Speech en Azure
            var config = SpeechConfig.FromSubscription("TUCLAVE", "TUREGION");
            
            // Agregamos el archivo de audio, en este caso es un hola.
            using (var audioInput = AudioConfig.FromWavFileInput("hola.wav"))

            //Pasamos los parámetros requeridos para el Servicio de Speech el cuál incluye la información de configuración
            // y el archivo de audio que quieres transcribir
            using (var recognizer = new SpeechRecognizer(config, audioInput)) {
                Console.WriteLine("Recognizing first result...");
                var result = await recognizer.RecognizeOnceAsync();
                switch (result.Reason) {
                    case ResultReason.RecognizedSpeech:
                        // El archivo de audio es reconocido y la transcripción se mostrará en la salida.
                        // en la ventana output de la terminal
                        Console.WriteLine($"He reconocido: {result.Text}");
                    break;
                    
                    case ResultReason.NoMatch:
                        // Cuando no se puede reconocer el audio del archivo que se ha especificado.
                        // Salida del mensaje con el error
                        Console.WriteLine($"NOMATCH: No he podido reconocer el archivo especificado.");
                    break;
                    
                    case ResultReason.Canceled:
                        // Se cancela todo
                        // Mostramos el por qué
                        var cancellation = CancellationDetails.FromResult(result);
                        Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");
                        if (cancellation.Reason == CancellationReason.Error) {
                            Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                            Console.WriteLine($"CANCELED: ErrorDetails={cancellation.ErrorDetails}");
                            Console.WriteLine($"CANCELED: ¿Quieres actualizar la información de la Suscripción?");
                        }
                    break;
                } 
            }
        }
    }
}