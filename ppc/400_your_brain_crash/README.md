Name:

	your_brain_crash

Score:

	400

Subject:
	
	PPC

Description:

	char *ptr = array;

	lol 		=	--*ptr; 
	lool 		=	++*ptr; 
	loool 		=	--ptr; 
	looool 		=	++ptr; 
	loooool 	=	putchar(*ptr); 
	looooool 	=	*ptr=getchar(); 
	loooooool 	=	while (*ptr) { 
	looooooool 	=	}
	https://drive.google.com/open?id=0BzfPP2u0U3CsT2dlT2M1enFqaGc

Answer:

	YourFlag

Author:

	[life] by_sm

Solve by author:

* first repalace all "lo..l" to code:

	#include<iostream>
	#include<cstdio>

	char *ptr = new char[1024];

	int main() {
		// your code here
		....
	}

* Compile `g++ your_brain.cpp -o your_brain`
* Run `./your_brain`
* Your got python code:

	iMporT Zlib, baSe64

	s = "eJzLzC3ILypRqMrJTNJRSEosTjUzUeDlKijKzCtRUI/MLy1yy0lMVwcA/4YMuQ=="
	c = bAsE64.b64dEcoDe(s)
	d = ZliB.dEcoMpReSS(c)

* Fix python code

	#!/usr/bin/python

	import zlib, base64

	s = "eJzLzC3ILypRqMrJTNJRSEosTjUzUeDlKijKzCtRUI/MLy1yy0lMVwcA/4YMuQ=="
	c = base64.b64decode(s)
	d = zlib.decompress(c)

	print d

* Run code and get print:

	./your_brain_step2.py 
	import zlib, base64 
	print 'YourFlag'

