var login = $('#login');
var register = $('#register');
var button_login = $('#toggle-login');
var button_register = $('#toggle-register');
var box = $('.box');

$(function () {

  login.hide();
  button_login.hide();
  button_register.hide();

  button_register.click(function () {
    login.slideUp(1000);
    register.slideDown(1000);
  });
  button_login.click(function () {
    register.slideUp(1000);
    login.slideDown(1000);
  });
});