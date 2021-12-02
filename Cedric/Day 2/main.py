#part 2:

file = open('input.txt', 'r')
read = file.read().split("\n")

horizontal = 0
depth = 0
aim = 0

for line in read:
    direction = line.split(" ")[0]
    amount = line.split(" ")[1]

    if direction == 'forward':
        horizontal += int(amount)
        depth += int(amount) * aim
    elif direction == 'down':
        aim += int(amount)
    elif direction == 'up':
        aim -= int(amount)

    position = horizontal * depth

print('yeet: {}'.format(position))
