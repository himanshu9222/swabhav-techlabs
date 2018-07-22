angular.module('customer-app', ['ngRoute', 'customercontroller']).config(
        ['$routeProvider', function ($routeProvider) {
            $routeProvider.when('/', {
                templateUrl: 'Templates/customers.html',
                controller: 'displayCtrl'
            }).when('/customers', {
                templateUrl: 'Templates/customers.html',
                controller: 'displayCtrl'
            }).when('/add', {
                templateUrl: 'Templates/add.html',
                controller: 'addCtrl'
            }).when('/edit/:CustomerId', {
                templateUrl: 'Templates/edit.html',
                controller: 'editCtrl'
            })
        }]);
