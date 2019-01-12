/* Benjamin S. Benoit
   CECS 130-50
   Assignment 2 */

#include <iostream>
#include <stdio.h>

int main()
{
	//variable declerations
	int a;
	int b;
	int x;
	int y;
	int f;
	
	//varaible initializations
	a = 5;
	b = 1;
	x = 10;
	y = 5;
	f = (a - b)*(x -y);
	
	//printing variable contents to standard output
	printf("The result is %d\n", f);
	return 0;
}
