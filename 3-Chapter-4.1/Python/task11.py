from typing import List


a: List[int] = []

for i in range(10):
    if i == 0:
        a.append(i)
    else:
        a.append(a[-1] + 23)

b: List[int] = [int(input("Enter an integer: ")) for _ in range(10)]

for i in range(10):
    if a[i] == b[i]:
        print(f"{a[i]} is equal to {b[i]}")
    else:
        print(f"{a[i]} is not equal to {b[i]}")
