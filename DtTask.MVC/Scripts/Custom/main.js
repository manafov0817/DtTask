/// <reference path="../angular.js" />

let app = angular.module("myModule", []);

let personFunction = function ($scope, $http, fillPeople, isConfirmed ) {

    let obj = {
        name: '',
        type: '',
        letters: /^[0-9a-zA-Z]+$/,
        isUnique: true,
        tooltip: 'This is my text, do not touch!',
        isConfirmedName: false,
        isConfirmedType: false
    }

    $scope.obj = obj;

    fillPeople.getPeople().then(function (data) {
        $scope.people = data;
    });

    $scope.onKeyUpName = function () {

        function onError(error) {
            alert(error);
        }

        $http(
            {
                method: "GET",
                url: '/Home/IsUniquePerson',
                params: { name: $scope.obj.name }
            })
            .then(function (response) {
                $scope.obj.isUnique = response.data;
            }).catch(onError);

        $scope.obj.isConfirmedName = isConfirmed.checkValidName($scope.obj);

    }

    $scope.onKeyUpType = function () {
        if ($scope.obj.type != null && $scope.obj.type.length > 3) {
            $scope.types = [];
            $http(
                {
                    method: "GET",
                    url: '/Home/GetTypesByNumber',
                    params: { word: $scope.obj.type, number: 5 }
                })
                .then(onSuccess, onError);

            function onSuccess(response) {
                $scope.types = response.data;
            }

            function onError(error) {
                alert('error');
            }
        }

        $scope.obj.isConfirmedType = isConfirmed.checkValidType($scope.obj);
    }

    $scope.onSubmit = function () {

        let personS = {
            "name": $scope.obj.name,
            "personType": {
                "name": $scope.obj.type
            }
        }

        $http(
            {
                method: "POST",
                url: '/Home/AddUser',
                data: { person: personS }
            })
            .then(onSuccess, onError);

        function onSuccess(response) {
            alert(response.data == true ? "User added successfully" : "And that moment you know ...");

            fillPeople.getPeople().then(function (data) {
                $scope.people = data;
            })

            $scope.success = false;
            setTimeout(function () { $scope.success = true; }, 300);
            $scope.name = $scope.obj.type = '';
            $scope.submitForm.$setPristine();
            $scope.submitForm.$setUntouched();
        }

        function onError(error) {
            alert(error);

        }
    };

} 
 
app.controller("personController", personFunction);


