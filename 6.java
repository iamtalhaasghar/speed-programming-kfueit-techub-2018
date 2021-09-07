package compete;

import java.util.Scanner;

public class problem6 {
    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        int n=input.nextInt();
        String data[]=new String[n];
        data[0]=input.nextLine();
        for(int i=0;i<n;i++)
        {
            data[i]=input.nextLine();
        }
        int sp=0;
        for(int i=0;i<n;i++){
            for(int j=0;j<data[i].length();j++){
                if(data[i].charAt(j)==' '){
                    sp++;
                }
                else{
                    continue;
                }
            }
           if(sp>0){
               String s[]=data[i].split(" ");
               System.out.println("FIRST "+s[0].toUpperCase());
               System.out.print("BUT FIRST ");
               for(int k=1;k<(s.length);k++)
               {
                   System.out.print(s[k].toUpperCase()+" ");
               }
               System.out.println();
               System.out.println("LAST "+s[s.length-1]);
                System.out.print("BUT LAST ");
                for(int k=0;k<(s.length-1);k++)
               {
                   System.out.print(s[k].toUpperCase()+" ");
               }
               System.out.println();
           }
           else{
                System.out.println("FIRST "+data[i].toUpperCase().charAt(0));
                String abc="";
                for(int a=1;a<data[i].length();a++)
                {
                    abc+=data[i].charAt(a);
                }
                System.out.println("BUT FIRST "+abc.toUpperCase());
                System.out.println("LAST "+data[i].toUpperCase().charAt(data[i].length()-1));
                abc="";
                for(int a=0;a<data[i].length()-1;a++)
                {
                    abc+=data[i].charAt(a);
                }
                System.out.println("BUT LAST "+abc.toUpperCase());
           }
            System.out.println(" ");
           sp=0;
        }
    }
}
