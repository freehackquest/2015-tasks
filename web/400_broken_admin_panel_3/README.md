Name:

	broken_admin_panel_3

Score:

	400

Subject:

	Web

Description:

	EN: Admin completely closed access to its panel. Or not?
	RU: Админ полностью закрыл доступ к своей панели. Или нет?
	{{link to drive}}

Answer:

	fhq{ReGistRatIon_is_OPen_Really?}

Author:

	[ufologists] iseption

Solve by author:

Чекаем robots.txt, там ссылка на страницу аутификации пользователей. В исходном коде закомментирова форма регистрации.
В форме ргистрации есть чекбокс "admin", отправляем данные формы с активированным чекбоксом(внимание! при включенном
чекбоксе отправляется admin=on, я это и проверяю), перенаправляет на страницу администрирования. В куках есть параметр
flag со значение False, меняем на True. Обновляем страницу, смотрим в headers, там флаг.
