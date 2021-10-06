string = input("Enter a phrase: ")
integer = int(input("Enter an integer: "))


def print_x_times(string: str, integer: int) -> None:
    for _ in range(integer):
        print(string)
