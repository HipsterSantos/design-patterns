using System.Console; 
using System.Threading;
using System.Collections.Generics;

namespace sigletonPattern{
    public class MakeACaptain{
            private MakeACaptain _captain; 
            private MakeACapatain(){

            }

            public MakeACaptain generateCapatian(){
                if (_capatain == null ){
                    _captain = new  MakeCaptain();
                    //now we have a  new captian ; 
                }
                else{
                    Console.WriteLine('we already have a captain');
                }
                return _captain;
            }
    }
    public static void main(String[] args){
            MakeCaptain captain  = MakeCaptain.generateCaptain();
            MakeCaptain capain =  MakeCaptain.generateCaptain();
            //the second line should informe you that one captain was already set. 
    }
}