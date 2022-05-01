#include <stdio.h>
#include <math.h>
#include <stdlib.h>

int compare(int num1,int num2);
int enterNumber();

int main(){
    int num1,num2,counter=1;
    while(1){
        if(counter == 1){
            num1 = enterNumber();
            if(num1 == -1){
                printf("Exiting...\n");
                break;
            }
            num2 = num1;
            counter +=1;
            continue;
        }
        num1 = enterNumber();
        if(num1 == -1){
            printf("Exiting...\n");
            break;
        }
        compare(num1,num2);
        num2 = num1;
}}
int compare(int num1,int num2){
    if(num1>num2){
        printf("%d bigger than %d\n",num1,num2);
    }
    else if(num1<num2){
        printf("%d smallar than %d\n",num1,num2);
    }
    else{
        printf("%d == %d\n",num1,num2);
    }
}
int enterNumber(){
    int num;
    printf("Please enter the number: \n");
    scanf("%d",&num);
    return num;
}
