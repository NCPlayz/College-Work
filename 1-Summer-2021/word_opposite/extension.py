import re
from typing import Dict, Final, Iterator, List, Match, Tuple
from urllib import request
from http.client import HTTPResponse
import random

PATH: Final[str] = "https://www.gutenberg.org/files/51155/51155-h/51155-h.htm"

pattern = re.compile(r"KEY:\s(?P<key>\w+).+\nSYN:\s(?P<syn>[\w,\s\-]+).+\nANT:\s(?P<ant>[\w,\s\-]+).+\n=")

def open_path(path: str, /) -> str:
    """Unused, since there was a self-signed cert
    in the chain during testing.
    """
    raw: HTTPResponse = request.urlopen(path, timeout=5)
    value = raw.read()
    return value.decode("utf-8")

def parse_words() -> Tuple[List[str], List[str]]:
    with open("./51155-h.txt") as f:
        text: str = f.read()

    word_groups: Iterator[Match[str]] = re.finditer(pattern, text)
    first: List[str] = []
    to: List[str] = []
    for word_group in word_groups:
        syns: List[str] = word_group.group("syn").split(',')
        ants: List[str] = word_group.group("ant").split(',')
        # avoid a key that has more antonyms than synonyms or vice versa
        max_length: int = min(len(syns), len(ants))
        for i in range(max_length):
            first.append(syns[i].strip().lower())
            to.append(ants[i].strip().lower())
    return first, to

first, to = parse_words()

map: Dict[str, str] = {item: to[index] for index, item in enumerate(first)}

def random_word(*, pop: bool = True) -> Tuple[str, str]:
    word: str = random.choice(first)
    if pop:
        # since this program will be run once, we can pop the item at runtime.
        first.pop(first.index(word))
        return word, map.pop(word)
    else:
        return word, map[word]


def main() -> None:
    score: int = 0
    exited = False

    for _ in range(10):
        word, opposite = random_word()
        word_input, opposite_input = random_word(pop=False)

        print("{0} is to {1}, as {2} is to ...".format(word, opposite, word_input))

        try:
            user_input: str = input("> ")
        except KeyboardInterrupt:
            print("Exiting!")
            exited = True
            break

        if user_input == opposite_input:
            score += 1

    if not exited:
        print("You got {0}/10 correct".format(score))


if __name__ == "__main__":
    main()
