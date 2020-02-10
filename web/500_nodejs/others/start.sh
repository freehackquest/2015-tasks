#!/bin/bash

npm install -g coffee-script
npm install

SESSION_SECRET=$(cat /dev/urandom | tr -dc 'a-zA-Z0-9' | fold -w 32 | head -n 1) \
SECRET='Answer' \
ADMIN_PAS=$(cat /dev/urandom | tr -dc 'a-zA-Z0-9' | fold -w 32 | head -n 1) \
coffee index.coffee

