package accountlistener;

import account.Account;

public interface IAccountListener {
	public void balanceChanged(Account acc);
}
