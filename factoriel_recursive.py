#Burada özyinelemeli bir fonksiyon kurgulanmıştır.
#ternary operator kullanılarak return işlemi uygulanmıştır
#Bu sayede 2 satırda yazılabilmiştir fonksiyon
def faktoriyel(num):
    return 1 if num==0 or num==1 else num * faktoriyel(num-1)
print(faktoriyel(5))