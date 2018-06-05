package test;

import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.Properties;
import autofactory.AudiFactory;
import autofactory.IAutoFactory;
import automobile.IAutomobile;

public class TestApp {
	public static void main(String args[]) {
		 IAutoFactory factory = AudiFactory.getInstance();
		//IAutoFactory factory = createFactoryFromPropertyFile();
		IAutomobile auto = factory.makeSUV();
		auto.start();
		auto.stop();
	}

	public static IAutoFactory createFactoryFromPropertyFile() throws ClassNotFoundException, NoSuchMethodException, SecurityException, IllegalAccessException, IllegalArgumentException, InvocationTargetException {
		
		Properties prop = new Properties();
		InputStream input = null;

		try {
			input = new FileInputStream("src//test//" + "factory.properties");
			// load a properties file
			prop.load(input);

			// get the property value and print it out
			// System.out.println(prop.getProperty("factory"));
		} catch (IOException ex) {
			ex.printStackTrace();
		} finally {
			if (input != null) {
				try {
					input.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
		Class<?> cls= Class.forName(prop.getProperty("factory"));
		Method method=cls.getMethod("getInstance");
		IAutoFactory autoMobile=(IAutoFactory) method.invoke(null);
		return autoMobile;
	}
}

/*switch (prop.getProperty("factory")) {
case "autofactory.AudiFactory":
	return AudiFactory.getInstance();

case "autofactory.BmwFactory":
	return BmwFactory.getInstance();

case "autofactory.TeslaFactory":
	return TeslaFactory.getInstance();
}
return null;*/
