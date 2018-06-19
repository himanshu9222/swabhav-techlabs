angular.module('studentApi', []).controller("studentApiCtr", ['$scope', 'dataService', function ($scope, dataService) {

    $scope.result;


    $scope.load = function () {
        dataService.getAllData().then(function (x) {
            $scope.result = x.data;
            console.log($scope.result);
            //$scope.load();
        });
    };

    $scope.load();
    $scope.currentData;
    $scope.presentData;
    $scope.search = function () {

        console.log($scope.rollNoInput);
        dataService.getData($scope.rollNoInput).then(function (r) {
            console.log(r.data);
            $scope.currentData = r.data;
        });
    };

    $scope.deleteStudent = function (id) {
        console.log(id);
        dataService.delStudent(id).then(function () {
            console.log("deleted");
            $scope.load();
        });
    };

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
        dataService.addData($scope.student);
        $scope.rollInput = "";
        $scope.nameInput = "";
        $scope.ageInput = "";
        $scope.emailInput = "";
        $scope.dateInput = "";
        $scope.isMale = "";
        $scope.load();
    };

    $scope.updateStudent = function (x) {
        console.log(x.rollNo);
        $scope.rollInput = x.rollNo;
        $scope.presentData = $scope.rollInput;
        $scope.nameInput= x.name;
        $scope.ageInput =x.age;
        $scope.emailInput= x.email;
        $scope.dateInput =new Date(x.date);
        $scope.isMale = false;
        if(x.isMale){
            $scope.isMale = true;
        }
    }

    $scope.update = function () {
        console.log($scope.presentData);
        $scope.studObj();
        console.log($scope.rollInput);
        dataService.editData($scope.rollInput, $scope.student).then(function () {
            $scope.rollInput = "";
            $scope.nameInput = "";
            $scope.ageInput = "";
            $scope.emailInput = "";
            $scope.dateInput = "";
            $scope.isMale = "";
            $scope.load();
        });
    }

}]);

angular.module('studentApi').factory('dataService', ['$http', function ($http) {
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
        $http.post(url, data);
    }
    return obj;
}]);