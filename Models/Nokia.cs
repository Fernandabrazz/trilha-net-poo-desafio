using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 namespace  DesafioPOO.Models

    // Inherit from the abstract class "Smartphone"
    {
 
    
    public class Nokia  : Smartphone
    {
    public Nokia (string numero, string modelo, string imei, int memoria) : base (numero,modelo, imei,memoria)
          {

          }

     
          // TODO: Sobrescrever o método "InstalarAplicativo"
     
       public override void InstalarAplicativo (string nomeApp)

        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia .");
                    } 

    }

}

 