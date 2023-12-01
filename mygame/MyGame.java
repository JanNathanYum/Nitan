/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package mygame;
import java.util.Scanner;
/**
 *
 * @author Jan Nathan
 */


// Game class implementing the interfaces
class LongilongGame implements GameMode, GameStory {
    private Scanner scanner;
    private String playerName;

    LongilongGame() {
        scanner = new Scanner(System.in);
    }

    @Override
    public void start() {
        System.out.print("Enter your name: ");
        playerName = scanner.nextLine();
        displayMenu();
        startGame();
    }

    @Override
    public void displayStory() {
        System.out.println("Welcome " + playerName + " to the Longilong Adventure Story Mode!");
        System.out.println("You wake up in a distant land, surrounded by mysteries and wonders...");
        System.out.println("As you journey through the land, you encounter various challenges and choices.");
        System.out.println("Choice 1: Enter the enchanted forest.");
        System.out.println("Choice 2: Climb the mountains.");

        int choice = scanner.nextInt();
        if (choice == 1) {
            System.out.println("You enter the forest and encounter mystical creatures...");
        } else if (choice == 2) {
            System.out.println("You begin your climb and face harsh weather conditions...");
        } else {
            System.out.println("Invalid choice. The story ends abruptly.");
        }

        System.out.println("The story ends. You completed your adventure!");
    }

    public void startGame() {
        System.out.println("Press 1 or 2 to select your game mode.");
        System.out.println("1 - Story Mode");
        System.out.println("2 - Survival Mode");

        int modeChoice = scanner.nextInt();

        switch (modeChoice) {
            case 1:
                displayStory();
                break;
            case 2:
                System.out.println("Press P to start playing, " + playerName + ".");
                char startChoice = scanner.next().charAt(0);
                if (Character.toUpperCase(startChoice) == 'P') {
                    startSurvival();
                } else {
                    System.out.println("Invalid choice. Exiting...");
                }
                break;
            default:
                System.out.println("Invalid choice. Exiting...");
        }
    }

    public void startSurvival() {
        System.out.println("Welcome " + playerName + " to the Longilong Adventure Survival Mode!");
        int health = 100;
        int food = 50;
        int daysSurvived = 0;

        while (health > 0 && food > 0) {
            System.out.println("Day " + (daysSurvived + 1) + ": Health - " + health + ", Food - " + food);
            System.out.println("Choose an action: 1. Hunt for food, 2. Rest, 3. Quit");

            int choice = scanner.nextInt();

            switch (choice) {
                case 1:
                    // Hunting for food
                    food += 20;
                    health -= 10;
                    break;
                case 2:
                    // Resting
                    health += 10;
                    food -= 15;
                    break;
                case 3:
                    System.out.println("Exiting Survival Mode.");
                    return;
                default:
                    System.out.println("Invalid choice. Please choose again.");
            }

            // Increment day survived
            daysSurvived++;
        }

        if (health <= 0) {
            System.out.println("You died. Game Over!");
        } else {
            System.out.println("You ran out of food. Game Over!");
        }
    }

    public void displayMenu() {
        System.out.println("Welcome to the Longilong Adventure Game!");
    }
}

public class MyGame {
    public static void main(String[] args) {
        LongilongGame game = new LongilongGame();
        game.start();
    }
}