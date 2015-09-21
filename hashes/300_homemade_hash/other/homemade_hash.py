#!/usr/bin/env python
import os
import hashlib
import time

def homemade_hash(str):

	# y
	y0 = 0
	y1 = 0
	y2 = 0
	y3 = 0
	
	# init vector
	b0 = int("56", 16)
	b1 = int("2b", 16)
	b2 = int("0f", 16)
	b3 = int("c5", 16)
	
	# normalize
	chars = []
	for c in str:
		chars.append(ord(c))

	while len(chars) % 4 != 0:
		chars.append(0)

	i = 0
	imax = len(chars) / 4
	while i < imax:
		x0 = chars[i*4]
		x1 = chars[i*4 + 1]
		x2 = chars[i*4 + 2]
		x3 = chars[i*4 + 3]

		y0 = (b0 ^ x0) ^ (b1 | x1)
		y1 = (b3) ^ (b1 | x1)
		y2 = (x2) ^ (b1 | x1)
		y3 = (b2) & (b0 ^ x0) & x3
		
		b0 = y0
		b1 = y1
		b2 = y2
		b3 = y3

		i = i + 1

	return "%0.2X%0.2X%0.2X%0.2X" % (y0 , y1, y2, y3)

hash1 = "abgf"
hash2 = "abgf1"
hash3 = "abgfssss"
hash4 = "qwqqzwe"
hash5 = "arahodd"
answer = "orchard"

print (hash1 + " = " + homemade_hash(hash1))
print (hash2 + " = " + homemade_hash(hash2))
print (hash3 + " = " + homemade_hash(hash3))
print (hash4 + " = " + homemade_hash(hash4))
print (hash5 + " = " + homemade_hash(hash5))
print ("answer: " + answer + " = " + homemade_hash(answer))

alphabet = "qwertyuiopasdfghjklzxcvbnm"

i = 0
millis_start = int(round(time.time() * 1000))
for a1 in alphabet:
	for a2 in alphabet:
		for a3 in alphabet:
			for a4 in alphabet:
				for a5 in alphabet:
					for a6 in alphabet:
						for a7 in alphabet:
							i = i + 1
							if i % 100000 == 0:
								millis = int(round(time.time() * 1000)) - millis_start
								print "speed: %s pass / sec " % (i*1000 / millis)

							password = a1 + a2 + a3 + a4 + a5 + a6 + a7
							shash = homemade_hash(password)
							if shash == "DDF69A00":
								print password
								exit(0)

