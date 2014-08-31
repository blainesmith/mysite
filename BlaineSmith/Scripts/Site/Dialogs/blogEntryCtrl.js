SiteModule.controller('blogEntryCtrl', [
    '$scope',
    '$modalInstance',
    'params',
    function ($scope, $modalInstance, params) {

        $scope.model = {
            action: params.action
        };

        $scope.emailData = {
            inputName: "",
            inputEmail: "",
            inputMessage: ""
        };

        $scope.submitForm = function () {
            $modalInstance.close({ action: 'Submit', emailData: $scope.emailData });
        };

        $scope.close = function () {
            $modalInstance.close({ action: 'Close' });
        };

    }]);