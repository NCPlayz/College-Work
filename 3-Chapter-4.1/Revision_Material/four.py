one = int(input("Enter an integer:"))
two = int(input("Enter an integer:"))
three = int(input("Enter an integer:"))


def largest(first, second, third):
    if first > second and first > third:
        return first
    elif second > first and second > third:
        return second
    elif third > first and third > second:
        return third
    else:
        return 0


def output(value):
    print(value)


value = largest(one, two, three)

output(value)
