#include <graphics.h>
#include <conio.h>
#include <iostream.h>
#include <math.h>
#define p 3.1415
int s[20];
int co[20];
float g1,g2;


void circle(float x0,float y0,float r){
float step=(1./r),x,y;


	for (float i=0;i<=(2*p);i=i+step){
	x=r*cos(i);
	y=r*sin(i);
	putpixel(x+x0,y+y0,WHITE);
	}
}

void diagram(float x0,float y0,float r,float i){
float w,t,g;


	for(int j=1;j<=i;j++)
	{
	w=w+s[j];
	}

	t=(2*p)/w;

	for(int h=1;h<=i;h++)
	{
	g=g+(s[h]*t);
	line(x0,y0,((r*cos(g))+x0),((r*sin(g))+y0));
	}
}


void col(float x0,float y0,float r,float i)
{
int j;
float k,t,w,x,y,step=(1./r);


	for(int h=1;h<=i;h++)
	{
	w=w+s[h];
	}
	t=(2*p)/w;

	s[0]=0;


	for (int q=1;q<=i;q++)
	{
	g1=g1+(t*s[q-1]);
	g2=g2+(t*s[q]);

		for (j=r-1;j>0;j--){
		for (k=g1;k<=g2;k=k+step){
		x=j*cos(k);
		y=j*sin(k);
		putpixel(x+x0,y+y0,co[q]);
		}}
	}

}


void main(){
int gd=DETECT,gm;
initgraph(&gd,&gm,"..\\bgi");

float x0,y0,r,c;
float d,i;


	cout<<"\n  Enter the center point \n";
	cin>>x0>>y0;
	cout<<"\n  Enter Radius \n";
	cin>>r;


	for (i=1;i<=20;i++)
	{
	cout<<"\n  Enter Data \n";
	cin>>d;

	if (d == -1)
	break;
	else
	s[i]=d;

	cout<<"\n  Enter Color \n";
	cin>>co[i];
	}
	

	circle(x0,y0,r);
	diagram(x0,y0,r,i);
	col(x0,y0,r,i);

getch();
closegraph();
}