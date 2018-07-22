angular.module('customercontroller').service('dataService', ['$http', function ($http) {
    var url = "http://localhost:52600/api/v1/techlabs/test/Customer/";
    this.getData = function (id) {
        return $http.get(url + "GetAllCustomers/" + id);
    }

    this.getAllData = function () {
        return $http.get(url + "GetAllCustomers/");
    }

    this.delCustomer = function (id) {
        return $http.delete(url + "DeleteCustomer/" + id);
    }

    this.editData = function ( data) {
        return $http.post(url + "UpdateCustomer/", data);
    }

    this.addData = function (data) {
        return $http.post(url + "AddCustomer/", data);
    }
}]);