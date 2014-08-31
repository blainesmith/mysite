var SiteModule = angular.module('BSsite', [
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
            templateUrl: 'Pages/HomeConstruction',
            controller: 'appCtrl'
        })
        .when('/contact', {
            templateUrl: 'Pages/Contact',
            controller: 'contactCtrl'
        })

        .when('/portfolio', {
            templateUrl: 'Pages/Portfolio',
            controller: 'portfolioCtrl'
        })
    
        .when('/resume', {
            templateUrl: 'Pages/Resume',
            controller: 'appCtrl'
        })

        .when('/blogengine', {
            templateUrl: 'blogengine'
        })

        .when('/login', {
        templateUrl: 'Shared/Login',
        controller: 'loginCtrl'
        })

         .otherwise({
             redirectTo: '/'
         });
        // Specify HTML5 mode (using the History APIs) or HashBang syntax.
        $locationProvider.html5Mode(false).hashPrefix('!');
        //$locationProvider.html5Mode(true);
}]);