import random
num = random.randint(1,20)
numberGuess = 0

while True:
    print('GAME MENU'.center(50,"*"))
    print('S - Start The Game\n'
          'X - Exit The Menu')

    playerİnput = input('Select the action you want to do: ')
    #Start the game
    if playerİnput == 's' or playerİnput == 'S':
        print('Starting game ...')
        while True:
            playerNum = input('Enter your guessed number(between 1 and 20): ')

            if playerNum == 'x' or playerNum == 'X':
                print('Returning to the menu')
                break
            elif num == int(playerNum):
                numberGuess += 1
                print('Your guess true. You won.')
                break
            elif num > int(playerNum):
                numberGuess += 1
                print('Your guess false. Your number is smaller.')
            elif num < int(playerNum):
                numberGuess += 1
                print('Your guess false. Your number is bigger.')
        print(f'Correct number: {num} \n'
              f'Number Of Guesses: {numberGuess} ')
    #Exit the game
    elif playerİnput == 'x' or playerİnput == 'X':
        print('Exiting game ...')
        break


