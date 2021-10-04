shape_type = int(input("Enter the shape type: "))

if shape_type == 1:
    length = int(input("Enter the length: "))
    print("Area of square:", length * length)
elif shape_type == 2:
    length = int(input("Enter the length: "))
    breadth = int(input("Enter the breadth: "))
    print("Area of rectangle:", length * breadth)
elif shape_type == 3:
    base = int(input("Enter the base: "))
    height = int(input("Enter the height: "))
    print("Area of triangle:", 0.5 * base * height)
elif shape_type == 4:
    radius = int(input("Enter the radius: "))
    print("Area of circle:", 3.14 * radius * radius)
else:
    print("Invalid shape type")
