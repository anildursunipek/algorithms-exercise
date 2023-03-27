import java.util.HashMap;
import java.util.Map;

public class Main {
    public static void main(String[] args) {
        int[] n = new int[] { 5,5,4,4,2};
        System.out.println(mode(n));
    }
    public static int mode(final int[] arr) {
        Map<Integer, Integer> map = new HashMap<Integer, Integer>();
        for(int i=0; i<arr.length; i++){
            if(map.containsKey(arr[i])){
                map.put(arr[i], map.get(arr[i]) + 1);
                continue;
            }
            map.put(arr[i], 1);
        }
        
        int maxFrequencyValue = -1;
        int maxFrequencyKey = -1;

        for(Map.Entry<Integer, Integer> entry : map.entrySet()) {
            int key = entry.getKey();
            int value = entry.getValue();

            if(maxFrequencyValue < value){
                maxFrequencyValue = value;
                maxFrequencyKey = key;
            }
        }
        for(int i=0;i< arr.length;i++){
            if(map.get(arr[i]) == maxFrequencyValue){
                maxFrequencyKey = arr[i];
                break;
            }
        }
        System.out.println(map.get(5));

        System.out.println("Max Key -> " + maxFrequencyKey + " Max Value -> " + maxFrequencyValue);
        return maxFrequencyKey;
    }
}