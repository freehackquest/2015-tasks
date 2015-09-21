#!/usr/bin/env python
import os
import hashlib
alphabet = "4dg9uom"

# god94mug


for a1 in alphabet:
	for a2 in alphabet:
		for a3 in alphabet:
			for a4 in alphabet:
				for a5 in alphabet:
					for a6 in alphabet:
						for a7 in alphabet:
							for a8 in alphabet:
								password = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8
								shash = hashlib.md5(password).hexdigest()
								if shash == "d377e0079ee9e94fc69336a01630b041":
									print password
