angular.module('swabhavcontroller', [])
    .controller('homeCtrl', ['$scope', '$log', function ($scope, $log) {
        $log.info("Inside HomeCtrl");
        $scope.homeData = "This is My home Page";
    }])
    .controller('aboutCtrl', ['$scope', '$log', function ($scope, $log) {
        $log.info("Inside AboutCtrl");
        $scope.aboutData = "This is My About Page";
    }])
    .controller('careerCtrl', ['$scope', '$log', function ($scope, $log) {
        $log.info("Inside CareerCtrl");
        $scope.careerData = "This is My Career Page";
    }]);