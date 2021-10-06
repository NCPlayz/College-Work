# create a function that checks if a string is a palindrome


def is_palindrome(s: str) -> bool:
    """
    Return True if the string s is a palindrome.
    """
    return s == s[::-1]
