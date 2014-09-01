angular.module('BSsite').controller('contactCtrl', [
    '$scope',
    '$location',
    '$modal',
    function ($scope, $location, $modal) {
        $scope.model = {};

        $scope.contactForm = function () {
            var params = {
                action: "",
                emailData: {}
            };

            var contactModal = $modal.open({
                templateUrl: 'Pages/ContactForm',
                controller: 'contactCtrl.modal',
                backdrop: 'static',
                keyboard: false,
                resolve: {
                    params: function () {
                        return params;
                    }
                }
            });
            contactModal.result.then(function (returnValue) {
                //if (returnValue.action === 'Submit') {
                //    console.log("posting data....");
                //    $http.post('http://posttestserver.com/post.php?dir=jsfiddle', JSON.stringify(data)).success(function () { /*success callback*/ });
                //}
            });
        };

    }]);