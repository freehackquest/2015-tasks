Name:

	broken_admin_panel_1

Score:

	200

Subject:

	Web

Description:

	EN: Hack the admin panel!
	RU: Взломай панель администратора!
	{{link to drive}}

Answer:

	fhq{Easy_web_TasK_WAS_HEre}

Author:

	[ufologists] iseption

Solve by author:

После отправки логина пароля через форму, происходит редирект на следующую страницу.
Смотрим на url. Имеет формат host_name/board.php?token=base64(data). В data находится параметр
is_admin со значение 0. Меняем is_admin=1, кодируем в base64, генерируем новый запрос, готово!
