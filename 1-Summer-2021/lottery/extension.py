import random
from typing import Final, Generator, List, Tuple

MAX_LOTTERY_NUMBERS: Final[int] = 6
UPPER_BOUND: Final[int] = 49
LOWER_BOUND: Final[int] = 1

# generate 6 numbers between 1 and 49 inclusive.
# the numbers must not repeat.
def lottery() -> Tuple[List[int], int]:
    """Generate 6 lottery numbers and a bonus number.

    Returns:
        A tuple containing the lottery numbers and the bonus number.
    """
    numbers: List[int] = []
    while len(numbers) < MAX_LOTTERY_NUMBERS + 1:
        num: int = random.randint(LOWER_BOUND, UPPER_BOUND)
        if num not in numbers:
            numbers.append(num)
    return numbers[:6], numbers[6]


# get input from the user containing all 7 numbers.
# if the input is valid, show the user which of their numbers were correct
# return the probability of him having chosen that combination.
def check_numbers(
    numbers: List[int], real_numbers: List[int], bonus: int
) -> Generator[int, None, None]:
    """Check if the user has won the lottery.

    Args:
        numbers: The user's numbers.
        real_numbers: The lottery numbers.
        bonus: The bonus number.

    Returns:
        A generator containing the numbers that the user has guessed correctly.
    """
    for n in numbers:
        if n in real_numbers:
            yield n
        if n == bonus:
            yield n


def main() -> None:
    real_numbers, bonus = lottery()
    while True:
        numbers_input: str = input(f"Enter your {MAX_LOTTERY_NUMBERS + 1} numbers: ")

        numbers_str: List[str] = numbers_input.split()
        numbers: List[int] = [int(i) for i in numbers_str]

        if len(numbers) != MAX_LOTTERY_NUMBERS + 1:
            print(f"You must enter {MAX_LOTTERY_NUMBERS + 1} numbers")
            continue

        probability: List[int] = list(check_numbers(numbers, real_numbers, bonus))

        if len(probability) == len(real_numbers) + 1:
            print("You won!")
            break

        if len(probability):
            print("You have got:", ", ".join(f"({i})" for i in probability))

        print("You did not win.")


if __name__ == "__main__":
    main()
