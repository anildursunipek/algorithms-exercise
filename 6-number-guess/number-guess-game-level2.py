import random
num = random.randint(1,20)
numberGuess = 0
state = True
while state == True:
    playerNum = int(input('Enter your guessed number(between 1 and 20): '))
    numberGuess += 1
    if num == playerNum:
        print('Your guess true. You won.')
        state = False
    elif num > playerNum:
        print('Your guess false. Your number is smaller.')
    else:
        print('Your guess false. Your number is bigger.')

print(f'Correct number: {num} \n'
      f'Number Of Guesses: {numberGuess} ')