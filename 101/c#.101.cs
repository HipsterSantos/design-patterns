// //introduction to csharp  language advanced concepts 
// Follwing taks to make breakfast : 
// 1. Pour a cup of coffee.
// 2. Heat up a pan, then fry two eggs.
// 3. Fry threeslices of bacon.
// 4. Toast two pieces of bread.
// 5. Add butter and jam to thetoast.
// 6. Pour a glass of orangejuice.

//consider the sample bellow. 

using System; 
using System.Threading.Tasks;

namespace AsyncBreakfast{
    class Program{
        static void Main(string[] args){
            Coffe cup = POurCoffe(); 
            console.WriteLine("coffe is ready"); 
            Eggs eggs = FryEggs(2);
            console.WriteLine("eggs are ready"); 

            Bacon bacon = FryBcon(3);
            Console.WriteLine("Bacon is rady "); 
            Toast toast  = ToastBread(2); 
            ApplyButter(toast); 
            ApplyJam(toast); 
            Console.WriteLine("toast is ready"); 

            Juice oj = PourOj(); 
            Console.WriteLine('oj is ready'); 
            Console.WritLine("Breakfast is ready");

            private stattic Juic PourOj(){
                Console.WriteLine("Pouring orange jice"); 
                return new Juice();
            }

            private static void ApplyJam(Toast toast) => 
            Console.WriteLine("Puttin gjam on the toast"); 

            private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast"); 

            private static Toast ToastBread(int slices){
                for (int slice = ; slice<slices; slice++){
                    Console.WriteLine("Putting a slice of bread in the toaster");
                }
                Console.WriteLine("Start toasting ..."); 
                Task.Delay(3000).Wait();
                Console.WriteLine("Remove toast from toaster"); 
                return new  Toast();
            }

            private static Bacon Frybacon(int slice){
                Console.WriteLine($"putting {slices} of bacon in the pan"); 
                Console.WriteLine("cooking first side of bacon..."); 
                Task.Delay(3000).Wait();
                for(int slice = 0 ; slice < slices; slice++){
                    Console.WriteLine("flipping a slice of bacon"); 
                }
                Console.WriteLine("cookign the secnd side of bacon...");
                Task.Delay(3000).wait();
                Console.WriteLine("Put bacon on plate"); 
                return new Bacon():
            }
            
        }
    }
}