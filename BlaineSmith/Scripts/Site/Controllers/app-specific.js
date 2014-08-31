// Activates the Carousel
$('.carousel').carousel({
    interval: 5000
});

// Activates Tooltips for Social Links
$('.tooltip-social').tooltip({
    selector: "a[data-toggle=tooltip]"
});

angular.module('ui.bootstrap.carousel', ['ui.bootstrap.transition'])
    .controller('CarouselController', ['$scope', '$timeout', '$transition', '$q', function ($scope, $timeout, $transition, $q) {
    }]).directive('carousel', [function () {
    return {

    };
}]);