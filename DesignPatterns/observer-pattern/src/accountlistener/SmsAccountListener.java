package accountlistener;

import account.Account;

public class SmsAccountListener implements IAccountListener {

	@Override
	public void balanceChanged(Account acc) {
		System.out.println("Sms Alert Balance changed " + acc.getBalance()
				+ " for your Account Number=" + acc.getId());
	}

}
