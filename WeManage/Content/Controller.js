app.controller("myCntrl", function ($scope, myService) {
    $scope.LoginCheck = function () {
        var User = {
            UserName: $scope.UserName,
            Password: $scope.password
        };
        //$("#divLoading").show();
        var getData = myService.UserLogin(User);        
        getData.then(function (msg) {
            if (msg.data == "0") {
                //$("#divLoading").hide();
                $("#alertModal").modal('show');
                $scope.msg = "Password Incorrect !";
            }
            else if (msg.data == "-1") {
                //$("#divLoading").hide();
                $("#alertModal").modal('show');
                debugger;
                $scope.msg = "Username Incorrect !";
            }
            else {
                uID = msg.data;
                //$("#divLoading").hide();
                window.location.href = "/Home/Index";
            }
        });
    }

    function clearFields() {
        $scope.UserName = '';
        $scope.password = '';
    }    
});

app.controller("ProjetcsCtrl", function ($scope, ProjectService) {
    $scope.getProjects = function () {
        var _project = ProjectService.getAll();
        _project.then(function (response) {
            $scope.projects = response.data;
        },
        function (error) {
            console.log("Error: " + error);
        });
    }
    $scope.getProjects();
});