# include <iostream>
using namespace std;
void main()
{
setlocale(LC_CTYPE, "Russian");
//int number=0;
//cout<<"������� ����� ����� ��0 ��100\n";
//cin>>number;
//if(number<10)
//{
//	cout<<"� ���� ����� ������ 2 ����\n";
//}
//else
//if(number>=100&&number<100)
//{
//cout<<"����� ���� ����� ����� �����:"<<(number/10)+(number%10)<<\n";
//}
//}
//


//{
//setlocale(LC_CTYPE, "Russian");
//	int count=0, i=0;
//	cout<<"������� ���-��\n";
//	cin>>count;
//	while(i<count)
//	{
//		cout<<"Hello ";
//		i++;
//	}
//	cout<<"\n";
//}


//int count=0;
//cout<<"������� ���-��\n";
//cin>>count;
//for(int i=0; i<count; i++)
//{
//cout<<"+";
//}
//cout<<endl;
////}





//int count=0, i=0;
//cout<<"������� ���-��\n";
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
//cout<<"������� ������ ���������\n";
//cin>>start;
//cout<<"������� ����� ���������\n";
//cin>>end;
//if(start>end)
//	cout<<"�������� ������ �� �����!\n";
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
//cout<<"������� ������ ���������\n";
//	cin>>start;
//cout<<"������� ����� ���������\n";
//	cin>>end;
//	if(start>end)
//		cout<<"�������� ������ �� �����\n";
//	else
//	{
//		i=start;
//		while(i<=end)
//		{
//			cout<<i<<" ";
//			sum=sum+i;
//			i++;
//		}
//		cout<<"\n ����� �����:\t"<<sum<<"\n";
//	}
//}
//
int number=0, i=0, end=0, sum=0;
cout<<"������� ������ ���������\n";
cin>>number;
cout<<"������� ����� ���������\n";
cin>>end;
if(i%2)
	cout<<" ����� ������\n";
else
	i=number;
	while(i<=end)
	{
		cout<<i<<" ";
		sum=sum+i;
		i++;
	}
	cout<<"\n ����� �������� ����� �����:\t"<<sum<<"\n";
}
}

