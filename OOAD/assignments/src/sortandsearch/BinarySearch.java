package sortandsearch;

public class BinarySearch {
	
	ISortable sortingAlgorithm;
	public BinarySearch(ISortable sortingAlgorithm){
		this.sortingAlgorithm=sortingAlgorithm;
	}
	
	public int binarySearch(int arr[], int lowerIndex, int higherIndex,
			int elementToBeSearched) {
		
		this.sortingAlgorithm.sort(arr);
		
		if (higherIndex >= lowerIndex) {
			int middleIndex = lowerIndex + (higherIndex - lowerIndex) / 2;

			if (arr[middleIndex] == elementToBeSearched)
				return middleIndex;

			if (arr[middleIndex] > elementToBeSearched)
				return binarySearch(arr, lowerIndex, middleIndex - 1,
						elementToBeSearched);

			return binarySearch(arr, middleIndex + 1, higherIndex,
					elementToBeSearched);
		}
		
		return -1;
	}
	
	public void display(int arr[]){
		System.out.println("AfterSorting Array is");
		for(int i=0;i<arr.length;i++){
			System.out.print(arr[i]+" ");
		}
	}

}
