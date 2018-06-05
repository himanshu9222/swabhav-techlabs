package accountlistener;

import account.Account;

public class EmailAccountListener implements IAccountListener {

	@Override
	public void balanceChanged(Account acc) {
		System.out.println("Email Alert Balance changed " + acc.getBalance()
				+ " for your Account Number=" + acc.getId());
	}

}
