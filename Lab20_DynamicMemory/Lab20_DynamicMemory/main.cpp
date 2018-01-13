#include <iostream>
#include <string>

using namespace std;

void someFunction()
{
	const int DATASIZE = 50000;
	int data[DATASIZE];
	for (int i =0; i < DATASIZE; i++)
	{
		data[i] = 99;
	}
};

int* createAndFillArray()
{
	int somedata[2000];

	int* myarray = new int[10];
	for (int i = 0; i < 10; i++)
	{
		myarray[i] = i * 10;
	}
	return &myarray[0];
}

int main(int argc, char* argv[])
{
	int *nums;
	nums = createAndFillArray();

	someFunction();
	cout << "Array Elements" << endl;

	for (int i = 0; i < 10; i++)
	{
		cout << nums[i] << " ";
	}

	cin.get();
}