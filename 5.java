package compete;

import java.util.Scanner;

public class Problem2 {
    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        int length=0;
        int numberOfDataSet=input.nextInt();
        String ss=input.nextLine();
        String s[]=new String[numberOfDataSet];
        for(int i=0;i<numberOfDataSet;i++){
            s[i]=input.nextLine();
        }
        for(int i=0;i<numberOfDataSet;i++){
            
            String data[]=s[i].split(" ");
            double totalMoney=Double.parseDouble(data[0]);
            double items=0;
            for(int j=1;j<data.length;j++){
                if(data[j].equalsIgnoreCase("-1")){
                    break;
                }
                else{
                    items=items+Float.parseFloat(data[j]);
                }
            }
            if(items>totalMoney){
                 System.out.print("$");
                 String sss=((items-totalMoney)+((8)*items)/100)+"" ;
                 int iii=Integer.parseInt(""+sss.charAt(3)+sss.charAt(4));
                 System.out.print(""+sss.charAt(0)+sss.charAt(1)+sss.charAt(2));
                 int abc=0,ab=sss.charAt(4)-48;
                 if(ab>=5){
                     abc=sss.charAt(3)-48+1;
                     System.out.print(abc);}
                     else{
                     System.out.print(sss.charAt(3));
                             }System.out.println(" SHORT");
            }
            else{
               System.out.println("ENOUGH MONEY");
            }
            
        }
        
    }
    
}
