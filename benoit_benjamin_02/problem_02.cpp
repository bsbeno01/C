/* Benjamin S. Benoit
   CECS 130-11
   Assignment 2 */

#include <stdio.h>

int main()
{
	//variable declerations
	int a;
	int b;
	int x;
	int y;
	int f; 
	
	a = 0;
	b = 0;
	x = 0;
	y = 0;
	
	//varaible request prompt and deceleration via user input
	printf("\nEnter the a variable value: ");
	scanf("%d" , &a);
	printf("Enter the b variable value: ");
	scanf("%d" , &b);
	printf("Enter the x variable value: ");
	scanf("%d" , &x);
	printf("Enter the y variable value: ");
	scanf("%d" , &y);
	//printing results of variable inputs into the f equation
	f = (a-b)*(x - y);
	printf("The result is %d\n", f);
	return 0;
}
