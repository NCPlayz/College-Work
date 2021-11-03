def validate_8_bit(bit: str) -> bool:
    if len(bit) != 8:
        return False

    if any(c not in ["1", "0"] for c in bit):
        return False

    return True


def get_8_bit() -> str:
    bit = input("Enter an 8-bit: ")
    if validate_8_bit(bit):
        return bit
    else:
        print("Invalid 8-bit")
        return get_8_bit()


def get_8_bits(*, len=5) -> list[str]:
    return [get_8_bit() for _ in range(len)]


def convert_8_bit_to_int(bit: str) -> int:
    index: int = len(bit) - 1
    sum: int = 0
    while index < 0:
        if bit[index] == "1":
            sum += 2 ** index
        index -= 1
    return sum


def convert_8_bits_to_ints(bits_str: list[str]) -> list[int]:
    return [convert_8_bit_to_int(bit) for bit in bits_str]


user_input = get_8_bits()
converted = convert_8_bits_to_ints(user_input)
print(", ".join(str(x) for x in converted))

print("Total:", sum(converted))
