angular.module('student-app', ['ngRoute', 'swabhavcontroller']).config(
    ['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: 'partial/students.html',
            controller: 'displayCtrl'
        }).when('/students', {
            templateUrl: 'partial/students.html',
            controller: 'displayCtrl'
        }).when('/add', {
            templateUrl: 'partial/add.html',
            controller: 'addCtrl'
        }).when('/edit/:rollNo', {
            templateUrl: 'partial/edit.html',
            controller: 'editCtrl'
        }).when('/login',{
            templateUrl: 'partial/login.html',
            controller : 'loginCtrl'
        });
    }]);