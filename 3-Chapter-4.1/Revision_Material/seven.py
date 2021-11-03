one = int(input("Enter an integer:"))
two = int(input("Enter an integer:"))

for i in range(17):
    one += 13
    two += 13

if one > two:
    one **= 3
    print(one)
else:
    total = one + two
    total **= 2
    print(total)
