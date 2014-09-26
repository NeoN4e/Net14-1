//#include <iostream>
//using namespace std;
//void main()
//
//{
//	setlocale(LC_CTYPE,"Rus");
//	cout<<"\tПрограмма для подсчета среднеарефметического значения чисел \n\n\n";
//	float chislo1, chislo2, chislo3;
//	float otvet;
//	cout<<"Введите первое число: \n";
//	cin>>chislo1;
//	cout<<"Введите второе число: \n";
//	cin>>chislo2;
//	cout<<"Введите третье число: \n";
//	cin>>chislo3;
//	otvet=(chislo1+chislo2+chislo3)/3;
//	cout<<"Средне арифметическое заданных чисел "<<otvet<< "\n\n";
//	
//
//}

//#include <iostream>
//using namespace std;
//void main()
//
//{
//	setlocale(LC_CTYPE,"Rus");
//	cout<<"\t\tПрограма для перевода СМ в дюймы!\n\n";
//	float sm;
//	float otvet;
//	cout<<"Введите количество сантиметров: \n";
//	cin>>sm;
//	otvet=sm/2.54;
//	cout<<"Это получается " <<otvet<<" дюймов \n\n";
//
//}

#include <iostream>
using namespace std;
void main()

{
	setlocale(LC_CTYPE,"Rus");
	cout<<" Введите число от 1 до 100 \n";
	short chislo;
	cin>>chislo;
	if (chislo<1 && chislo>99);
	cout<<"\n";
	cout<<"Это число не подходит \n";
}