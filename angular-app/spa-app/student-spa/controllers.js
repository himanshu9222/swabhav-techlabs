angular.module('swabhavcontroller', [])
    .controller('displayCtrl', ['$rootScope', '$scope', '$location', 'dataService', function ($rootScope, $scope, $location, dataService) {
        $scope.result;


        //localStorage.setItem("flag",false);
        $scope.loginFlag = JSON.parse(localStorage.getItem("flag"));
        $rootScope.checkLogin = function () {
            if ($scope.loginFlag == false) {
                //console.log("inside");
                $rootScope.loginShow = true;
                $rootScope.logoutShow = false;
                $rootScope.guestShow = false;
            }
            if ($scope.loginFlag == true) {
                //console.log("inside");
                $rootScope.logoutShow = true;
                $rootScope.loginShow = false;
                $rootScope.guestShow = true;
            }
        }
        $rootScope.checkLogin();
        $scope.goToEdit = function (id) {
            $location.path("/edit/" + id);
        };
        $scope.load = function () {
            dataService.getAllData().then(function (x) {
                $scope.result = x.data;
            });
        };
        $scope.load();
        $scope.load();
    }])
    .controller('addCtrl', ['$rootScope', '$scope', '$log', '$location', 'dataService', function ($rootScope, $scope, $log, $location, dataService) {

        $rootScope.checkLogin();
        $scope.loginFlag = JSON.parse(localStorage.getItem("flag"));

        if ($scope.loginFlag == false) {
            $location.path("/login/");
        }

        $scope.studObj = function () {
            var rollNo = $scope.rollInput;
            var name = $scope.nameInput;
            var age = $scope.ageInput;
            var email = $scope.emailInput;
            var date = $scope.dateInput;
            var isMale = false;
            if ($scope.isMale)
                var isMale = true;

            $scope.student = {
                rollNo,
                name,
                age,
                email,
                date,
                isMale
            };
        };

        $scope.addStudent = function () {
            $scope.studObj();
            dataService.addData($scope.student).then(function (r) {
                $location.path('/students/').replace();
            });
        };
    }])
    .controller('deleteCtrl', ['$rootScope', '$scope', '$log', '$location', '$window', 'dataService', function ($rootScope, $scope, $log, $location, $window, dataService) {
        //$log.info("Inside deleteCtrl");
        $rootScope.checkLogin();
        $scope.deleteStudent = function (s) {
            $scope.loginFlag = JSON.parse(localStorage.getItem("flag"));

            if ($scope.loginFlag == false) {
                $location.path("/login/");
            }
            if ($scope.loginFlag == true) {
            if ($window.confirm("Confirm Action?")) {
                dataService.delStudent(s).then(function () {
                    //console.log("deleted");
                    $scope.load();
                });
            }}
        };
    }]).controller('editCtrl', ['$rootScope', '$scope', '$location', '$routeParams', 'dataService', function ($rootScope, $scope, $location, $routeParams, dataService) {
        //$log.info("Inside deleteCtrl");
        $rootScope.checkLogin();
        $scope.loginFlag = JSON.parse(localStorage.getItem("flag"));

        if ($scope.loginFlag == false) {
            $location.path("/login/");
        }
        $scope.roll = $routeParams.rollNo;

        dataService.getData($scope.roll).then(function (x) {
            //console.log(x.data);
            x.data.date = new Date(x.data.date);
            $scope.student = x.data;
        });

        $scope.editStudent = function () {
            $scope.loginFlag = JSON.parse(localStorage.getItem("flag"));

            if ($scope.loginFlag == false) {
                $location.path("/login/");
            }
            else {
                dataService.editData($scope.roll, $scope.student).then(function () {
                    $location.path('/students/').replace();
                });
            }
        };
    }]).controller('loginCtrl', ['$rootScope', '$scope', '$location', 'loginService', function ($rootScope, $scope, $location, loginService) {
        //console.log("Inside Login");
        $scope.checkValidation = function () {
            $scope.loginFlag = loginService.login($scope.student.id, $scope.student.password);
            if ($scope.loginFlag) {
                $location.path("/students/");
                localStorage.setItem("flag", true);
            }
        }
    }]).controller('logoutCtrl', ['$rootScope', '$scope', '$location', function ($rootScope, $scope, $location) {
        $scope.logout = function () {
            localStorage.setItem("flag", false);
            $location.path("/students/");
        }
    }]);


/*angular.module('swabhavcontroller').factory('dataService', ['$http', function ($http) {
    var url = "http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students/";
    var obj = {};
    obj.getData = function (id) {
        return $http.get(url + id);
    }

    obj.getAllData = function () {
        return $http.get(url);
    }

    obj.delStudent = function (id) {
        return $http.delete(url + id);
    }

    obj.editData = function (id, data) {
        return $http.put(url + id, data);
    }

    obj.addData = function (data) {
        return $http.post(url, data);
    }
    return obj;
}]);*/