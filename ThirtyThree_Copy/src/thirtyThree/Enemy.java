package thirtyThree;

public class Enemy {
	int health;
	int attack;
	public Enemy(int health, int attack) {
		this.health = health;
		this.attack = attack;
	}
	
	public void enemyTurn(Player player) {
		int eAtt = (int)(Math.random()*(3) + 1);
		System.out.println("\nEnemy has chosen ability N. " + eAtt);
		switch(eAtt) {
		case 1:
			player.health -= (attack)*2;
			System.out.println("Enemy hits for " + attack*2 + ". Your health - " + player.health);
			break;
		case 2:
			player.health -= attack;
			System.out.println("Enemy hits for " + attack + ". Your health - " + player.health);
			break;
		case 3:
			health += attack;
			System.out.println("Enemy heals for " + attack + ". Enemy's health - " + health);
			break;
		default: enemyTurn(player);
		}
	}
}
