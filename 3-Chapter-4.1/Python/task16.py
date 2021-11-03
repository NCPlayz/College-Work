teams: list[list[list[str]]] = []


def store_team(players: list[list[str]]) -> None:
    teams.append(players)


def create_team():
    players: list[list[str]] = []
    for _ in range(5):
        name = input("Please enter the full name of a player: ").split(" ")
        first_name, surname = " ".join(name[:-1]), name[-1]
        players.append([first_name, surname])


def remove_players_starting_with(*phrases: str) -> None:
    new_teams = teams.copy()

    for i, team in enumerate(teams):
        for j, player in enumerate(team):
            first_name, _ = player
            if any(phrase for phrase in phrases if first_name.startswith(phrase)):
                new_teams[i].pop(j)

    global teams
    teams = new_teams


for i in range(3):
    create_team()

print(teams)
remove_players_starting_with("R", "W")
print(teams)
