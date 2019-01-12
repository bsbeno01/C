/* Benjamin S. Benoit
   CECS 130-11
   Assignment 2 */


#include <iostream>
#include <stdio.h>
#include <ctype.h>
#include <time.h>
#include <cstdlib>


int main()
{
	int iRandomNum = 0;
	int iResponse = 0; 
	srand(time(NULL));
	iRandomNum = ( rand() %10)+1;
	
	
	printf("\nWelcome to the number guessing game\n");
	printf("\nGuess a number between 1 and 10: ");
	scanf("%d", &iResponse);
	
	if (!isdigit(iResponse) ==0 ) {
	
		printf("\nYou did not enter a number between 1 and 10\n");
		return 0;
	}
	if (iResponse == iRandomNum) {
		printf("\nCongratulations, you guessed correctly\n");
	}
	else {
		printf("\nYou guessed the wrong number\n");
		printf("\nThe correct number was %d\n", iRandomNum);
	}
	return 0;
}
