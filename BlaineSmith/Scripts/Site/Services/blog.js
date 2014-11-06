angular.module('BSsite').factory('blog', [
    'webAccess',
    function (webAccess) {
        return {
            BlogPost: webAccess.Get('BlogApi')
        };
    }]);
