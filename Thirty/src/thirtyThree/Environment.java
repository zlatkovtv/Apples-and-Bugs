package thirtyThree;
public class Environment {
	static int myLevel;
	
	public static void main(String[] args) {
		System.out.println("Now spawning you...");
		Player p = new Player(150, 50);
		System.out.println("You spawned...");
		for(int i=1; i<34;i++) {
			myLevel = i;
			p.attack = 50 + 8*i;
			p.health = 150 + i*50;
			System.out.println("Your level is " + i + ",health is " + p.health + " and attack is "
					+ p.attack);
			//spawn empty boss
			Enemy e = new Enemy(0,0);
			if((myLevel+1)%11==0) {
				//spawn and replace boss
				e.health = (150+75*i);
				e.attack = (60+10*i);
				System.out.println("Boss spawned with " + e.health + " health and " + e.attack +
						" attack!");
			} else {
				//spawn normal enemy
				e.health = (150+50*i);
				e.attack = (50+8*i);
				System.out.println("Enemy spawned with " + e.health + " health and " + e.attack +
						" attack!");
			}
			int turn = 1;
			do {
				//======check to see if anybody's dead
				if(p.health<=0) {
					System.out.println("You are dead!");
					System.exit(1);
				} else if (e.health<=0) {
					System.out.println("\nYou won the battle! The opponent is dead!\n");
					break;
				}
				//========end of check=====
				//========check turn=======
				if(turn%2 != 0) {
					System.out.println("It's your turn!");
					p.myTurn(e);
				} else if (turn%2 == 0){
					System.out.println("It's the enemy's turn!");
					e.enemyTurn(p);
				}
				//====end of check turn======
				turn++;
			} while ((p.health>0) || (e.health>0));
		}
	}
}
