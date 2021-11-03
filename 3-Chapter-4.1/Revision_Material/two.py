one = int(input("Enter an integer:"))
two = int(input("Enter an integer:"))
three = int(input("Enter an integer:"))


def sum(first, second, third):
    return first + second + third


def output(value):
    print(value)


output(sum(one, two, three))
