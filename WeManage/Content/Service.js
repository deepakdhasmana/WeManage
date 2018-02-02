app.service("myService", function ($http) {
    this.UserLogin = function (User) {
        var response = $http({
            method: "post",
            url: "/Login/Index",
            data: JSON.stringify(User),
            dataType: "json"
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