package dip.voilation;


public class TaxCalculator {
	LogType logType;
	
	public TaxCalculator(LogType logType){
		this.logType=logType;
	}
	
	public int calculate(int salary,int r){
		int c = 0;
		try{
			c=salary/r;

		}
		catch(Exception e){
			if(logType==LogType.XML){
				XmlLogger xmlLogger=new XmlLogger();
				xmlLogger.log(e.getMessage());
				throw e;
			}
			else if(logType==LogType.CSV){
				CsvLogger csvLogger=new CsvLogger();
				csvLogger.log(e.getMessage());
				throw e;
			}
		}
		return c;
		
	}
}
