#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#define ARRAY_SIZE 20
int binary_search(int array[],int array_size,int sort_value);
int bubble_sort(int array[],int array_size);
int data_printing(int array[],int array_size);
void main(){
    int array[ARRAY_SIZE] = {0};
    int search_value,search;
    srand(time(NULL));
    /* data preparing*/
    for(int i=0;i<ARRAY_SIZE;i++){
        array[i] = rand()%100 +1; 
    }
    /* data printing */
    data_printing(array,ARRAY_SIZE);
    
    /* data sorting */
    bubble_sort(array,ARRAY_SIZE);

    /* printing sorting data */
    data_printing(array,ARRAY_SIZE);
    /* Binary Search */
    printf("Aramak istediginiz degeri giriniz= ");
    scanf("%d",&search_value);
    search = binary_search(array,ARRAY_SIZE,search_value);
    if(search != -1){
        printf("\nAradiginiz deger %d. index'te bulundu",search);
    }
    else{
        printf("\nAradiginiz deger bulunamadi");
    }
}

int bubble_sort(int arr[],int a_size){
    int pivot = 0;
    for(int x=0 ; x < a_size - 1 ; x++){
        for(int index=0 ; index < a_size-x-1 ;index++){
            if(arr[index] > arr[index + 1]){
                pivot = arr[index];
                arr[index] = arr[index+1];
                arr[index+1] = pivot;
            }
        }
    }
}
int data_printing(int arr[],int arr_size){
    printf("%4s %15s\n","INDEX","ELEMENT");
    for(int b=0;b<arr_size;b++){
        printf("%4d %15d  ",b,arr[b]);
        for(int a=1;a<=arr[b];a++){
            printf("*");
        }
        printf("\n");
    }
    
}
void print_index(void){
    for(int i=0;i < ARRAY_SIZE - 1;i++){
        printf("%5d",i);
    }
    printf("\n");
    for(int i=0;i < 5 * ARRAY_SIZE;i++){
        printf("-");
    }
    printf("\n");
}
void print_search(int array[],int max,int min,int middle){
    int i=0;
    for(i;i<=ARRAY_SIZE-1;i++){
        if(i < min || i > max){
            printf("     ");
        }
        else if(i == middle){
            printf("%5d*",array[i]);
        }
        else{
            printf("%5d",array[i]);
        }
    }
    printf("\n");
}
int binary_search(int array[],int array_size,int search_element){
    int max_index, min_index, middle;
    max_index = array_size-1;
    min_index = 0;
    print_index();
    while(min_index <= max_index){
        middle= (min_index + max_index) / 2;
        print_search(array,max_index,min_index,middle);
        if(search_element == array[middle]){
            return middle;
            break;
        }
        else if(search_element < array[middle]){
            max_index = middle-1;
        }
        else{
            min_index = middle+1;
        }
    }
    return -1;
}