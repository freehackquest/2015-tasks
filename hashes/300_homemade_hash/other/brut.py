#!/usr/bin/env python
import os
import hashlib
import time
alphabet = "0123456789"

# millis_start = int(round(time.time() * 1000))
# print(hashlib.sha1("67198561").hexdigest())

i = 0
for a1 in alphabet:
	for a2 in alphabet:
		for a3 in alphabet:
			for a4 in alphabet:
				for a5 in alphabet:
					for a6 in alphabet:
						for a7 in alphabet:
							for a8 in alphabet:
								i = i + 1
								# if i % 100000 == 0:
									# millis = int(round(time.time() * 1000)) - millis_start
									# print "speed: %s pass / sec " % (i*1000 / millis)

								password = "" + a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8
								shash = hashlib.sha1(password).hexdigest()
								if shash == "3f0617240f6e8c5608003e4f17b69437072b1042":
									print password
