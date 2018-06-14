angular.module('moduleA',['moduleB','moduleC']).controller("InvoiceCtr",function($rootScope,$scope){
    console.log("Inside InvoiceController "+$rootScope.developer);
    $rootScope.developer="Himanshu";
    $scope.invoice={
        date: "12/02/2005",
        cost: 5000
    };
});

angular.module('moduleB',[]).controller("AddressCtr",function($rootScope,$scope){
    console.log("Inside AddressController "+$rootScope.developer);
    
    $scope.address={
        city: "Nallasopara",
        street: "1 st Road"
    };
});

angular.module('moduleC',[]).controller("OrderCtr",function($rootScope,$scope){
    console.log("Inside OrderController "+$rootScope);
    $scope.order={
        date: "12/09/2055",
        bill: 250000
    };
});