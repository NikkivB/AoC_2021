file = open('input.txt', 'r')
hahafuck = file.read().split('\n')

yeet = 0
haha = 0

for i, measurement in enumerate(hahafuck):
    measurement = int(measurement)
    if measurement > yeet and i != 0:
        haha += 1
    yeet = measurement

print(haha)

yeet = 0
higher = 0

for i, measurement in enumerate(hahafuck):
    if i + 1 >= len(hahafuck) or i + 2 >= len(hahafuck): continue
    sum = int(hahafuck[i]) + int(hahafuck[i + 1]) + int(hahafuck[i + 2])
    if sum > yeet and i != 0:
        haha += 1
    yeet = sum

print(haha)
