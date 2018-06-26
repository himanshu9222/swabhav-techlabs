angular.module('swabhavcontroller').service('loginService', function () {
    var users = {
        "himanshu": "123456",
        "vipul": "abcd",
        "pratik": "123abc"
    };

    var isAuthenticated = false;

    this.login = function (user) {
        console.log("Inside user");
            if(users[user.id] == user.password){
                currentUserName = user.id;
                isAuthenticated=true;
            };
        return isAuthenticated;
    }
});
