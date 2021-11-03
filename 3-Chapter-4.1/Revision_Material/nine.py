def compare_length(string: str) -> None:
    if len(string) > 10:
        print(string + "...and I love ice cream")
    elif len(string) < 10:
        print(string + "...and I love chocolate brownies!")
    else:
        print("Goodbye")


user_string = input("Enter a phrase: ")
compare_length(user_string)
