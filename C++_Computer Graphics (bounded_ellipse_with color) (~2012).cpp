#include <graphics.h>
#include <conio.h>
#include <iostream.h>
#include <math.h>
#define p 3.1415

void rectangle(int x0,int y0,int a,int b,int oc1,int oc2,int oc3,int oc4){

	line(x0-a,y0-b,x0+a,y0-b);
	line(x0-a,y0-b,x0-a,y0+b);
	line(x0+a,y0-b,x0+a,y0+b);
	line(x0+a,y0+b,x0-a,y0+b);

	for (int i1=(y0-b+1);i1<=y0;i1++){
	for (int j1=(x0-a+1);j1<=x0;j1++){
	putpixel(j1,i1,oc1);
	}}
	
	for (int i2=(y0-b+1);i2<=y0;i2++){
	for (int j2=x0;j2<=(x0+a-1);j2++){
	putpixel(j2,i2,oc2);
	}}

	for (int i3=y0;i3<=(y0+b-1);i3++){
	for (int j3=(x0-a+1);j3<=x0;j3++){
	putpixel(j3,i3,oc3);
	}}

	for (int i4=y0;i4<=(y0+b-1);i4++){
	for (int j4=x0;j4<=(x0+a-1);j4++){
	putpixel(j4,i4,oc4);
	}}

}


void ellipse(int x0,int y0,int a,int b,int ic){
float step=(1./(a+b)),x,y;


	for (float i=0;i<=(2*p);i=i+step){
	x=a*cos(i);
	y=b*sin(i);
	putpixel(x+x0,y+y0,WHITE);
	}


	if (a>=b){
		
		b=b-1;

		for (int j=a-1;j>0;j--){
		for (float i=0;i<=(2*p);i=i+step){
		x=j*cos(i);
		y=b*sin(i);
		putpixel(x+x0,y+y0,ic);
		}}

	}else{

		a=a-1;

		for (int j=b-1;j>0;j--){
		for (float i=0;i<=(2*p);i=i+step){
		x=a*cos(i);
		y=j*sin(i);
		putpixel(x+x0,y+y0,ic);
		}}
	}
		
}


void main(){
int gd=DETECT,gm;
initgraph(&gd,&gm,"..\\bgi");
int x0,y0,a,b,ic,oc1,oc2,oc3,oc4;

	cout<<"\n  Enter the center point of the ellipse \n";
	cin>>x0>>y0;
	cout<<"\n  Enter a and b \n";
	cin>>a>>b;
	cout<<"\n  Enter inside color (1-15) \n";
	cin>>ic;

	cout<<"\n  Enter outside color1 (1-15) \n";
	cin>>oc1;
	cout<<"\n  Enter outside color2 (1-15) \n";
	cin>>oc2;
	cout<<"\n  Enter outside color3 (1-15) \n";
	cin>>oc3;
	cout<<"\n  Enter outside color4 (1-15) \n";
	cin>>oc4;

	rectangle(x0,y0,a,b,oc1,oc2,oc3,oc4);
	ellipse(x0,y0,a,b,ic);


getch();
closegraph();
}