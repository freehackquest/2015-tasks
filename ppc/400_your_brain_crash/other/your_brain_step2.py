#!/usr/bin/python

import zlib, base64

s = "eJzLzC3ILypRqMrJTNJRSEosTjUzUeDlKijKzCtRUI/MLy1yy0lMVwcA/4YMuQ=="
c = base64.b64decode(s)
d = zlib.decompress(c)

print d
