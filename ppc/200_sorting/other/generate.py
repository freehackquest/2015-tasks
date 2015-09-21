#!/usr/bin/python

from random import randint

TotalAmount = 100
with open("../files/data", "w") as text_file:
	i = 0
	while i < 10000000:
		text_file.write("%s\n" % randint(-10000,10000))
		i = i + 1
