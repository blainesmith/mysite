SiteModule.directive('centerModal', function () {
    return {
        restrict: 'A',
        link: function postLink(scope, element, attrs) {
            var width = element.width() / 2;
            element.css('margin-left', "-" + width + 'px');
        }
    };
});