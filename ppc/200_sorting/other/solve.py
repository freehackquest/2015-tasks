#!/usr/bin/python

lines = [line.rstrip('\n') for line in open('../files/data')]

numbers = []

for line in lines:
	numbers.append(int(line))

x1 = 0 # 100 < x1 < 150 
x2 = 0 # x2 > 2000
x3 = 0 # 120 < x3 < 500
x4 = 0 # -1000 < x4 < -120
x5 = 0 # -5000 < x5 < -3000
x6 = 0 # -10 < x6 < 10
for num in numbers:
	if num > 100 and num < 150:
		x1 = x1 + 1

	if num > 2000:
		x2 = x2 + 1

	if num > 120 and num < 500:
		x3 = x3 + 1

	if num > -1000 and num < -120:
		x4 = x4 + 1

	if num > -5000 and num < -3000:
		x5 = x5 + 1

	if num > -10 and num < 10:
		x6 = x6 + 1

print("%s %s %s %s %s %s" % (x1, x2, x3, x4, x5, x6))
