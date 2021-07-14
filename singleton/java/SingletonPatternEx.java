class SingletonPatternEx{ 
    public static void main(String[] args){
        System.out.println("*** Singleton Pattern Demon ***\n");
        System.out.println("Trying to make a captain for out team"); 
        MakeACaptain c1 = MakeACaptain.getCaptain();
        System.out("Trying to make another captin for our team");
    }
}