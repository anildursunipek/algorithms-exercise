import random

action_list = ["rock","paper","scissors"]
computer_score = 0
player_score = 0
round_counter = 0
total_rounds = int(input("How many rounds do you want to play?Please enter a number here: "))

while True:
    round_counter += 1
    print("Round number: " , round_counter)

    computer_choice = random.choice(action_list)
    player_choice = input("Please choice your action: ").lower()
    print("Player choice is: ", player_choice)
    print("Computer choice is: ", computer_choice)

    # Tie condition
    if computer_choice == player_choice:
        print("Tie! Both players chose the same action")

    elif computer_choice == "rock":
        if player_choice == "paper":
            print("Winner is: Player")
            player_score +=1
        else:#İf player choice == "Scissors"
            print("Winner is: Computer")
            computer_score +=1

    elif computer_choice == "paper":
        if player_choice == "rock":
            print("Winner is: Computer")
            computer_score += 1
        else:#İf player choice == "Scissors"
            print("Winner is: Player")
            player_score += 1

    elif computer_choice == "scissors":
        if player_choice == "rock":
            print("Winner is: Player")
            player_score += 1
        else:#İf player choice == "paper"
            print("Winner is: Computer")
            computer_score += 1

    print(f"Computer: {computer_score}\n"
          f"Player: {player_score}")

    if total_rounds == round_counter:
        print("Game is over")
        break

if(computer_score == player_score):
    print("There is no winner. Tie!" , computer_score , ":" , player_score)
elif (computer_score > player_score):
    print("Computer won with score" , computer_score , ":" , player_score)
else: #(player_score < computer_score)
    print("Player won with score" , computer_score , ":" , player_score)


