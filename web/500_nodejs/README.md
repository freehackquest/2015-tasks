Name:

	Node.js jedi

Score:

	500

Description:

	EN: Get access to secret information
	RU: Получить доступ к секретной информации
	URL: https://coffeeweb.herokuapp.com

	Hint 1. See in styles

Note:

	Если кто-нибудь сделает систему подсказок, которые не показываются сразу, или если никто не сможет решить, то можно добавить подсказки:
	1. В теге link что-то не так
	2. express.static в неумелых руках
	3. Нужно присмотреться к переменным окружения
	4. В несуществуещем ключе все же что-то есть

Answer:

	Ride_The_Lightning

Author:

	[keva] Nitive

Solve by author:

* По `<link src='static/...'>` понять, что исходники раздаются как статика (Или просто попытаться зайти на `site.url/package.json`)
* Перейти в `package.json` (Есть почти в любом проекте с node.js)
* Перейти в `README.md` (Об этом написанно в `package.json`)
* В `README.md` описан процесс установки и запуска. Перейти к файлу `start.sh` и `index.coffee`
* `start.sh`: Найти опечатку (`ADMIN_PAS` вместо `ADMIN_PASS`)
* `index.coffee`: понять, что в `process.env.ADMIN_PASS` undefined, и, соответственно, `"#{process.env.ADMIN_PASS} === 'undefined'"`
* Из этого несложно догадаться, что подстановка 'undefined' вместо пароля откроет доступ к админке
* Зайти в админку и получить "секретную информацию"
