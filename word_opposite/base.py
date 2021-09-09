import random
from typing import Dict, List, Tuple

first: List[str] = [
    "hot",
    "summer",
    "hard",
    "dry",
    "simple",
    "light",
    "weak",
    "male",
    "sad",
    "win",
    "small",
    "ignore",
    "buy",
    "succeed",
    "reject",
    "prevent",
    "exclude",
]
to: List[str] = [
    "cold",
    "winter",
    "soft",
    "wet",
    "complex",
    "darkness",
    "strong",
    "female",
    "happy",
    "lose",
    "big",
    "pay attention",
    "sell",
    "fail",
    "accept",
    "allow",
    "include",
]

map: Dict[str, str] = {item: to[index] for index, item in enumerate(first)}


def random_word(*, pop: bool = True) -> Tuple[str, str]:
    print(first)
    word = random.choice(first)
    print(word)
    if pop:
        # since this program will be run once, we can pop the item at runtime.
        first.pop(first.index(word))
        return word, map.pop(word)
    else:
        return word, map[word]


def main() -> None:
    score: int = 0

    for _ in range(10):
        word, opposite = random_word()
        word_input, opposite_input = random_word(pop=False)

        print("{0} is to {1}, as {2} is to ...".format(word, opposite, word_input))

        try:
            user_input: str = input("> ")
        except KeyboardInterrupt:
            print("Exiting!")
            break

        if user_input == opposite_input:
            score += 1

    print("You got {0}/10 correct".format(score))


if __name__ == "__main__":
    main()
