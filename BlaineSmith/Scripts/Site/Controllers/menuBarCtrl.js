angular.module('BSsite').controller('menuBarCtrl', [
    '$scope',
    '$location',
    function ($scope, $location) {

        $scope.isActive = function (viewLocation) {
            return viewLocation === $location.path();
        };
    }]);