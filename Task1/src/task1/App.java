package task1;

import java.util.Scanner;

public class App {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		ContractManger contractManger= new ContractManger();
		int choice;
		
		do {
	    System.out.println("1. Add Contact");
            System.out.println("2. List Contacts");
            System.out.println("3. Exit");
            System.out.print("Enter your choice: ");
            choice = scanner.nextInt();
            scanner.nextLine();
            
            switch(choice) {
            case 1: 
            	System.out.print("Enter name: ");
                String name = scanner.nextLine();
                
            	System.out.print("Enter phone: ");
                String phone = scanner.nextLine();
                
                System.out.print("Enter email: ");
                String email = scanner.nextLine();
                
                contractManger.addContract(name, phone, email);
                break;
                
            case 2:
            	contractManger.listAllContracts();
            	break;
            	
            case 3:
            	break;
            	
            	default:
            	System.out.print("Invalid nubmer try again");
            }
            
		}while(choice != 3);
		
		scanner.close();
	}

}
