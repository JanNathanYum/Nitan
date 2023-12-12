/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package runquad;
import java.util.*;
/**
 *
 * @author yumol.301329
 */
public class RunQuad {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Scanner scan = new Scanner (System.in);
       Rectangle rectangle = new Rectangle();
       Square square = new Square();
       
       while(true) {
           System.out.println("Press 'R' for Rectangle or 'S' for Square");
           String line =scan.nextLine();
           
           if(line.equalsIgnoreCase("S")){
               System.out.println("A Square: ");
               square.showDescription();
           } else if (line.equalsIgnoreCase("R")){
               System.out.println("A Rectangle: ");
               rectangle.showDescription();
           } else {
            System.out.println("Thanks.");
            System.exit(0);
           
           }
       }
    
    }
    
}
