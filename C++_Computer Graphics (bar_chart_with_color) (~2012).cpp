#include <graphics.h>
#include <conio.h>
#include <iostream.h>
#include <math.h>
int s[20];
int co[20];

void bar_chart(int i){
float w,t;
int f,m;
	line(100,400,500,400);
	w=(400/i);

	m=s[1];
	for(int j=2;j<=i;j++)
	{
	if (m<s[j]){
	m=s[j];
	}}

	t=(400/m);

	i=1;
	for (int k=100;k<=500;k=k+w){
	line(k,400,k,400-(s[i]*t));
	line(k+w,400,k+w,400-(s[i]*t));
	line(k,400-(s[i]*t),k+w,400-(s[i]*t));

		for(int y=399;y>(400-(s[i]*t));y--){
		for(int x=k+1;x<k+w;x++){
		putpixel(x,y,co[i]);
		}}
	
	i=i+1;
	}
}




void main(){
int gd=DETECT,gm;
initgraph(&gd,&gm,"..\\bgi");
int i,d;


	for (i=1;i<=20;i++)
	{
	cout<<"\n  Enter Data \n";
	cin>>d;

	if (d == -1)
	break;
	else
	s[i]=d;

	cout<<"\n  Enter color (1-15) \n";
	cin>>co[i];
	}
	
	bar_chart(i);


getch();
closegraph();
}