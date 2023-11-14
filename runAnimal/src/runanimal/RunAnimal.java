package runanimal;
import java.util.*;
/**
 *
 * @author Yumol.301329
 */
public class RunAnimal {

   
    public static void main(String[] args) {
       
     Scanner scn = new Scanner(System.in);
     Bird bird = new Bird();
     Cat cat = new Cat();
     Dog dog = new Dog();
     while(true)  { 
     System.out.println("Choose an animal. Press B for Bird, C for Cat, D for Dog: ");
     String animals = scn.next();
        
        if(animals.equalsIgnoreCase("B")){
        bird.eat();
        bird.sleep();
        bird.makeSound();
        } else if (animals.equalsIgnoreCase("D")) {
        dog.eat();
        dog.sleep();
        dog.makeSound();
        } else if (animals.equalsIgnoreCase("C")) {
        cat.eat();
        cat.sleep();
        cat.makeSound();
        } else 
            System.out.println("Wrong Input!");
        
        
    }
    }
}
