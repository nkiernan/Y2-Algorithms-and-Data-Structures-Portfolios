#include <iostream>

using namespace std;

int main()
{
	int fib1, fib2, x, num;
	cout << "Enter number: ";
	cin >> num;

	fib1 = 0;
	fib2 = 1;

	if (num == 1)
	{
		cout << fib1;
	}
	else if (num == 2)
	{
		cout << fib1 << " " << fib2;
	}
	else
	{
		cout << fib1 << " " << fib2 << " ";
		for (int i = 1; i <= (num - 2); i++)
		{
			x = fib1 + fib2;
			cout << x << " ";
			fib1 = fib2;
			fib2 = x;
		}
	}
}