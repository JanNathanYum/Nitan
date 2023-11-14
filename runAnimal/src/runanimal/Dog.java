/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package runanimal;

/**
 *
 * @author Yumol.301329
 */
public class Dog extends Animal {

    @Override
    public void eat() {
        System.out.println("Eats dog food"); 
    }

    @Override
    public void sleep() {
        System.out.println("sleep for 12 to 14 hours");
    }

    @Override
    public void makeSound() {
        System.out.println("Arf arf");
    }
    
}
