import random
num = random.randint(1,20)
playerNum = int(input('Enter your guessed number(between 1 and 20): '))
if num == playerNum:
    print('Your guess true. You won.')
elif num > playerNum:
    print('Your guess false. Your number is smaller.')
else:
    print('Your guess false. Your number is bigger.')

print(f'Correct number: {num}')