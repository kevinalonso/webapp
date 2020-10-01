angular.module('MyApp', ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
                redirectTo: function () {
                    return '/home';
                }
            })
            .when('/home', {
                templateUrl: '/Views/Home/Index.cshtml',
                controller: 'HomeController'
            }) 
            .when('/Contact', {
                templateUrl: '/Views/Contact/Contact.cshtml',
                controller: 'ContactController'
            })
            .when('/About', {
                templateUrl: '/Views/About/About.cshtml',
                controller: 'AboutController'
            })
            .otherwise({
                templateUrl: '/Shared/Error.cshtml',
                controller: 'ErrorController'
            })

        $locationProvider.html5Mode(false).hashPrefix('!');
    })
    .controller('HomeController', function ($scope) {
        //$scope.Message = "http://www.c-sharpcorner.com/members/satyaprakash-samantaray";
    });
    .controller('ContactController', function ($scope) {
        //$scope.Message = "http://www.c-sharpcorner.com/article/introduction-to-sql-operations-studio-and-make/";
    })
    .controller('AboutController', function ($scope, $routeParams) {
        //$scope.Message = "http://www.c-sharpcorner.com/blogs/career-booster-through-c-sharp-corner" + "Of Id" + $routeParams.id;
    })
    /*.controller('ErrorController', function ($scope) {
        $scope.Message = "Page You Requested Not Found!";
    }); */