express = require 'express'
passport = require 'passport'
LocalStrategy = require('passport-local').Strategy
bodyParser = require 'body-parser'
cookieParser = require 'cookie-parser'
expressSession = require 'express-session'
ensureLogin = require 'connect-ensure-login'


app = do express
app.set 'view engine', 'jade'
app.use express.static '.'
app.use do cookieParser
app.use do bodyParser.json
app.use bodyParser.urlencoded extended: yes
app.use expressSession
	secret: process.env.SESSION_SECRET
	resave: yes
	saveUninitialized: yes
app.use do passport.initialize
app.use do passport.session

passport.use new LocalStrategy (user, pass, done) ->
	# Обязательно установить пароль в переменную окружения
	done null, user is 'admin' and pass is "#{process.env.ADMIN_PASS}"

passport.serializeUser (user, cb) -> cb null, user
passport.deserializeUser (user, cb) -> cb null, user

app.get '/', (req, res) ->
	res.redirect '/login'

app.get '/index',
	do ensureLogin.ensureLoggedIn
	(req, res) ->
		res.render 'index', secret: process.env.SECRET

app.route '/login'
	.get (req, res) ->
		res.render 'login'

	.post passport.authenticate 'local',
		successRedirect: '/index'
		failureRedirect: '/login'




port = process.env.PORT or 5000
server = app.listen port, ->
	console.log "Listening on port #{port}"
