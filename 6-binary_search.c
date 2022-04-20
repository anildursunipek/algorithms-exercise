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
        printf("Aradiginiz deger %d. index'te bulundu",search);
    }
    else{
        printf("Aradiginiz deger bulunamadi");
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
int binary_search(int array[],int array_size,int search_element){
    int base_stat = 1, max_index, min_index;
    max_index = array_size-1;
    min_index = 0;

    while(1){
        if(search_element == array[(max_index-min_index)/2]){
            return (max_index-min_index)/2;
            break;
        }
        else if(search_element < array[(max_index-min_index)/2]){
            max_index = ((max_index-min_index)/2)-1;
        }
        else if(search_element > array[(max_index-min_index)/2]){
            max_index = ((max_index-min_index)/2)+1;
        }
        else{
            return -1;
            break;
        }
    }

}