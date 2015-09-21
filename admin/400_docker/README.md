Name:

	docker

Score:

	400

Subject:
	
	Admin

Description:

	EN: Write docker file and from it take md5 - this will be the answer.
		Docker must unfold from debian. When creating an image it should be placed: apache2, php5
		Also, add index.php. At the start of dockers must run /etc/init.d/apache2 restart && /bin/bash
		Open port 80.
		To check the correctness of the decision (`sha1sum Dockerfile`): 09528e9bbd9915aa5daa54a11a41f683faa4367a

	RU: Напишите докер файл и от него возьмите md5 - это и будет ответом.
		Докер должен разворачиваться из debian. при создании образа в нем должен ставиться: apache2, php5
		Также добавьте ./index.php. При старте докера должен запускаться /etc/init.d/apache2 restart && /bin/bash
		Открыть порт 80.
		Для проверки правильности решения (`sha1sum Dockerfile`): 09528e9bbd9915aa5daa54a11a41f683faa4367a

	Hint 1: MAINTAINER fhq $lt;freehackquest@gmail.com&gt;
	Hint 2: jessie baby, only jessie!
	Hint 3: For nice watch: line break after MAINTAINER and previous EXPOSE
	Hint 4: ADD ./index.php &lt;correct target-dir&gt;/
	Hint 5: Please read about jessie + apache2 (they changed usually web-dir)
	Hint 6: use \n (not \r\n)
	Hint 7: "-y install"
	Hint 8: cat Dockerfile | wc -l
	   == 11
	Hint 9: don't forgot remove old index.html
	
	P.S.
		All questions you can send to freehackquest@gmail.com with topic "FHQ2015, Admin500, Dockerfile"

Answer:

	5ace6a87f4b1286ab321bd30d72c55ea

Author:

	[keva] sea-kg

Solve by author:

* "look other/Dockerfile"
