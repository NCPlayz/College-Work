import random
from typing import List, Tuple

# generate 6 numbers between 1 and 49 inclusive.
# the numbers must not repeat.
def lottery() -> Tuple[List[int], int]:
    """Generate a lottery number and return it as a tuple."""
    numbers: List[int] = []
    while len(numbers) < 7:
        num: int = random.randint(1, 49)
        if num not in numbers:
            numbers.append(num)
    return numbers[:6], numbers[6]


numbers, bonus = lottery()

print("Numbers:", ", ".join(f"({i})" for i in numbers))
print("Bonus:", f"({bonus})")
