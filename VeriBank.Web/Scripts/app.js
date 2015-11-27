/// <reference path="angular.js" />
var veribankApp = angular.module('veribankApp', [
  'ngRoute',
  'veribankControllers'
]);

veribankApp.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/dashboard', {
            templateUrl: 'views/dashboard.html',
            controller: 'DashboardController'
        }).
        when('/moneytransfer', {
            templateUrl: 'views/moneytransfer.html',
            controller: 'MoneyTransferController'
        }).
        otherwise({
            redirectTo: '/dashboard'
        });
  }]);


veribankApp.service('Page', function () {
    var title = 'default';
    return {
        title: function () { return title; },
        setTitle: function (newTitle) { title = newTitle }
    };
});