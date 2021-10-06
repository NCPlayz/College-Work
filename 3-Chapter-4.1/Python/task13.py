# prompt the user to enter 3 decimals
# convert the input to a float

value1 = float(input("Enter a decimal number: "))
value2 = float(input("Enter another decimal number: "))
value3 = float(input("Enter another decimal number: "))


def sum(value1: float, value2: float, value3: float) -> float:
    return value1 + value2 + value3


def average(value1: float, value2: float, value3: float) -> float:
    return sum(value1, value2, value3) / 3


if __name__ == "__main__":
    print(f"The sum of the three numbers is {sum(value1, value2, value3)}")
    print(f"The average of the three numbers is {average(value1, value2, value3)}")
