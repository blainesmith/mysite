angular.module('BSsite').controller('appCtrl', [
    '$rootScope',
    '$scope',
    '$location',
    function ($rootScope, $scope, $location) {
        $scope.model = {};

        $scope.navigateHome = function () {
            $rootScope.busy = true;
            $location.path('/home');
        };

        $scope.goToBlog = function() {
            window.location.href = "http://blog.blainesmith.net";
        }


    }]);

