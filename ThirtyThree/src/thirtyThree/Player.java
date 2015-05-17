package thirtyThree;

import java.util.Scanner;

public class Player {
	int health;
	int attack;
	Scanner sc = new Scanner(System.in);
	public Player(int health, int attack) {
		this.health = health;
		this.attack = attack;
	}
	public void myTurn(Enemy enemy) {
		System.out.println("\nChoose a spell:\n1.Fireball - " + attack*2 + "damage\n2.Ice lance - "
				+ attack + " damage\n3.Healing wave - " + attack + " to your health");
		int input = sc.nextInt();
		switch(input) {
			case 1:
				enemy.health -= (attack)*2;
				System.out.println("You hit for " + attack*2 + ". Enemy health - " + enemy.health);
				break;
			case 2:
				enemy.health -= attack;
				System.out.println("You hit for " + attack + ". Enemy health - " + enemy.health);
				break;
			case 3:
				health += attack;
				System.out.println("You heal for " + attack + ". Your health - " + health);
				break;
			default: 
				System.out.println("Invalid input! Enter 1, 2 or 3!");
				myTurn(enemy);
		}
	}
}
		