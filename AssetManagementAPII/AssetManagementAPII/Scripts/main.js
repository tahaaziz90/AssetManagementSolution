function getData(entity) {

    var request = {
        url: baseUrl.concat(api[entity.name].get.url),
        method: api[entity.name].get.method,
        data: entity.data
    };

    ajaxCall(request, function (data) {
        var properties = dataTableProperties[entity.name];
            populateDataTable(properties, data);
    });
}

function getTreeData(entity, callback) {
    var treeData = {
        url: baseUrl.concat(api[entity.name].tree.url),
        method: api[entity.name].tree.method,
        data: entity.data
    }

    ajaxCall(treeData, function (data) {
        callback(data);
    });


};

function addData(entity, callback) {

    var request = {
        url: baseUrl.concat(api[entity.name].add.url),
        method: api[entity.name].add.method,
        data: entity.data
    }

    ajaxCall(request, function (data) {
        return callback(data);
    });

}

function deleteData(entity, callback) {

    var request = {
        url: baseUrl.concat(api[entity.name].delete.url),
        method: api[entity.name].delete.method,
        data: entity.data
    }

    ajaxCall(request, function (data) {
        return callback(data);
    });

}

function getFilter(entity, callback) {

    var request = {
        url: baseUrl.concat(api[entity.name].filter.url),
        method: api[entity.name].filter.method,
        data: entity.data
    }

    ajaxCall(request, function (data) {
        return callback(data);
    });
}

function populateDataTable(request, data) {

    $('#' + request.tableName).DataTable({
        data: data,
        columns: request.coloumns
    });
}

function populateSelectBox(filter) {
    getFilter({ name: filter.filterName, data: filter.data }, function (list) {
        var data = list;
        $('.' + filter.filterSelector).select2({
            data: data
        });
    });
}