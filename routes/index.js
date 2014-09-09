var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res) {
  res.render('index', {
  	title: 'Chega de envias seus trabalhos como anexo para os clientes.. | Home',
  	page: 'home'
  });
});

/* GET sobre. */
router.get('/sobre', function(req, res) {
  res.render('about', {
  	title: 'Sobre',
  	page: 'about'
  });
});

/* GET depoimentos. */
router.get('/depoimentos', function(req, res) {
  res.render('testimonials', {
    title: 'Depoimentos',
    page: 'testimonials'
  });
});

/* GET preços. */
router.get('/precos', function(req, res) {
  res.render('price', {
    title: 'Preços',
    page: 'price'
  });
});

/* GET contato. */
router.get('/contato', function(req, res) {
  res.render('contact', {
    title: 'Contato',
    page: 'contact'
  });
});

module.exports = router;
