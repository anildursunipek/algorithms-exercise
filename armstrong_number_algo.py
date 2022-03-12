def sayiBasamak(num):
    n = 0
    while num != 0:
        n +=1
        num = num // 10
    return n

def armstrongNumber(num):
    n = sayiBasamak(num)
    string = str(num)
    toplam = 0
    for i in string:
        i = int(i)
        toplam += pow(i,n)
    print('toplam=',toplam)
    if num == toplam:
        print(f"{num} is an armstrong number")
    else:
        print(f"{num} is not an armstrong number")
armstrongNumber(173)
armstrongNumber(153)
armstrongNumber(1634)