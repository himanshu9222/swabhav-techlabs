package com.techlabs.player;

public class Player {
		private int id;
		private String name;
		private int age;
		
		@Override
		public String toString(){
			return "id="+getId()+"\nname="+getName()+"\nage"+getAge();
		}
		
		public boolean equals(Object obj){
			if(this.getId()==((Player) obj).getId()){
				return true;
			}else
				return false;
			//return this.getId()==((Player) obj).getId()?true:false;
		}
		public Player(int id,String name){
			this(id,name,18);
		}
		
		public Player(int id,String name,int age){
			this.id=id;
			this.name=name;
			this.age=age;
		}
		
		public int getId(){
			return id;
		}
		
		public String getName(){
			return name;
		}
		
		public int getAge(){
			return age;
		}
		
		public void setAge(int age){
			this.age=age;
		}
		
		public Player whoIsElder(Player playerType){
			//if(this.getAge() > playerType.getAge() ){
				//return this;
			//}
			//else
			//return playerType;
			return this.getAge() > playerType.getAge()?this:playerType;
			
		}
}
