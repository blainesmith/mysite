angular.module('BSsite').controller('contactCtrl', [
    '$scope', '$location', 'contact',
    function ($scope, $location, contact) {
        $scope.model = {
            email: {
                FromName: '',
                FromEmail: '',
                Subject: '',
                Body: ''
            }
        };

        $scope.contact = {}

        $scope.sendEmail = function () {
            contact.SendContactEmail.Update($scope.model.email).then(function() {
                eraseFields();
            });
        };

        function eraseFields() {
            $scope.model.email.FromName = '';
            $scope.model.email.FromEmail = '';
            $scope.model.email.Subject = '';
            $scope.model.email.Body = '';
        }

    }]);