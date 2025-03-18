using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Formats;
using System.Windows;
using System.Security.Cryptography.X509Certificates;
namespace app1{
   public class KD_Detect
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public void bbs()
        {
            Console.WriteLine("Press any key to start detecting. Press 'Esc' to exit.");

            System.Threading.Thread.Sleep(100);

            for (int i = 0; i <= 254; i++) 
            {
                short state = GetAsyncKeyState(i);
                if ((state & 0x8000) != 0)  // If the most significant bit is set, the key is down
                {
                    Console.WriteLine("Key pressed" + i);  // Print the key code
                }
            }
        }
    }

}

    
namespace app1 {
    public class MainProject {
        
        static Window Hell = new Window();
       // static KD_Detect kd = new KD_Detect();


        public void GameLoop(){
            
        }
        public static void Main(string[] args){
            
          //  kd.bbs();
            Hell.PrimaryDraw("1984");

        }

    }
}
