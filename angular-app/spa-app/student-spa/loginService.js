angular.module('swabhavcontroller').service('loginService', function () {
    var loginDetail = [{
        id: "himanshu",
        password: "123456"
    }, {
        id: "vipul",
        password: "abcd"
    }, {
        id: "pratik",
        password: "123abc"
    }];

    /*var users = {
        "himanshu": "123456",
        "vipul": "abcd",
        "pratik": "123abc"
    };*/

    var isAuthenticated = false;
    
    this.currentUser = function(user){
        return user;
    }

    this.login = function (username,password) {
        console.log("Inside user");
        for (var i = 0; i < loginDetail.length; i++) {
            if(username == loginDetail[i].id && password == loginDetail[i].password){
                localStorage.setItem("flag",true);
                isAuthenticated=true;
            };
        }
        return isAuthenticated;
    }
});


  /*
  this.login = function (user) {
        console.log("Inside user");
            if(users[user.id]==user.password){
                localStorage.setItem("flag",true);
                isAuthenticated=true;
            };
        return isAuthenticated;
  
  
  $scope.loginFlag = false;
        $scope.checkValidation = function () {
            $scope.id = $scope.student.id;
            $scope.password = $scope.student.password;
            console.log($scope.id);
            console.log($scope.password);
            //console.log($scope.loginDetail.length);
            for (var i = 0; i < $scope.loginDetail.length; i++) {
                
                if($scope.loginDetail[i].id==$scope.id && $scope.loginDetail[i].password==$scope.password){
                    $scope.loginFlag= true;
                }
                if ($scope.loginFlag) {
                    //console.log("how bc?");
                    $location.path('/students/').replace();
                }
            }
            $scope.loginFlag = false;*/