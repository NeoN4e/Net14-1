# include <iostream>
using namespace std;
void main()
{
setlocale(LC_CTYPE, "Russian");
//int number=0;
//cout<<"введите целое число от0 до100\n";
//cin>>number;
//if(number<10)
//{
//	cout<<"в этом числе меньше 2 цифр\n";
//}
//else
//if(number>=100&&number<100)
//{
//cout<<"сумма цифр этого числа равна:"<<(number/10)+(number%10)<<\n";
//}
//}
//


//{
//setlocale(LC_CTYPE, "Russian");
//	int count=0, i=0;
//	cout<<"введите кол-во\n";
//	cin>>count;
//	while(i<count)
//	{
//		cout<<"Hello ";
//		i++;
//	}
//	cout<<"\n";
//}


//int count=0;
//cout<<"введите кол-во\n";
//cin>>count;
//for(int i=0; i<count; i++)
//{
//cout<<"+";
//}
//cout<<endl;
////}





//int count=0, i=0;
//cout<<"введите кол-во\n";
//cin>>count;
//do
//{
//	if(count==0) break;
//	cout<<"*";
//	i++;
//}
//while(i<count);
//}




//int start=0, end=0;
//cout<<"введите начало диапазона\n";
//cin>>start;
//cout<<"введите конец диапазона\n";
//cin>>end;
//if(start>end)
//	cout<<"диапазон указан не верно!\n";
//else
//{
//	for(int i=start; i<=end; i++)
//		cout<<i<<" ";
//	cout<<"\n";
//}
//}


//
//
//int start=0, end=0, i=0, sum=0;
//cout<<"введите начало диапазоне\n";
//	cin>>start;
//cout<<"введите конец диапазона\n";
//	cin>>end;
//	if(start>end)
//		cout<<"диапазон указан не верно\n";
//	else
//	{
//		i=start;
//		while(i<=end)
//		{
//			cout<<i<<" ";
//			sum=sum+i;
//			i++;
//		}
//		cout<<"\n сумма равна:\t"<<sum<<"\n";
//	}
//}
//
int number=0, i=0, end=0, sum=0;
cout<<"введите начало диапазона\n";
cin>>number;
cout<<"введите конец диапазона\n";
cin>>end;
if(i%2)
	cout<<" числа четные\n";
else
	i=number;
	while(i<=end)
	{
		cout<<i<<" ";
		sum=sum+i;
		i++;
	}
	cout<<"\n сумма нечетных чисел равна:\t"<<sum<<"\n";
}
}

