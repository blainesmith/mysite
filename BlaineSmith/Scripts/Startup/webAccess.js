SiteModule.factory('webAccess', [
    '$http',
    '$q',
    '$rootScope',
    '$window',
    '$log',
    function ($http, $q, $rootScope, $window, $log) {
    return {
        Get: function (controllerName) {
            return new WebAccess(controllerName);
        }
    };

    function WebAccess(controllerName) {
        this.GetList = function () {
            return accessWebServer(controllerName, 'GET');
        }
        this.GetById = function (id, override) {
            return accessWebServer(controllerName, 'GET', id);
        }
        this.Add = function (entity) {
            return accessWebServer(controllerName, 'PUT', entity);
        }
        this.Update = function (entity) {
            return accessWebServer(controllerName, 'POST', entity);
        }
        this.Delete = function (id) {
            return accessWebServer(controllerName, 'DELETE', id);
        }
    }

    function accessWebServer(controller, method, value) {

        var deferred = $q.defer();

        var entity = null;
        var completeUrl = "api/" + controller;

        if (angular.isString(value) || angular.isNumber(value)) {
            completeUrl += "/" + value;
        }
        else {
            // If it's not an int or string, we're going to pass it to the server
            // as data.  The server shouldn't be expecting data when there isn't any,
            // like for a get.
            entity = value;
        }
       

        $http({
            method: method,
            url: completeUrl,
            data: entity,
        }).success(function (data, status, headers, config) {
            deferred.resolve(data);
        }).error(function (data, status, headers, config) {
            var message = "";
            var title = undefined;
            if (status == 500) {
                // If the message list exists so we need to de-serialize it
                // This should be working for both the MessageList and ColumnMessageList
                if (angular.isString(data.ExceptionType) && data.ExceptionType.indexOf("MessageList") > 0) {
                    message = angular.fromJson(data.ExceptionMessage);
                } else {
                        if (angular.isString(data.ExceptionType) && data.ExceptionType.indexOf("NotAuthorized") > 0) {
                            message = "You are not Authorized to perform this operation";
                        } else {
                            if (angular.isObject(data)) {
                                if (data.ExceptionMessage) {
                                    message = data.ExceptionMessage;
                                    title = "Application Error:";
                                } else {
                                    if (data.Message) {
                                        message = "Server Request Failed with a status of: " + status + "\n\nMessage: " + data.Message + "\n\nMessageDetail: " + data.MessageDetail;
                                    } else {
                                        message = "Server Request Failed with a status of: " + status;
                                    }
                                }
                            }
                        }
                    }
                    if (message.length > 0) {
                        systemError.open(message, title);
                    }
            } else {
                if (status >= 400 && status < 600) {
                    message = "Server Request Failed with a status of: " + status + "\n\nMessage: " + data.Message + "\n\nMessageDetail: " + data.MessageDetail;
                }
                if (status != 0 && message.length < 1) {
                    message = "Unhandled error code: " + status;
                }
                if (message.length > 0) {
                    systemError.open(message, title);
                }
            }
            deferred.reject(message);
        });

        return deferred.promise;
    }
}]);