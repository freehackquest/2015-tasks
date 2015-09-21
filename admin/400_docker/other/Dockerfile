FROM debian:jessie
MAINTAINER fhq <freehackquest@gmail.com>

RUN apt-get update
RUN apt-get -y install apache2
RUN apt-get -y install php5
RUN rm /var/www/html/index.html
ADD ./index.php /var/www/html/

EXPOSE 80
CMD /etc/init.d/apache2 restart && /bin/bash
