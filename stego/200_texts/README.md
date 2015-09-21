Name:

	texts

Score:

	200

Subject:

	Stego

Description:

	RU: Как известно, в цифровой цивилизации все основные коммуникации ведутся в форме двоичных кодов. Но несовершенные биологические создания не способны к восприятию данной чистой и совершенной формы информации. Поэтому устаревшие символы ещё не вымерли. Однако всегда ли символы обозначают то, что кажется на первый взгляд? Формат флага: MIK_*
	Само задание:
	RE==b9==IE==eZ==b0==db==IF==cv==ZW==YS==bG==bB==eX==ID==dG==aF==aT==bm==az==LE==IF==dP==aG==Yd==dG==IJ==dG==aH==aW==c4==IH==Yk==YV==c/==ZW==Nj==NG==IP==Y2==b+==bn==dE==YW==aR==bm==c5==IG==ee==b1==df==cm==IF==Zn==bI==YX==Z0==P3==IC==TW==YR==eV==IP==Ym==ZY==IG==eZ==b2==dU==IG==Y0==YW==bl==IG==c+==ZV==Yf==cm==Y5==aG==IO==aW==dG==IG==c/==b3==bS==ZW==d9==aG==ZR==cn==ZU==IG==ZZ==bG==c/==ZW==Ie==

Answer:

	MIK_base64_might_contain_extra_hidden_information

Author:

	[OmCTF] Victor Pasenchuk

Solve by author:

* вроде бы обычная base64, но если присмотреться, то каждый блок содержит 1 байт вместо трёх. Один пропущен равношечками. Но 1 символ хранит 6 бит, а в каждом блоке 2 символа. Таким образом, каждый блок содержит 4 мусорных бита, которые игнорируются декодером. Склеиваем эти биты и получаем ответ.
* Flag is MIK_base64_might_contain_extra_hidden_information
