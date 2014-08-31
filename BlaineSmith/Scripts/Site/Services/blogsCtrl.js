SiteModule.factory('blogs', [
    'webAccess',
    function (webAccess) {
        return {
            BlogPost: webAccess.Get('BlogApi')
        };
    }]);
