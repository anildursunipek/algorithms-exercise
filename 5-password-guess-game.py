import random

password = str(random.randint(1000,9999))
passArr = []
answer = []
gameNum = 0

#Created new array for password
for i in password:
    passArr.append(i)
#print(passArr)

#Loop
while passArr != answer:
    answer = []
    array = []
    for x in range(len(passArr)):
        playerGuess = str(input('Enter the guessed number: '))
        answer.append(playerGuess)

    for y in range(4):
        if answer[y] == passArr[y]:
            array.append("*")
        else:
            for x in range(4):
                if answer[y] == passArr[x]:
                    array.append("+")
                    break
            else:
                array.append("-")

    #Probably calculate
    numberStar = 0
    numberPlus = 0
    numberMinus = 0
    for prob in range(4):
        if array[prob] == "*":
            numberStar +=1
        elif array[prob] == "+":
            numberPlus +=1
        else:
            numberMinus +=1
    probably = (1/(3-numberStar)**numberPlus)*((1/10)**numberMinus)
    #print(numberPlus,numberMinus,numberStar)
    print(f'Your chance: {probably:.4f}')
    print(array)
    gameNum += 1

print(f'Total number of games: {gameNum}')