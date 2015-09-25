Name:
	
	homemade_hash

Score:

	300

Subject:
	
	Hashes

Description:
	
	EN: There is hash algorithm (blocks of four bytes) and the hash. Find the password (7 characters).
	The initialization vector (b0..b3) (hex): 56 2b 0f c5
	Alignment incoming sequence: simply supplemented with zeros
	When calculating the values in the first block used initializing vector.
	When calculating in the following blocks y0 '.. y3' => b0..b4
	There may be collisions. Look for all the values.

	RU: Есть алгоритм хэш-функции (блоки по 4 байта) и хэш. Найдите пароль. (7 символов).
	Инициализирующий вектор (b0..b3) (hex): 56 2b 0f c5
	Выравнивание входящей последовательности: дополняется просто нулями
	При расчете значений в первом блоке используется инициализирующий вектор.
	При расчете в последующих блоках y0'..y3' => b0..b4
	Могут быть коллизии. Ищите все значения.
	
	For tests:
	homemade_hash("abgf") = 5CAE0C06
	homemade_hash("abgf1") = C3A8AE00
	homemade_hash("abgfssss") = D0F98C00
	homemade_hash("qwqqzwe") = DDFE9A00
	homemade_hash("arahodd") = DDFE9A00

	Alphabet: qwertyuiopasdfghjklzxcvbnm
	Hash: DDF69A00

	https://drive.google.com/open?id=0BzfPP2u0U3CsMmZKMlV1YmlfNlE

	Hint 1: only brutfource
	Hint 2: sorry this is hash has a lot of collisions
	Hint 3: use first word
	Hint 4: qqqqqqq
	qqqqqqw
	qqqqqqe
	...

	Thanks for botanlq and dize!!!!

Author:

	[keva] sea-kg

Answer:

	yqqyvqe


Solve by author:

* Brutforce by alphabet: qwertyuiopasdfghjklzxcvbnm (~ 17 hour for bruting if speed 1300000 hashes in sec)
