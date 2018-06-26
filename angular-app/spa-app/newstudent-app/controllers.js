angular.module('swabhavcontroller', [])
    .controller('displayCtrl', ['$rootScope', '$scope', '$location', 'dataService', function ($rootScope, $scope, $location, dataService) {
        $scope.result;

        $scope.value = JSON.parse(localStorage.getItem("value"));
        console.log($scope.value);
        if (typeof $scope.value == 'undefined' || $scope.value == null) {
            localStorage.setItem("value", false);
        }
        $rootScope.checkLogin = function () {
            //console.log($scope.loginFlag);
            if (JSON.parse(localStorage.getItem("value"))) {
                $rootScope.userShow = true;
                $rootScope.logoutShow = true;
                $rootScope.loginShow = false;
                $rootScope.guestShow = false;
            }
            if (JSON.parse(localStorage.getItem("value")) == false) {
                $rootScope.guestShow = true;
                $rootScope.logoutShow = false;
                $rootScope.loginShow = true;
                $rootScope.userShow = false;
            }
        }
        $rootScope.checkLogin();
        console.log("inside");
        $scope.goToEdit = function (id) {
            if (JSON.parse(localStorage.getItem("value")) == false) {
                $location.path("/login/");
            }
            else
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

        console.log(JSON.parse(localStorage.getItem("value")));
        if (JSON.parse(localStorage.getItem("value")) == false) {
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
            if (JSON.parse(localStorage.getItem("value"))) {
                $scope.studObj();
                dataService.addData($scope.student).then(function (r) {
                    $location.path('/students/').replace();
                });
            };
        }
    }])
    .controller('deleteCtrl', ['$rootScope', '$scope', '$log', '$location', '$window', 'dataService', function ($rootScope, $scope, $log, $location, $window, dataService) {
        $scope.deleteStudent = function (s) {
            if (JSON.parse(localStorage.getItem("value")) == false) {
                $location.path("/login/");
            }
            if (JSON.parse(localStorage.getItem("value"))) {
                if ($window.confirm("Confirm Action?")) {
                    dataService.delStudent(s).then(function () {
                        //console.log("deleted");
                        $scope.load();
                    });
                }
            }
        }
    }]).controller('editCtrl', ['$rootScope', '$scope', '$location', '$routeParams', 'dataService', function ($rootScope, $scope, $location, $routeParams, dataService) {
        //$log.info("Inside deleteCtrl");
        $scope.roll = $routeParams.rollNo;

        dataService.getData($scope.roll).then(function (x) {
            //console.log(x.data);
            x.data.date = new Date(x.data.date);
            $scope.student = x.data;
        });

        $scope.editStudent = function () {
            dataService.editData($scope.roll, $scope.student).then(function () {
                $location.path('/students/').replace();
            });

        };
    }]).controller('loginCtrl', ['$rootScope', '$scope', '$location', 'loginService', function ($rootScope, $scope, $location, loginService) {

        $scope.checkValidation = function (user) {
            $rootScope.presentUser = $scope.student.id;
            //localStorage.setItem("user",user.id);
            //$scope.avr = JSON.parse(localStorage.getItem("user"));
            //console.log($scope.avr);
            $scope.loginFlag = loginService.login(user);
            console.log($scope.loginFlag);
            //if($scope.remember){
               // console.log("Remember is true");
                //localStorage.setItem
            //}
            if ($scope.loginFlag) {
                $location.path("/students/");
                localStorage.setItem("value", true);
            }
            if ($scope.loginFlag == false) {
                alert("Wrong UserName and Password");
            }
            $rootScope.checkLogin();
        }
    }]).controller('logoutCtrl', ['$rootScope', '$scope', '$location', function ($rootScope, $scope, $location) {
        $scope.logout = function () {
            localStorage.setItem("value", false);
            $location.path("/students/");
            $rootScope.checkLogin();
        }
    }]);