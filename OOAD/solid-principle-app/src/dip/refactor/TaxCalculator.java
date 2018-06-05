package dip.refactor;
import dip.refactor.ILog;


public class TaxCalculator {

		ILog log;
		public TaxCalculator(ILog log){
			this.log=log;
		}

		
		public int calculate(int salary,int r){
			int c = 0;
			try{
				c=salary/r;

			}
			catch(Exception e){
				log.log(e.getMessage());
				throw e;
			}
			return c;	
		}
}
