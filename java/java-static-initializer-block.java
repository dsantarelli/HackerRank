public static int B;
public static int H;
public static boolean flag;

static {
    Scanner scanner = new Scanner(System.in);
    B = scanner.nextInt();
    H = scanner.nextInt();
    scanner.close();
    flag = B > 0 && H > 0;
    if (!flag) System.out.print("java.lang.Exception: Breadth and height must be positive");
}