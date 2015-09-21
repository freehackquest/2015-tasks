R = [x for x in range(97, 123) if chr(x) not in 'tfpeqwzgnib']

b = 0x56, 0x2B, 0x0F, 0xC5
number = 0

for x0 in R:
    for x1 in R:
        for x3 in R:

            _00 = b[0] ^ x0
            _11 = b[1] | x1
            Y0 = _00 ^ _11
            Y1 = b[3] ^ _11
            Y3 = b[2] & (_00 & x3)                

            for x4 in R:
                for x5 in R:
                    t_00 = Y0 ^ x4
                    t_11 = Y1 | x5
                    if (t_00 ^ t_11) == 0xDD and (Y3 ^ t_11) == 0xFE:
                        x6 = 0x9A ^ t_11
                        if x6 in R:
                            for x2 in R:
                                s = ''.join(map(chr, [x0, x1, x2, x3, x4, x5, x6]))
                                number += 1
                                #print(s)
print(number)
