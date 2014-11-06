angular.module('BSsite').controller('messageBoxCtrl', [
    '$scope', '$modalInstance', 'params',
    function ($scope, $modalInstance, params) {
        $scope.model = {
            icon: -1,
            boldMessage: "boldMessage",
            standardMessage: "standardMessage",
            cancel: { visible: false, color: "", text: "Cancel" },
            ok: { visible: false, color: "primary", text: "OK" },
            checkbox: { visible: false, text: "Please set checkbox text.", value: false },
            buttonCount: 0,
            width: '500'
        };

        $scope.model.buttonCount = 0;
        $scope.model.width = params.width;


        var setParamValues = function (model, params) {
            if (params !== undefined) {
                if (params.visible !== undefined) {
                    model.visible = params.visible;
                    if (model.visible) {
                        $scope.model.buttonCount++;
                    }
                }
                if (params.color !== undefined) {
                    model.color = params.color;
                }
                if (params.text !== undefined) {
                    model.text = params.text;
                }
            }
        };

        if (params !== undefined) {
            switch (params.icon) {
                case "success":
                    $scope.model.icon = 0;
                    break;
                case "info":
                    $scope.model.icon = 1;
                    break;
                case "warning":
                    $scope.model.icon = 2;
                    break;
                case "error":
                    $scope.model.icon = 3;
                    break;
                default:
                    $scope.model.icon = -1;
            }
            setParamValues($scope.model.cancel, params.cancel);
            setParamValues($scope.model.ok, params.ok);

            if ($scope.model.buttonCount > 2) {
                alert("MessageBox can only support one or two buttons!");
                throw "MessageBox can only support one or two buttons!";
            }
        }

        $scope.model.boldMessage = params.boldMessage;
        $scope.model.standardMessage = params.standardMessage;

        if (!angular.isUndefined(params.checkbox) && params.checkbox != null) {
            angular.extend($scope.model.checkbox, params.checkbox);
        }

        $scope.click = function (action) {
            if (!angular.isUndefined(params.checkbox) && params.checkbox != null) {
                $modalInstance.close({ action: action, checked: $scope.model.checkbox.value });
            } else {
                $modalInstance.close(action);
            }
        };

    }]);