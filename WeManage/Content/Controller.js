app.controller("myCntrl", function ($scope, myService) {

    $scope.LoginCheck = function () {
        var User = {
            UserName: $scope.UserName,
            Password: $scope.password
        };
        $("#divLoading").show();
        debugger;
        var getData = myService.UserLogin(User);        
        getData.then(function (msg) {
            debugger;
            if (msg.data == "0") {
                $("#divLoading").hide();
                $("#alertModal").modal('show');
                $scope.msg = "Password Incorrect !";
            }
            else if (msg.data == "-1") {
                $("#divLoading").hide();
                $("#alertModal").modal('show');
                $scope.msg = "Username Incorrect !";
            }
            else {
                uID = msg.data;
                $("#divLoading").hide();
                window.location.href = "/Home/Index";
            }
        });
        debugger;
    }

    function clearFields() {
        $scope.UserName = '';
        $scope.password = '';
    }
});