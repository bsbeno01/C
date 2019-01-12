/* Benjamin S. Benoit
   CECS 130-11
   Assignment 2 */



#include <stdio.h>

int main()
{
	float fRate, fSales_Price, fCost;
		//Commission = Rate * (Sales Price - Cost)
	printf("\nEnter total Rate: ");
	scanf("%f" , &fRate);
	printf("\nEnter total Sales Price: ");
	scanf("%f" , &fSales_Price);
	printf("\nEnter total Cost: ");
	scanf("%f" , &fCost);
	//The Commission as a result of inputs
	
	printf("\nYour Comission is $%.2f\n",fRate * (fSales_Price - fCost));
	
	return 0;
	
}
