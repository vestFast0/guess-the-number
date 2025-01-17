import random

def main():
    print("Guess the number!")

    secret_number = random.randint(1, 100)

    while True:
        guess = input("Please input your guess: ")

        try:
            guess = int(guess)
        except ValueError:
            continue

        print(f"You guessed: {guess}")

        if guess < secret_number:
            print("Too small!")
        elif guess > secret_number:
            print("Too big!")
        else:
            print("You win!")
            break

if __name__ == "__main__":
    main()
