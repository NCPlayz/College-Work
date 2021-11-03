def validate(input):
    return input >= 2


def get_input():
    inp = int(input("Enter an integer:"))
    if validate(inp):
        return inp
    print("Must be greater or equal to 2")
    return get_input()


value = get_input()
print(value)
