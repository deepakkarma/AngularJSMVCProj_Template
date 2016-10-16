(function () {
'use strict';
    app.controller('homeController', ['$scope','$http', function ($scope,$http) {
        $http.get(serviceBase + "api/Deepak/5").then(function (d) {
        $scope.TestCall = d.data;
    }, function (error) {
        console.log('Oops! Something went wrong while fetching the data.')
        console.log(error)
    });
}]);
})();