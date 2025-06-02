import random

possible_choices = ["rock", "paper", "scissors"]

while True:
    user_input = input("Enter your choice: ").lower()  
    if user_input in possible_choices:
        break
    else:
        print("Invalid choice. Please try again.")            
        
        
        
        


opponents_choice = random.choice(possible_choices)
n = [0]

def playing_game():
    while True:
        print("Invalid choice. Please try again.")    
        if user_input == opponents_choice:
            print("Draw")
            for _ in len(n):
                _ + 1
        elif user_input == "rock" and opponents_choice == "scissors":
            print("You Won!")
            for _ in len(n):
                _ + 1
        elif user_input == "scissors" and opponents_choice == "paper":
            print("You Won!")
            for _ in len(n):
                _ + 1
        elif user_input == "paper" and opponents_choice == "rock":
            print("You Won!")
            for _ in len(n):
                _ + 1
        else:
            print("You lost!")
            break

playing_game()
﻿

