angular.module('BSsite').factory('contact', [
    'webAccess',
    function (webAccess) {
        return {
            SendContactEmail: webAccess.Get('SendEmail')
        };
    }]);
