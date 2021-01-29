import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
       
        int i = 1;
        Scanner scanner = new Scanner(System.in);
        while(scanner.hasNext()) {
            String line = i + " " + scanner.nextLine();
            if (scanner.hasNext()) System.out.println(line);
            else System.out.print(line);
            ++i;
        }
        scanner.close();
    }
}