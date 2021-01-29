Class klass1 = Class.forName("Solution$Inner");
Class klass2 = Class.forName("Solution$Inner$Private");
Constructor ctor = klass2.getDeclaredConstructor(klass1);
ctor.setAccessible(true);
var o = ctor.newInstance(klass1.newInstance());
Method meth = klass2.getDeclaredMethod("powerof2",int.class);
meth.setAccessible(true);
System.out.println(String.valueOf(num)+" is "+(String)meth.invoke(o,num));

