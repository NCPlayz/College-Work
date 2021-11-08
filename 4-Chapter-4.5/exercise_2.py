from typing import Literal, Union
from exercise_1 import get_8_bit

first = get_8_bit()
second = get_8_bit()


def is_on(char: Literal["0", "1"]) -> Literal["1"]:
    return char == "1"


def is_off(char: Literal["0", "1"]) -> Literal["0"]:
    return char == "0"


def add_one(first: str, second: str) -> tuple[Literal["0", "1"], Literal["0", "1"]]:
    if is_off(first) and is_on(second):
        return "1", "0"
    elif is_on(first) and is_off(second):
        return "1", "0"
    elif is_on(first) and is_on(second):
        return "0", "1"


def add(first: str, second: str) -> str:
    result: list[Literal["0", "1"]] = []
    carry = "0"
    for i in range(len(first) - 1, -1, -1):
        f = first[i]
        s = second[i]

        res, new_carry = add_one(f, s)
        res, new_carry = add_one(res, carry)

        result.insert(0, res)
        carry = new_carry

    return "".join(result)


print(add("00100111", "01001100"))
