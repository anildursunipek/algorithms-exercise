""" Collatz Conjecture"""

def collatz(x):
    counter = 1
    max_value = x
    print(x)
    while True:
        try:
            if(x==1):
                print(f"{counter} number found and maximum number = {max_value}")
                break
            elif(x<1):
                raise Exception("Number can't be smaller than 1")
                break
            else:
                if(x%2==0):
                    x = x/2
                    print(x)
                    counter +=1
                elif(x%2==1):
                    x = 3*x +1
                    print(x)
                    if(max_value<x):
                        max_value = x
                    counter +=1
        except:
            print("There is an error in the variable")
            break


collatz(-1)