#include<stdio.h>
#define INDEX_NUMBER 10
int main(){
    int array[INDEX_NUMBER];

    for(int i=0 ; i < INDEX_NUMBER ; i++ ){
        scanf("%d", &array[i]);
    }
    printf("%s%10s%20s\n","INDEX","VALUE","LINECHART");
    for(int y=0 ; y < INDEX_NUMBER ; y++){
    printf("%5d%10d           ",y,array[y]);
        for(int x=1 ; x <= array[y] ; x++){
            printf("*");
        }
    printf("\n");
    }
}