one = [int(input("Enter an integer: ")) for _ in range(10)]
two = [int(input("Enter an integer: ")) for _ in range(10)]

not_equal_count = 0

for i in range(10):
    not_equal_count += one[i] == two[i]

print(not_equal_count)
