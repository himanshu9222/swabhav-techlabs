angular.module('swabhavcontroller').service('dataService', ['$http', function ($http) {
    var url = "http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students/";
    this.getData = function (id) {
        return $http.get(url + id);
    }

    this.getAllData = function () {
        return $http.get(url);
    }

    this.delStudent = function (id) {
        return $http.delete(url + id);
    }

    this.editData = function (id, data) {
        return $http.put(url + id, data);
    }

    this.addData = function (data) {
        return $http.post(url, data);
    }
}]);