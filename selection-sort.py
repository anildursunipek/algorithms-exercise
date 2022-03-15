"""SELECTİON SORT ALGORİTHM"""

arr = []
arrLen = int(input('Enter string length: '))
for i in range(arrLen):
    index = int(input('Enter the number you want to add: '))
    arr.append(index)

for i in range(arrLen):
    min = arr[i]
    for x in range(i,arrLen):
        if arr[x] < min:
            min = arr[x]
            minİndex = x
    if not min == arr[i]:
        swap = arr[i]
        arr[i] = arr[minİndex]
        arr[minİndex] = swap
"""
--> Döngü dizi uzunlugu kadar tekrarlanmaktadır.
--> 2 for ile çözülmüştür. Her for çalıştığında en soldan en sağa doğru karşılaştırma yapılır.
--> Karşılaştırma bittiğinde minimum sayı tutularak indexi ile birlikte ilk güvenli çizginin sağındaki sayı ile swap işlemi yapılır.
"""

print(arr)




