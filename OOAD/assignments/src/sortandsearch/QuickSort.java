package sortandsearch;

public class QuickSort implements ISortable{
	private int array[];
	private int length;

	
	public void sort(int[] inputArr) {
		if (inputArr == null || inputArr.length == 0) {
			return ;
		}
		
		this.array = inputArr;
		length = inputArr.length;
		quickSort(0, length - 1);
		
	}

	private void quickSort(int i, int j) {

		int lowerIndex = i;
		int higherIndex = j;
		
		int pivot = array[i + (j - i) / 2];  //middle element as pivot
		
		while (lowerIndex <= higherIndex) {
			/**
			 * In each iteration, we will identify a number from left side which
			 * is greater then the pivot value, and also we will identify a
			 * number from right side which is less then the pivot value. Once
			 * the search is done, then we exchange both numbers.
			 */
			while (array[lowerIndex] < pivot) {
				lowerIndex++;
			}
			while (array[higherIndex] > pivot) {
				higherIndex--;
			}
			if (lowerIndex <= higherIndex) {
				exchangeNumbers(lowerIndex, higherIndex);
				lowerIndex++;
				higherIndex--;
			}
		}
		
		if (i < higherIndex)
			quickSort(i, higherIndex);
		if (lowerIndex < j)
			quickSort(lowerIndex, j);
	}

	private void exchangeNumbers(int i, int j) {
		int temp = array[i];
		array[i] = array[j];
		array[j] = temp;
	}

	
}
