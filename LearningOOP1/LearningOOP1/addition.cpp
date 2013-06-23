#include "addition.h"
#include <iostream>
using namespace std;

Addition::Addition()
{
	num1 = 3;
	num2 = 8;
}

Addition::Addition(int num1, int num2 )
{
	int num3;

	num3=num1 + num2;
	
	cout<<num3;

}


