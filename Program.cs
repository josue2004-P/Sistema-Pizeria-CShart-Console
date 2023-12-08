namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

         opciones();
        }

      public static string ingrediente = "Sin Pedido";
      public static int cantidad;
      public static int tamaño;

        public static void opciones(){

         Console.Clear();
         Console.WriteLine("--------- Sistema Pizeria ---------");
         Console.WriteLine("");
         Console.WriteLine("[1] Realizar Pedido");
         Console.WriteLine("[2] Ver Pedido");
         Console.WriteLine("[3] Pagar Pedido");
         Console.WriteLine("[4] Salir");
         Console.WriteLine("");
         Console.WriteLine("------ Seleccione Una Opcion ------");
         int opcion = Convert.ToInt32(Console.ReadLine());  

         switch(opcion){

            case 1 : RealizarPedidoIngredientes();
                     break;
                     
            case 2 : 
                     verPedido(ingrediente,cantidad,tamaño);
                     break;
            case 3 : pagarPedido();
                     break;
            case 4 :  Console.Clear();
                     break;

            default :         Console.Clear();
                     opciones(); 
                     break;
         }
        }

         //Pedido-Ingredientes
        public static void RealizarPedidoIngredientes(){

            Console.Clear();
            Console.WriteLine("------ Toma Tu Pedido ------");
            Console.WriteLine("");
            Console.Write("[1] Peperoni"); Console.Write(" "); Console.WriteLine("[2] Hauawiana");
            Console.Write("[3] Argentina"); Console.Write(" "); Console.WriteLine("[4] Piña");
            Console.WriteLine("[5] Salir");
            Console.WriteLine("");
            Console.WriteLine("-- Selecciona ingrediente --");
            int opcion = Convert.ToInt32(Console.ReadLine());  

            switch(opcion){

               case 1:  ingrediente = "Peperoni";
                        
                        Console.Clear();
                        RealizarPedidoCantidad();

                     break;
               case 2:  ingrediente = "Hauawiana";
                        
                        Console.Clear();
                        RealizarPedidoCantidad();

                     break;
               case 3:  ingrediente = "Argentina";
                        
                        Console.Clear();
                        RealizarPedidoCantidad();

                     break;
               case 4:   ingrediente = "Piña";
                        
                        Console.Clear();
                        RealizarPedidoCantidad();

                     break;
               case 5:  
                        Console.Clear();
                        opciones();
                     break;
               default : RealizarPedidoIngredientes();
                     break;
            }
        }
         
         //Pedido-Cantidad
         public static void RealizarPedidoCantidad(){

           
            Console.Clear();
            Console.WriteLine("------ Toma Tu Pedido ------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-- Selecciona cantidad -----");
            cantidad = Convert.ToInt32(Console.ReadLine());  

            if(cantidad >= 6){

               Console.WriteLine("Cantidad no valida, Max 5");
               Console.WriteLine("Presiona Enter para continuar...");
               var key = Console.ReadKey();
               if (key.Key == ConsoleKey.Enter)
               {
               // Llama a la función que deseas
               RealizarPedidoCantidad();
               }

            }else{

               RealizarPedidoTamaño();

            }



         }

         //PEDIDO-TAMAÑO
         public static void RealizarPedidoTamaño(){

            Console.Clear();
            Console.WriteLine("------ Toma Tu Pedido ------");
            Console.WriteLine("");
            Console.WriteLine("[1] Chica");
            Console.WriteLine("[2] Mediana");
            Console.WriteLine("[3] Grande");
            Console.WriteLine("---- Selecciona Tamaño -----");

            Console.WriteLine("");
            int opcion = Convert.ToInt32(Console.ReadLine());  

            switch(opcion){

               case 1:  
                        
                        Console.Clear();
                        tamaño = 100;
                        verPedido(ingrediente,cantidad,tamaño);



                     break;
               case 2:  
                        
                        Console.Clear();
                        tamaño = 120;
                        verPedido(ingrediente,cantidad,tamaño);

                     break;
               case 3:  
                        
                        Console.Clear();
                        tamaño = 150;
                        verPedido(ingrediente,cantidad,tamaño);

                     break;
               default : RealizarPedidoTamaño();
                     break;
            }
         }

         //VER PEDIDO
         public static void verPedido(string ingrediente,int cantidad, int tamaño){
            
            Console.Clear();
            Console.WriteLine("------- Tu Pedido -------");
            Console.WriteLine("");
            Console.Write("Ingrediente: "); Console.WriteLine(ingrediente);

            Console.Write("Cantidad: "); 
            if(cantidad == 0){
               Console.WriteLine("Sin pedido");
            }else{
               Console.WriteLine(cantidad);
            }

            Console.Write("Tamaño: ");
            if(tamaño == 100)
            {
               Console.WriteLine("Chica");
            }else if(tamaño == 120)
            {
               Console.WriteLine("Mediana");
            }else if(tamaño == 150)
            {
               Console.WriteLine("Grande");
            }else
            {
               Console.WriteLine("Sin pedido");
            }
            Console.WriteLine("");
            Console.WriteLine("Presiona Enter para continuar...");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
               // Llama a la función que deseas
               opciones();
            }
         }

         //PAGAR PEDIDO
         public static void pagarPedido(){

            Console.Clear();
            Console.WriteLine("--------- Pagar Pedido --------");
            Console.WriteLine("");
            Console.Write("[1] Debito"); Console.Write(" ");Console.Write(" ");  Console.WriteLine("[2] Paypal");
            Console.Write("[3] Credito"); Console.Write(" "); Console.WriteLine("[4] Pejecoins");
            Console.WriteLine("[5] Salir");
            Console.WriteLine("");
            Console.WriteLine("-- Selecciona metodo de pago --");

            int opcion = Convert.ToInt32(Console.ReadLine());  

            switch(opcion){

               case 1:  
                        Console.Clear();
                        debito();

                     break;
               case 2:  
                        
                        Console.Clear();


                     break;
               case 3:  
                        
                        Console.Clear();


                     break;
               case 4:   
                        
                        Console.Clear();


                     break;
               case 5:  
                        Console.Clear();
                        opciones();
                     break;
               default : pagarPedido();
                     break;
            }
         }

         //METODO PAGO DEBITO
         public static void debito(){

            Console.Clear();
            Console.WriteLine("--------- Pagar Debito --------");
            Console.WriteLine("");
            Console.Write("[Numero de tarjeta:] "); 
            long numCard = Convert.ToInt64(Console.ReadLine());
   

            Console.Write("[Vencimiento:] "); 
            int vencimiento = Convert.ToInt32(Console.ReadLine());
            Console.Write("[CVV:] "); 
            int cvv = Convert.ToInt32(Console.ReadLine());
            Console.Write("[Nombre del titular:] "); 
            string? titular = Console.ReadLine();


            pagarDebito(ingrediente,cantidad,tamaño, numCard);

            
         }

         // PAGAR CON DEBITO
         public static void pagarDebito(string ingredientes,int cantidades , int tamaños, long numCard){

            if(ingredientes == "Sin Pedido"){
               
               Console.Clear();
               Console.WriteLine("Sin Pedido");
               Console.WriteLine("Presiona Enter para continuar...");
               var key = Console.ReadKey();
               if (key.Key == ConsoleKey.Enter)
               {
               // Llama a la función que deseas
               RealizarPedidoIngredientes();
               }
            }else{
               
               Console.Clear();
               Console.WriteLine("--------- Pagar Debito --------");
               Console.WriteLine("");
               Console.Write("[Pagas con:] ");Console.WriteLine(numCard);
               Console.WriteLine("");
               Console.WriteLine("--------------------------------------------");
               Console.Write("|");Console.Write(" ");Console.Write("Cantidad");Console.Write(" ");Console.Write("|");Console.Write(" ");Console.Write("Ingrendiente");Console.Write(" ");Console.Write("|");Console.Write(" ");Console.Write("Tamaño");Console.Write(" ");Console.Write("|");Console.Write(" ");Console.Write("Total");Console.Write(" ");Console.WriteLine("|");
               Console.WriteLine("--------------------------------------------");
               Console.Write("|");Console.Write(" ");Console.Write(cantidades);Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write("|");Console.Write(" ");
               Console.Write(ingredientes);Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write("|");Console.Write(" ");

               int total = tamaño * cantidad;


               if(tamaños == 100)
               {
                  Console.Write("Chica");Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write("|");Console.Write(" ");
                  Console.Write(total);
               }else if(tamaños == 120){
                  Console.Write("Mediana");Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write("|");Console.Write(" ");
                  Console.Write(total);
               }else if(tamaños == 150){
                  Console.Write("Grande");Console.Write(" ");Console.Write(" ");Console.Write(" ");Console.Write("|");Console.Write(" ");
                  Console.Write(total);
               }else{
                  Console.Write("Sin pedido");
               }



               Console.WriteLine("");
               Console.WriteLine("Presiona Enter para confirmar compra...");
               var key = Console.ReadKey();
               if (key.Key == ConsoleKey.Enter)
               {
               // Llama a la función que deseas
                  Console.Clear();
                  Console.WriteLine("Pago realizado");
                                 
                  ingrediente = "Sin Pedio";
                  cantidad = 0;
                  tamaño = 0;

                  Console.WriteLine("Presiona Enter para continuar...");
                  var key2 = Console.ReadKey();
                  if (key2.Key == ConsoleKey.Enter)
                  {
                  // Llama a la función que deseas
                     Console.Clear();

                     opciones();
                     
                  }
                  }
            }
         }
    }

}