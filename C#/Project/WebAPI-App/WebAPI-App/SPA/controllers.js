angular.module('customercontroller', []).controller('displayCtrl', ['$rootScope', '$scope', '$location', 'dataService',
    function ($rootScope, $scope, $location, dataService) {

        $scope.result;
        //console.log("inside");

        $scope.goToEdit = function (id) {
            $rootScope.cId = id;
                $location.path("/edit/" + id);
        };

        $scope.load = function () {
            dataService.getAllData().then(function (x) {
                //console.log(x);
                $scope.result = x.data;
            });
        };
        $scope.load();
        $scope.load();
    }]).controller('deleteCtrl', ['$rootScope', '$scope', '$log', '$location', '$window', 'dataService',
    function ($rootScope, $scope, $log, $location, $window, dataService) {

        $scope.deleteCustomer = function (s) {
            if ($window.confirm("Confirm Action?")) {
                dataService.delCustomer(s).then(function () {
                    //console.log("deleted");
                    $scope.load();
                });
            }

        }
    }]).controller('addCtrl', ['$rootScope', '$scope', '$log', '$location', 'dataService',
    function ($rootScope, $scope, $log, $location, dataService) {

        $scope.customerObj = function () {
            var CustomerId = $scope.idInput;
            var CustomerName = $scope.nameInput;
            var CustomerPassword = $scope.passwordInput;

            $scope.customer = {
                CustomerId,
                CustomerName,
                CustomerPassword,
            };
        };

        $scope.addCustomer = function () {

            $scope.customerObj();
            dataService.addData($scope.customer).then(function (r) {
                $location.path('/customers/').replace();
            });

        }
    }]).controller('editCtrl', ['$rootScope', '$scope', '$location', '$routeParams', 'dataService',
        function ($rootScope, $scope, $location, $routeParams, dataService) {

            $scope.id = $rootScope.cId;
            console.log($scope.id);
            dataService.getData($scope.id).then(function (x) {
                
                $scope.Customer = x.data;
            });

            $scope.editCustomer = function () {
                console.log($scope.Customer);
                dataService.editData( $scope.Customer).then(function () {
                    $location.path('/customers/').replace();
                });

            };
        }])