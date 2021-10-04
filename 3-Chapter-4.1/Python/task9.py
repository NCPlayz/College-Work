from typing import List


def intput(prompt: str = "Enter an integer: ") -> int:
    return int(input(prompt))


l: List[int] = []
l2: List[str] = []

for i in range(20):
    v = intput()
    l.append(v)
    l2.append(str(v))

if all(i.isnumeric() for i in l2):
    print("All elements are integers")
else:
    print("Not all elements are integers")
