var veribankControllers = angular.module('veribankControllers', []);

veribankControllers.controller('DashboardController', ['$scope', '$http',
  function ($scope, $http) {
      $http.get('api/dashboard').success(function (data) {
          $scope.message = data;
      });
  }]);

veribankControllers.controller('MoneyTransferController', ['$scope', '$http',"Page",
  function ($scope, $http, Page) {
      $http.get('api/moneytransfer').success(function (data) {
          Page.setTitle("MoneyTransfer");
          $scope.request = data;
      });
  }]);

veribankControllers.controller('HomeController', ['$scope', '$http', "Page",
  function ($scope, $http, Page) {
      $scope.Page = Page;
  }]);