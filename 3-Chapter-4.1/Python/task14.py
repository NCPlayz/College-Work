import random
from typing import Tuple

# enter one small integer then enter one large integer

value1 = int(input("Enter a small integer: "))
value2 = int(input("Enter a large integer: "))


def random_number(value1: int, value2: int) -> Tuple[int, int]:
    odd = 0
    even = 0
    for _ in range(30):
        value = random.randint(value1, value2)
        odd += 1 if value % 2 == 1 else 0
        even += 1 if value % 2 == 0 else 0
    return odd, even


if __name__ == "__main__":
    odd, even = random_number(value1, value2)

    print(f"Odd numbers: {odd}")
    print(f"Even numbers: {even}")
