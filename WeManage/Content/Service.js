app.service("myService", function ($http) {
    this.UserLogin = function (User) {
        var response = $http({
            method: "post",
            url: "/Login/Index",
            data: User
        });
        return response;
    }
});

app.service('ProjectService', function ($http) {
    this.getAll = function () {
        debugger;
        var response = $http({
            method: "post",
            url: "/Home/Index/1",
            dataType: "json"
        });
        return response;
    }
});