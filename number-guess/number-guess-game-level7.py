import random
def motionFunc(motion):
    global num
    if num >= 3 and num <= 18:
            rnd = random.randint(1, 2)
            if rnd == 1:
                num += 2
            else:
                num -= 2
    elif num <3:
        num +=2
    else:
        num -=2
    return num

numberGuess = 0

while True:
    motion = 0
    num = random.randint(1, 20)
    print('GAME MENU'.center(50,"*"))
    print('P - Start The Game\n'
          'D - Debug Mode\n'
          'X - Exit The Game')

    playerİnput = input('Select the action you want to do: ')
    #Start the game
    if playerİnput == 'p' or playerİnput == 'P':
        print('Starting game ...(Press S to unlock cheat mode, Press X Return the menu, Press M turn on the motion mode, Press N start the new game)')
        while True:
            playerNum = input('Enter your guessed number(between 1 and 20): ')
            if playerNum == 'm' or playerNum == 'M':
                if motion == 0:
                    motion = 1
                    print('Motion mode turned on')
                elif motion == 1:
                    motion = 0
                    print('Motion mode turned off')
            elif playerNum == 'n' or playerNum == 'N':
                print('Starting new game...')
                num = random.randint(1, 20)
            elif playerNum == 's' or playerNum == 'S':
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
                if motion == 1:
                    motionFunc(motion)
            elif num < int(playerNum):
                numberGuess += 1
                print('Your guess false. Your number is bigger.')
                if motion == 1:
                    motionFunc(motion)

        print(f'Correct number: {num} \n'
              f'Number Of Guesses: {numberGuess} ')
    #Debug mode
    elif playerİnput == 'd' or playerİnput == 'D':
        print('Starting debug mode ...(Press D Exit the debug mode, Press M turn on the motion mode, Press N start the new game)')
        while True:
            print(f'Debug mode -- Correct Number is {num}')
            playerNum = input('Enter your guessed number(between 1 and 20): ')
            if playerNum == 'm' or playerNum == 'M':
                if motion == 0:
                    motion = 1
                    print('Motion mode turned on')
                elif motion == 1:
                    motion = 0
                    print('Motion mode turned off')
            elif playerNum == 'n' or playerNum == 'N':
                print('Starting new game...')
                num = random.randint(1, 20)
            elif playerNum == 'd' or playerNum == 'D' or playerNum =='x' or playerNum=='X':
                print('Returning to the menu')
                break
            elif num == int(playerNum):
                numberGuess += 1
                print('Your guess true. You won.')
                break
            elif num > int(playerNum):
                numberGuess += 1
                print('Your guess false. Your number is smaller.')
                if motion == 1:
                    motionFunc(motion)
            elif num < int(playerNum):
                numberGuess += 1
                print('Your guess false. Your number is bigger.')
                if motion == 1:
                    motionFunc(motion)
        print(f'Correct number: {num} \n'
              f'Number Of Guesses: {numberGuess} ')

    #Exit the game
    elif playerİnput == 'x' or playerİnput == 'X':
        print('Exiting game ...')
        break
