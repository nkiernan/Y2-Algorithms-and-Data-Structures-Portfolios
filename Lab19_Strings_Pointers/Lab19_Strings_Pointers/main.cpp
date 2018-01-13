#include <iostream>
#include <cstdlib>
#include <string>

#include <time.h>

using namespace std;

void substitute(char c1, char c2, string &str)
{
	for (int i = 0; i < str.length(); i++)
	{
		if (str[i] == c1)
		{
			str[i] = c2;
		}
	}
}

int main(char* argv[], int argc)
{
	char ch1 = 'b';
	char ch2 = 'c';
	string test = "bat";

	cout << test << endl;
	substitute(ch1, ch2, test);
	cout << test << endl;
}