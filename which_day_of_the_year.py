def artıkYıl(yıl):
    if yıl % 4 == 0:
        return 1
    else:
        return 0

def gunHesaplayıcı(gun,ay,yıl):
    toplamGün=0
    aylar = [31,28,31,30,31,30,31,31,30,31,30,31]
    for i in range(ay-1):
        toplamGün += aylar[i]
    toplamGün += gun
    if ay>=3:
        toplamGün += artıkYıl(yıl)
    return toplamGün
gun = int(input('Gün giriniz: '))
ay = int(input('Ay giriniz: '))
yıl = int(input('Yıl giriniz: '))
result = gunHesaplayıcı(gun,ay,yıl)
print(result)


