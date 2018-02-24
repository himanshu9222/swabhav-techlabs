package test;

import static org.junit.Assert.*;

import org.junit.Test;

import component.Calculate;

public class CalculateTest {
	//Arrange
	Calculate calc = new Calculate();

	//Act and Assert
	@Test
	public void testAddPass() {
		// assertEquals(String message, long expected, long actual)
		assertEquals("error in add()", 3, calc.add(1, 2));
		assertEquals("error in add()", -1, calc.add(1, -2));
		assertEquals("error in add()", 9, calc.add(9, 0));
	}

	@Test
	public void testAddFail() {
		// assertNotEquals(String message, long expected, long actual)
		assertNotEquals("error in add()", 0, calc.add(1, 2));
	}

}





/*@BeforeClass		
public static void m1() {							
    System.out.println("Using @BeforeClass , executed before all test cases ");					
}		

@Before		
public void m2() {					
    list = new ArrayList<String>();					
    System.out.println("Using @Before annotations ,executed before each test cases ");					
}		

@AfterClass		
public static void m3() {							
    System.out.println("Using @AfterClass ,executed after all test cases");					
}		

@After		
public void m4() {					
    list.clear();			
    System.out.println("Using @After ,executed after each test cases");					
}	*/




