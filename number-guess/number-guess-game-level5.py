import random

numberGuess = 0

while True:
    num = random.randint(1, 20)
    print('GAME MENU'.center(50,"*"))
    print('P - Start The Game\n'
          'D - Debug Mode\n'
          'X - Exit The Game')

    playerİnput = input('Select the action you want to do: ')
    #Start the game
    if playerİnput == 'p' or playerİnput == 'P':
        print('Starting game ...(Press S to unlock cheat mode, Press X Return the menu)')
        while True:
            playerNum = input('Enter your guessed number(between 1 and 20): ')
            if playerNum == 's' or playerNum == 'S':
                print(f'Cheat mode correct number: {num}')
            elif playerNum == 'x' or playerNum == 'X':
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
    #Debug mode
    elif playerİnput == 'd' or playerİnput == 'D':
        print('Starting debug mode ...(Press D Exit the debug mode)')
        while True:
            print(f'Debug mode -- Correct Number is {num}')
            playerNum = input('Enter your guessed number(between 1 and 20): ')
            if playerNum == 'd' or playerNum == 'D':
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
