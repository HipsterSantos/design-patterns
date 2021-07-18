package singleton.pattern.demo; 
class MakeACaptain{ 
    private static MakeACaptain _captain; 
    //we make the constructor  private to prevent the use of new 
    private MakeACaptain(){
        //now no one can instanciate this class unless the members of this class, like _captain. 
    }
    private static MakeACaptain getCaptain(){
        //lazy initialization 
        if(_captain == null ){
            _captain = new MakeACaptain();
            System.out.println("New Captain selected for outr team");
        }else{
            System.out.println("You alread have a Captain for you team.");
            System.out.println("Send him for the toss");
        }
        return _captain;
    }
}