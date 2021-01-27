#include<iostream>
#include<conio.h>
#include<math.h>
using namespace std;
int main()
{
int x[1000]={0};
int y[1000]={0};
int x1[1000]={0};
int y1[1000]={0}; 
float distance1=0;
float a[1000]={0};
float b[1000]={0};
float distance2=0;
int n=0;
cin>>n;


for(int i=0;i<n;i++)
{
CHECK:
cin>>x[i]>>y[i]>>x1[i]>>y1[i];
if(x[i]>=-20&&x[i]<=20&&y[i]>=-20&&y[i]<=20)
{
x[i]=x[i];
y[i]=y[i];
}
else
{
cout<<"INVALID INPUT:";
x[i]=0;y[i]=0;
goto CHECK;
}
distance1=(0-x[i])*(0-x[i])+(0-y[i])*(0-y[i]);
a[i]=sqrt(distance1);

if(x1[i]>=-20&&x1[i]<=20&&y1[i]>=-20&&y1[i]<=20)
{
x1[i]=x1[i];
y1[i]=y1[i];
}
else
{
cout<<"INVALID INPUT:\n";
x1[i]=1;y1[i]=0;
goto CHECK;
}
distance2=(0-x1[i])*(0-x1[i])+(0-y1[i])*(0-y1[i]);
b[i]=sqrt(distance2);

}

for(int j=0;j<n;j++)
{
	cout<<"\n";
if(a[j]>b[j])
{
cout<<"B IS CLOSER";
}
if(a[j]<b[j])
{
cout<<"A IS CLOSER";
}
}

getch();	
}
