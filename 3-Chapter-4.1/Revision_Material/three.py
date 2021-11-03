one = int(input("Enter an integer:"))
two = int(input("Enter an integer:"))
three = int(input("Enter an integer:"))


def sum(first, second, third):
    return first + second + third


def output(value):
    print(value)


if one > two and one > three:
    output(f"{one} is biggest")
elif two > one and two > three:
    output(f"{two} is bigger")
elif three > one and three > two:
    output(f"{three} is bigger")
else:
    output("All the numbers are the same.")
