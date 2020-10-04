

function ajaxCall(request, callback) {
    $.ajax({
        url: request.url,
        method: request.method,
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        dataType:'json',
        data: request.data,
        success: function (response) {
            return callback(response);
        },
        error: function (response) {
            return callback("Error");
        }
    });
}
