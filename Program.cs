internal class Program {
    private static void Main(string[] args) {
        static int[] BubbleSort(int[] arr) 
        {
            for (int i = 0; i < arr.Length - 1; i++) {
                for (int j = 0; j < arr.Length - i-1; j++) {
                    if (arr[j] > arr[j + 1]) {
                        int aux = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = aux;
                    }
                }

               
            }
            foreach (int i in arr) {
                Console.Write(i);
            }
            return arr;
        }
        int[] arr = { 9, 5, 6, 2, 8, 7 };
        BubbleSort(arr);

     
    }
}