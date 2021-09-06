import random
from typing import Generator, List, Tuple

# generate 6 numbers between 1 and 49 inclusive.
# the numbers must not repeat.
def lottery() -> Tuple[List[int], int]:
    numbers: List[int] = []
    while len(numbers) < 7:
        num = random.randint(1, 49)
        if num not in numbers:
            numbers.append(num)
    return numbers[:6], numbers[6]

# get input from the user containing all 7 numbers.
# if the input is valid, show the user which of their numbers were correct
# return the probability of him having chosen that combination.
def check_numbers(numbers: List[int], real_numbers: List[int], bonus: int) -> Generator[int, None, None]:
    for n in numbers:
        if n in real_numbers:
            yield n
        if n == bonus:
            yield n


def main():
    real_numbers, bonus = lottery()
    while True:
        numbers = input('Enter your 7 numbers: ')
        numbers = numbers.split()
        numbers = [int(i) for i in numbers]
        if len(numbers) != 7:
            print('You must enter 7 numbers')
            continue
        probability = list(check_numbers(numbers, real_numbers, bonus))
        if len(probability) == len(real_numbers) + 1:
            print('You won!')
            break
        if len(probability):
            print('You have got:', ', '.join(f'({i})' for i in probability))
        print('You did not win.')
