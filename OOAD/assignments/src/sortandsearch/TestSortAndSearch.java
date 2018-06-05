package sortandsearch;

import java.util.Scanner;

public class TestSortAndSearch {
	private static Scanner sc;

	public static void main(String args[]) {
		int[] input;
		sc = new Scanner(System.in);
		System.out.println("Enter the number of elemnets");
		int numberOfElements=sc.nextInt();
		input=new int[numberOfElements];
		System.out.println("Enter the Elements of array");
		for(int i=0;i<numberOfElements;i++){
			input[i]=sc.nextInt();
		}
		
		BinarySearch binarySearch = new BinarySearch(new QuickSort());
		int n = input.length;
		System.out.println("\nEnter the element to be searchrd");
		int elementToBeSearched = sc.nextInt();
		int result = binarySearch.binarySearch(input, 0, n - 1, elementToBeSearched);
		display(input);
		if (result == -1)
			System.out.println("\nElement not present");
		else{
			result+=1;
			System.out.println("\nElement found at index " + result);
		}
	}
	
	public static void display(int arr[]){
		System.out.println("AfterSorting Array is");
		for(int i=0;i<arr.length;i++){
			System.out.print(arr[i]+" ");
		}
	}

}
