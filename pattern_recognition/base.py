import turtle
from types import SimpleNamespace
from typing import Final

TURTLE_INSTANCE: Final[turtle.Turtle] = turtle.Turtle()
TOTAL_ANGLE: Final[int] = 360


class Petal(SimpleNamespace):
    """Represents each petal of a flower.

    Attributes
    ----------
    SIDE_LENGTH: :class:`int`
        The length of each side of the petal.
    OBTUSE_ANGLE: :class:`int`
        The angle of the obtuse side of the petal.
    ACUTE_ANGLE: :class:`int`
        The angle of the acute side of the petal.
    """

    OBTUSE_ANGLE: Final[int] = 120
    ACUTE_ANGLE: Final[int] = (TOTAL_ANGLE // 2) - OBTUSE_ANGLE
    SIDE_LENGTH: Final[int] = 50

    def _draw(self) -> None:
        """Draws the petal."""
        TURTLE_INSTANCE.bk(self.SIDE_LENGTH)
        TURTLE_INSTANCE.left(self.OBTUSE_ANGLE)
        TURTLE_INSTANCE.fd(self.SIDE_LENGTH)
        TURTLE_INSTANCE.right(self.OBTUSE_ANGLE)
        TURTLE_INSTANCE.fd(self.SIDE_LENGTH)
        TURTLE_INSTANCE.right(self.ACUTE_ANGLE)
        TURTLE_INSTANCE.fd(self.SIDE_LENGTH)

    @staticmethod
    def calculate_angle(petal_count: int) -> int:
        """Calculates the angle of each petal.

        Parameters
        ----------
        petal_count: :class:`int`
            The number of petals.

        Returns
        -------
        :class:`int`
            The angle of each petal.
        """
        return Petal.ACUTE_ANGLE - (TOTAL_ANGLE // petal_count)

    @classmethod
    def draw(cls, /, *, petal_count: int) -> None:
        """Draws a flower with the given number of petals.

        Parameters
        ----------
        petal_count: :class:`int`
            The number of petals.
        """
        self = cls()
        self._draw()


class Flower:
    """Represents a flower.

    Attributes
    ----------
    petal_count: :class:`int`
        The number of petals in the flower.
    """

    def __init__(self, /, *, petal_count: int) -> None:
        self.petal_count: int = petal_count

    def draw(self) -> None:
        """Draws the flower."""
        TURTLE_INSTANCE.pd()
        for _ in range(self.petal_count):
            Petal.draw(petal_count=self.petal_count)
            TURTLE_INSTANCE.left(Petal.calculate_angle(self.petal_count))
        TURTLE_INSTANCE.pu()


# so that the window persists.
while True:
    flower: Flower = Flower(petal_count=10)
    try:
        flower.draw()
    except KeyboardInterrupt:
        print('Exiting!')
        break
