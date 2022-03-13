"""BUBBLE SORT ALGORİTHM"""
#Section 1 Creating a new array
arr = []
arrayLen = int(input('Enter string length: '))
for i in range(arrayLen):
    i = int(input('Enter the number you want to add: '))
    arr.append(i)

#Section 2 Sorting

for i in range(len(arr)-1):
    for x in range(0,len(arr)-1-i):
        if arr[x] > arr[x+1]:
            swap = arr[x]
            arr[x] = arr[x+1]
            arr[x+1] = swap
print(arr)
