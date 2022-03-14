/// <reference path="../main.js" />

fillPeople.$inject = ['$http'];

function fillPeople($http) {

    return {
        getPeople: getPeople
    }

    function getPeople() {

        function onSuccess(response) {
            return response.data;
        }

        function onError(error) {
            alert(error);
        }

        return $http.get('/Home/GetUsersIncluded/').then(onSuccess).catch(onError);

    }
};

app.factory("fillPeople", fillPeople);