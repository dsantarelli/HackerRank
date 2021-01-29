import java.util.*;
import java.io.*;

class Solution{
    public static void main(String []argh){
        Scanner in = new Scanner(System.in);
        int t=in.nextInt();
        for(int i=0;i<t;i++) {
            int a = in.nextInt();
            int b = in.nextInt();
            int n = in.nextInt();

            List<String> lines = new ArrayList<String>();            
            for (int j = 0; j < n; j++) {
                int result = a;
                for (int k = 0; k <= j; k++) {
                    result += Math.pow(2, k) * b;                    
                }                
                lines.add(String.valueOf(result));
            }

            System.out.println(String.join(" ", lines));
        } 
        in.close();
    }
}

