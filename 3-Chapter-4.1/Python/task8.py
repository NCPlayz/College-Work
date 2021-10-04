def intput(prompt: str = "Enter an integer: ") -> int:
    return int(input(prompt))


a = intput()
b = intput()
c = intput()
d = intput()
e = intput()

a_str = str(a)
b_str = str(b)
c_str = str(c)
d_str = str(d)
e_str = str(e)

if (
    a_str.isnumeric()
    and b_str.isnumeric()
    and c_str.isnumeric()
    and d_str.isnumeric()
    and e_str.isnumeric()
):
    print("All values are numeric!")
else:
    print("Not all values are numeric!")
