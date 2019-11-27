using System;
using System.IO;


namespace Tarea
{
    class Program
    {
   
       public static void Main(string[] args)
        {
         Programa c1 = new Programa(); 
         c1.inicio(); 
        }
    }

    class Programa {
            
            
        public string leer(string txt){
            Console.Write(txt);
            string val = Console.ReadLine();
            if(val.Length < 1){
                leer(txt);
            }
            return val;
        }
        public static void openit(string x){
           System.Diagnostics.Process.Start("cmd", "/C start" + " " + x);
         }
    //      private static string ReadLine(string txt)
    //    {
    //         Stream inputStream = Console.OpenStandardInput(10000);
    //     byte[] bytes = new byte[10000];
    //     int outputLength = inputStream.Read(bytes, 0, 10000);
    //     //Console.WriteLine(outputLength);
    //     char[] chars = Encoding.UTF8.GetChars(bytes, 0, outputLength);
    //     return new string(chars);
    //    }
        public int fecha(string txt1){
            Console.Write(txt1);
            int val = int.Parse(Console.ReadLine());
            return val;
        }

       
        public void inicio(){
            Console.Clear();
            Console.WriteLine("Programa Para Capturar Datos Personales");
           string name = leer("Digite su nombre: ");
           string lastName = leer("Digite su Apellido: ");
           string id = leer("Digite su Cedula: ");
           int dia = fecha("Digite el dia de su nacimiento: ");
           int mes = fecha("Digite el mes de su nacimiento(En numero): ");
           int año = fecha("Digite el año de su nacimiento: ");
           string phoneNumber = leer("Digite su Telefono: ");
           string adress = leer("Digite su Direccion: ");
           string bloodType = leer("Digite su tipo de sangre: ");
           string email = leer("Digite su Correo:");
           string gender = leer("Digite su Genero:");
           string schooling = leer("Digite los  estudios que ha realizados: ");
           string lastJobs = leer("Digite los Trabajos que ha tenido: ");
           string goal = leer("Escriba ¿Cual es su objetivo en la vida? : ");
           string socialMedia = leer("Escriba el link a su red social favorita: ");
           string fN =  (dia+"/"+mes+"/"+año);
           string zodiaco ="";
        
       
        //** CALCULAR LA EDAD    
            int age =DateTime.Now.Year - año;
            int m = DateTime.Now.Month - mes;
            int d = DateTime.Now.Day - dia;  

        // ** AÑADIR IMAGEN AL ZODIACO
                string Aries = "<img src='https://www.astrology-zodiac-signs.com/images/aries.jpg' style= width:40px; height:40px; alt='img'>";
                string Tauro = "<img src='https://www.astrology-zodiac-signs.com/images/taurus.jpg' style= width:40px; height:40px; alt='img'>";
                string Géminis = "<img src='https://www.astrology-zodiac-signs.com/images/gemini.jpg' style= width:40px; height:40px; alt='img'>";
                string Cáncer = "<img src='https://www.astrology-zodiac-signs.com/images/cancer.jpg' style= width:40px; height:40px; alt='img'>";
                string Leo = "<img src='https://www.astrology-zodiac-signs.com/images/leo.jpg' style= width:40px; height:40px; alt='img'>";
                string Virgo = "<img src='https://www.astrology-zodiac-signs.com/images/virgo.jpg' style= width:40px; height:40px; alt='img'>";
                string Libra = "<img src='https://www.astrology-zodiac-signs.com/images/libra.jpg' style= width:40px; height:40px; alt='img'>";
                string Escorpio = "<img src='https://www.astrology-zodiac-signs.com/images/scorpio.jpg' style= width:40px; height:40px; alt='img'>";
                string Sagitario = "<img src='https://www.astrology-zodiac-signs.com/images/sagittarius.jpg' style= width:40px; height:40px; alt='img'>";
                string Capricornio = "<img src='https://www.astrology-zodiac-signs.com/images/capricorn.jpg' style= width:40px; height:40px; alt='img'>";
                string Acuario = "<img src='https://www.astrology-zodiac-signs.com/images/aquarius.jpg' style= width:40px; height:40px; alt='img'>";
                string Piscis = "<img src='https://www.astrology-zodiac-signs.com/images/pisces.jpg' style= width:40px; height:40px; alt='img'>";
       
        // ** SIGNO DE ZODIACO
                 zodiaco = (dia >= 21 && mes == 3 || dia <= 20 && mes == 4 ) ? zodiaco = "Aries "+Aries :
                 zodiaco = (dia >= 21 && mes == 4 || dia <= 21 && mes == 5 ) ? zodiaco = "Tauro "+Tauro :
                 zodiaco = (dia >= 22 && mes == 5|| dia <= 21 && mes == 6 ) ? zodiaco = "Géminis "+Géminis :
                 zodiaco = (dia >= 22 && mes == 6 || dia <= 22 && mes == 7 ) ? zodiaco = "Cáncer "+Cáncer :
                 zodiaco = (dia >= 23 && mes == 7 || dia <= 23 && mes == 8 ) ? zodiaco = "Leo "+Leo :
                 zodiaco = (dia >= 24 && mes == 8 || dia <= 23 && mes == 9 ) ? zodiaco = "Virgo "+Virgo :
                 zodiaco = (dia >= 24 && mes == 9 || dia <= 23 && mes == 10 ) ? zodiaco = "Libra "+Libra :
                 zodiaco = (dia >= 24 && mes == 10 || dia <= 22 && mes == 11 ) ? zodiaco = "Escorpio "+Escorpio :
                 zodiaco = (dia >= 23 && mes == 11 || dia <= 21 && mes == 12 ) ? zodiaco = "Sagitario "+Sagitario :
                 zodiaco = (dia >= 22 && mes == 12 || dia <= 20 && mes == 1 ) ? zodiaco = "Capricornio "+Capricornio :
                 zodiaco = (dia >= 21 && mes == 1 || dia <= 18 && mes == 2 ) ? zodiaco = "Acuario "+Acuario :
                 zodiaco = (dia >= 19 && mes == 2 || dia <= 20 && mes == 3 ) ? zodiaco = "Piscis "+Piscis :zodiaco ="";

        // ** AQUI CREE LA CARPETA CV
           string ruta ="CV" ;
           if(Directory.Exists(ruta) == false){
               Directory.CreateDirectory(ruta);
           }

        // ** Operador ternario

            string color = (gender.ToLower() == "f") ? "pink" : "lightblue";

        //** AQUI SE CREO EL ARCHIVO HTML
        //    string contenido = "<html>"+"<head>"+"</head>"+"<body style ='background :"+color+"'>"+"<table border ='1'><tr><th>Nombre</th><td>"+name+"</td></tr>"+"<tr><th>Apellido</th><td>"+lastName+"</td></tr>"+"<tr><th>Cedula</th><td>"+id+"</td></tr>"+"<tr><th>Telefono</th><td>"+phoneNumber+"</td></tr>"+"<tr><th>Direccíon</th><td>"+adress+"</td></tr>"+"<tr><th>Tipo de Sangre</th><td>"+bloodType+"</td></tr>"+"<tr><th>Correo</th><td>"+email+"</td></tr>"+"<tr><th>Genero</th><td>"+gender+"</td></tr>"+"<tr><th>Fecha de nacimiento</th><td>"+bDay+"</td></tr>"+"<tr><th>Estudios Realizado</th><td>"+schooling+"</td></tr>"+"<tr><th>Empleos anteriores</th><td>"+lastJobs+"</td></tr>"+"<tr><th>Metas</th><td>"+goal+"</td></tr>"+"<t><th>Red social favorita</th><td><a href ="+socialMedia+" target='blank'><span color='red'>"+socialMedia+"</span></a></td></tr>"+"</table>"+ "</body>"+ "</html>";
           string contenido =
           "<!DOCTYPE html>"+
           "<html lang='en'>"+
           "<head>"+
           "<meta charset='UTF-8'>"+
           "<meta name='viewport' content='width=device-width, initial-scale=1.0'>"+
           "<meta http-equiv='X-UA-Compatible' content='ie=edge'>"+
           "<title>Datos Personales</title>"+
           " <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css' integrity='sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u' crossorigin='anonymous'>"+
           "<link rel='stylesheet' href='"+name+".css'>"+
           "</head>"+
           "<body>"+
           "<h2 class='titulo'>Personal Informations</h2>"+
           "<div class='container'>"+
           "<br>"+
           "<br>"+
           "<form>"+
           "<div class='form-left'>"+
           "<div class='form-group-name'>"+
           " <div class='imgR' style='background-image: url(https://loremflickr.com/340/340/cars)' alt='Imagen'></div>"+
           "<h4><i><b><font size='8px'>"+name+"</font></b></i></h4>"+
           "<h4><i><font size='6px'>"+lastName+"</font></i></h4>"+
           "</div>"+
           "<br>"+
           "<br>"+
           "<div class='form-group'>"+
           "<label for='id'>Cedula</label><br>"+
           "<h4>"+id+"</h4>"+
           "</div>"+
           "<div class='form-group'>"+
           "<label for='fN'>Fecha de Nacimiento</label><br>"+
           "<h4>"+fN+"</h4>"+
           "</div>"+
           "<div class='form-group'>"+
           "<label for='age'>Edad</label><br>"+
           "<h4>"+age+" años</h4>"+
           "</div>"+
           "<div class='form-group'>"+
           "<label for='phoneNumber'>Telefono</label><br>"+
           "<h4>"+phoneNumber+"</h4>"+
           "</div>"+
           "<div class='form-group'>"+
           "<label for='adress'>Direccíon</label><br>"+
           "<h4>"+adress+"</h4>"+
           "</div>"+
           "<div class='form-group'>"+
           "<label for='bloodType'>Tipo de Sangre</label><br>"+
           "<h4>"+bloodType+"</h4>"+
           "</div>"+
           "<div class='form-group'>"+
           "<label for='email'>Correo</label><br>"+
           "<h4>"+email+"</h4>"+
           "</div>"+
           "<div class='form-group'>"+
           "<label for='gender'>Genero</label><br>"+
           "<h4>"+gender+"</h4>"+
           "</div>"+
           "<div class='form-group'>"+
           "<label for='zodiacSign'>Signo del Zodiaco</label><br>"+
           "<h4>"+zodiaco+"</h4>"+
           "</div>"+
           "</div>"+
           "<div class='form-right'>"+
           "<div class='form-group'>"+
           "<label class='schooling'>ESTUDIOS REALIZADO</label><br>"+
           "<h4>"+schooling+"</h4>"+
           "</div><br>"+
           "<div class='form-group'>"+
           "<label class='job'>EMPLEOS ANTERIORES</label><br>"+
           "<h4>"+lastJobs+"</h4>"+
           "</div><br>"+
           "<div class='form-group'>"+
           "<label class='goal'>META</label><br>"+
           "<h4>"+goal+"</h4>"+
           "</div><br>"+
           "<div class='form-group'>"+
           "<label class='socialMedia'>RED SOCIAL FAVORITA</label><br>"+
           "<h4>Click para visitar:<a href="+socialMedia+" target='_blank'><spancolor='red'>"+socialMedia+"</span></h4>"+
           "</div>"+
           "</div>"+
           "<br>"+
           "</form>"+
           "</div>"+
           "<script src='https://code.jquery.com/jquery-3.4.1.js'></script>"+
           "<script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js' integrity='sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa' crossorigin='anonymous'></script>"+
           "</body>"+
           "</html>";
           
        string contenidoCss =
        "*{margin: 0; padding: 0; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;}"+
        "h2{color: #d9edf7;	text-align: center;	border: 2px solid transparent; border-bottom-color: gray; border-radius: 50px; padding-bottom: 10px; padding-top: 10px; margin-top: 50px; margin-left: 200px; margin-right: 200px; font-size: 50px; box-shadow: 0 0 35px 5px black;}"+
        ".form-group h4 {line-height: 30px;	font-style: italic;	outline: inset cadetblue;}"+
        ".titulo:hover {border-bottom-color: gray;	box-shadow: 3px 3px 30px #4b4c50;}"+
        ".job,.goal,.socialMedia,.schooling {	color: #d9edf7;	border-bottom-color: gray;	border-radius: 5px;	padding: 10px;}"+
        ".job:hover,.goal:hover,.schooling:hover,.socialMedia:hover {box-shadow: 3px 3px 30px 0px black;border-radius: 15px;}"+
        "body {background-color: #34353a;}"+
        ".container {padding-left: 0px;margin-left: 300px;}"+
        "label {font: bold;font-size: 25px;}"+
        ".form-group-name {text-align: center;}"+
        ".imgR {margin: auto; margin-bottom: 35px; height: 200px; width: 200px; background-repeat: no-repeat; /*Esto es por si la img es pequeña*/ background-position: 50%; border-radius: 50%; background-size: 100% auto; /*Sirve para hacer que use la imagen con su tama;o completo, y no con una fracción de su tamaño*/ box-shadow: 3px 3px 30px #4b4c50; transition: width 0.8s, height 0.8s, margin 0.8s; }"+
        ".imgR:hover {width: 250px;height: 250px;margin: auto;margin-bottom: 35px;}"+
        ".form-left {float: left;margin: 0 auto;margin-top: 50px;margin-bottom: 50px;margin-left: -220px;width: 540px;height: 1340px;background-color: #34353a;border: 5px solid #505156;/* border-left: 5px solid #505156; */padding: 30px; /*MUY IMPORTANTE QUE ESTÉ AHÍ*/box-sizing: border-box;-webkit-box-sizing: border-box;box-sizing: padding-box;-webkit-box-sizing: padding-box;color: white;}"+
        ".form-left:hover {border-right-color: white;border-bottom-color: white;border-top-color: white;border-left-color: cadetblue;cursor: pointer;}"+
        ".form-right {float: right;margin-top: 140px;margin-right: 130px;height: 1000px;width: 597px;box-sizing: border-box;-webkit-box-sizing: border-box;-moz-box-sizing: border-box;padding: 25;color: white;}";
           


           File.WriteAllText("CV\\"+name+".html",contenido);
           File.WriteAllText("CV\\"+name+".css",contenidoCss);

        Console.WriteLine("Se a generado una carpeta llamada CV en la ruta CV");
        
        Console.WriteLine();
        openit("CV\\"+name+".html");

        string continuar = leer("Desea agregar los datos de otra persona S/N :"); 
        if(continuar.ToLower() == "s" ){
            inicio();
        }
        Console.WriteLine("Gracias por utilizarme!");
        Console.ReadKey();
        }

    }

}
