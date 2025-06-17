package task1;

import java.util.ArrayList;

public class ContractManger {
	
	private ArrayList<Contract> contractList;
	
	public ContractManger(){
		contractList = new ArrayList<>();
	}
	
	public void addContract(String name, String phone, String email) {
		Contract contract = new Contract(name, phone, email);
		contractList.add(contract);
	}
	
	public void listAllContracts() {
		if(contractList.isEmpty())
			System.out.println("No contract found");
		else {
			for(Contract contract : contractList) {
				contract.printContract();
			}
		}	
			
	}

}
