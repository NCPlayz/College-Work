import random

first = ['hot', 'summer', 'hard', 'dry', 'simple', 'light', 'weak', 'male', 'sad', 'win', 'small', 'ignore', 'buy', 'succeed', 'reject', 'prevent', 'exclude']
to = ['cold', 'winter', 'soft', 'wet', 'complex', 'darkness', 'strong', 'female', 'happy', 'lose', 'big', 'pay attention', 'sell', 'fail', 'accept', 'allow', 'include']

map = {item: to[index] for index, item in enumerate(first)}

def main():
    score = 0

    for _ in range(10):
        x_is_ = random.choice(first)
        to_y = map[x_is_]
        guess_x_is_ = random.choice(first)
        to_y_guess = map[guess_x_is_]

        print('{0} is to {1}, as {2} is to ...'.format(x_is_, to_y, to_y_guess))

        user_input = input('> ')

        if user_input == to_y_guess:
            score += 1
