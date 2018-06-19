angular.module('spa-app', ['ngRoute', 'swabhavcontroller']).config(
    ['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: 'partial/home.html',
            controller: 'homeCtrl'
        }).when('/home', {
            templateUrl: 'partial/home.html',
            controller: 'homeCtrl'
        }).when('/about', {
            templateUrl: 'partial/about.html',
            controller: 'aboutCtrl'
        }).when('/career', {
            templateUrl: 'partial/career.html',
            controller: 'careerCtrl'
        });
    }]);