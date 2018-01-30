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