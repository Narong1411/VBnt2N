#include<stdio.h>
#include<conio.h>

int main()

{
	int a,b=0,c,d=0,e,k;
	
	printf("Welcome\n");
	printf("1.PEPSI 15 \n");
	printf("2.FANTA 20\n");
	printf("3.COKE 25\n");
	printf("input :");scanf("%d",&a);
	
	printf("\n");
	if(a==1){
		printf("Buy PEPSI Price 15 thB\n");
		k=15;
	
		
		
		while(c<15){
		printf("Plese input Money:");scanf("%d",&b);
		if(b==5||b==10){
		d=d+b;
		}
		else{
			printf("\nMachine can get coin 5 and 10\n");
			printf("Plese input money :5\n");
			printf("Plese input money :10\n");
			printf("*********************\n");
		}
		c=d;
		}
		e=c-k;
	printf("\n\n:: You can get water in the box below ::\n");
	printf("Total : %d\n",k);
	printf("Pay :%d\n",d);
	printf("Exchange :%d\n",e);
	printf(":: THANKYOU JUB JUB (^_^) ::");
		
	}
	else if(a==2){
	printf("Buy FANTA Price 20 thB\n");
		k=20;
		
		
		while(c<20){
		printf("Plese input Money:");scanf("%d",&b);
		if(b==5||b==10){
		d=d+b;
		}
		else{
			printf("\nMachine can get coin 5 and 10\n");
			printf("Plese input money :5\n");
			printf("Plese input money :10\n");
			printf("*********************\n");
		}
		c=d;
		}
		e=c-k;
	printf("\n\n:: You can get water in the box below ::\n");
	printf("Total : %d\n",k);
	printf("Pay :%d\n",d);
	printf("Exchange :%d\n",e);
	printf(":: THANKYOU JUB JUB (^_^) ::");
		
	}
	else if(a==3){
	printf("Buy COKE Price 25 thB\n");
		k=25;
		
		
		while(c<25){
		printf("Plese input Money:");scanf("%d",&b);
		if(b==5||b==10){
		d=d+b;
		}
		else{
			printf("\nMachine can get coin 5 and 10\n");
			printf("Plese input money :5\n");
			printf("Plese input money :10\n");
			printf("*********************\n");
		}
		c=d;
		}
		e=c-k;
	printf("\n\n:: You can get water in the box below ::\n");
	printf("Total : %d\n",k);
	printf("Pay :%d\n",d);
	printf("Exchange :%d\n",e);
	printf(":: THANKYOU JUB JUB (^_^) ::");
	}
	}
