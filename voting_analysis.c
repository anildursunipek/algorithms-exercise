#include<stdio.h>
#define NUMBER_OF_VOTE 40
#define VOTE_FREQUENCY 11

int main(){
    int votes[NUMBER_OF_VOTE] ={ 1, 2, 6, 4, 8, 5, 9, 7, 8, 10,
                                 1, 6, 3, 8, 6, 10, 3, 8, 2, 7,
                                 6, 5, 7, 6, 8, 6, 7, 5, 6, 6,
                                 5, 6, 7, 5, 6, 4, 8, 6, 8, 10 };
    int freqency[VOTE_FREQUENCY] = {0};

    for(int i=0 ; i < NUMBER_OF_VOTE ; i++){
        ++freqency[votes[i]];}
    printf("%s%15s","VOTE","FREQUENCY");   
    for(int y=0 ; y<VOTE_FREQUENCY ; y++){
        printf("%d%15d\n",y,freqency[y]);}

}