angular.module('BSsite', [
    'ui.bootstrap',
    'ngRoute'
])
.config(['$routeProvider', '$locationProvider',
function ($routeProvider, $locationProvider) {

    //Index is default route
    $routeProvider.when('/', {
            redirectTo: '/home'
        })
        .when('/home', {
            templateUrl: 'NewSite/Home',
            controller: 'appCtrl'
        })
        .when('/contact', {
            templateUrl: 'NewSite/Contact',
            controller: 'contactCtrl'
        })

        .when('/portfolio', {
            templateUrl: 'NewSite/Portfolio',
            controller: 'portfolioCtrl'
        })
    
        .when('/service', {
            templateUrl: 'NewSite/Service',
            controller: 'serviceCtrl'
        })

        .when('/blog', {
            templateUrl: 'NewSite/Blog',
            controller: 'blogCtrl'
        })

        .when('/portfolioSingle', {
            templateUrl: 'NewSite/PortfolioSingle',
            controller: 'portfolioCtrl'
        })

        .when('/post', {
            templateUrl: 'NewSite/SinglePost',
            controller: 'blogCtrl'
        })

        .when('/about', {
            templateUrl: 'NewSite/About',
            controller: 'aboutCtrl'
        })

         .otherwise({
             redirectTo: '/'
         });
        // Specify HTML5 mode (using the History APIs) or HashBang syntax.
        $locationProvider.html5Mode(false).hashPrefix('!');
        //$locationProvider.html5Mode(true);
}]);