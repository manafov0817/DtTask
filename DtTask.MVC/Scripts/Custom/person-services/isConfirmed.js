/// <reference path="../main.js" />

function isConfirmed() {

    return {
        checkValidName: checkValidName,
        checkValidType: checkValidType
    }

    function checkValidName(obj) {
        return !(obj.name == undefined || obj.name.length < 4 || obj.name.length > 32 || !obj.name.match(obj.letters));
    }
    function checkValidType(obj) {
        return !(obj.type == undefined || obj.type.length < 4 || obj.type.length > 32 || !obj.type.match(obj.letters));
    }
}

app.factory("isConfirmed", isConfirmed);