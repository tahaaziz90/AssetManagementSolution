
var baseUrl = 'http://localhost:50658';

var api = {
    User: {
        get: {
            url: '/api/Users/getUser?Id=' + '0',
            method: 'GET',
            data: null
        },
        add: {
            url: '/api/Users/addUser',
            method: 'POST',
            data: null
        },
        update: '',
        delete: ''
    },
    Location: {
        get: {
            url: '/api/Location/getLocationdata?LocationCode=' + '0',
            method: 'GET',
            data: null
        },
        add: {
            url: '/api/Location/addLocation',
            method: 'POST',
            data: null
        },
        filter: {
            url: '/api/Location/getLocationList',
            method: 'GET'
        },
        delete: {
            url: '/api/Location/DeleteLocation',
            mehtod: 'GET',
        },
        tree: {
            url: '/api/Location/getLocationTree',
            mehtod: 'GET',
        },
        update: '',
    },
    Category: {
        get: {
            url: '/api/Category/getCategorydata?CategoryCode=' + '0',
            method: 'GET',
            data: null
        },
        add: {
            url: '/api/Category/addCategory',
            method: 'POST',
            data: null
        },
        filter: {
            url: '/api/Category/getCategoryList',
            method: 'GET',
            data: null
        },
        update: '',
        delete: '',
        tree: {
            url: '/api/Category/getCategoryTree',
            mehtod: 'GET',
        }
    },
    Company: {
        get: {
            url: '/api/Company/getCompanydata?CompanyID=' + '0',
            method: 'GET',
            data: null
        },
        filter: {
            url: '/api/Company/getCompanyList?Id=0',
            method: 'GET',
            data: null
        },
        add: '',
        update: '',
        delete: ''
    },
    Branch: {
        get: {
            url: '/api/Branch/getBranchdata?BranchCode=' + '0',
            method: 'GET',
            data: null
        },
        filter: {
            url: '/api/Branch/getBranchList?companyId=2',
            method: 'GET',
            data:null
        },
        add: '',
        update: '',
        delete: '',
        tree: {
            url: '/api/Branch/getBranchTree',
            mehtod: 'GET',
        }
    },
    Asset: {
        get: {
            url: '/api/Assetdata/getAssetdata?AssetID=' + '0',
            method: 'GET',
            data: null
        },
        add: '',
        update: '',
        delete: ''
    },
    Country: {
        filter: {
            url: '/api/Misc/getCountryList?Id=0',
            method: 'GET',
            data: null
        }
    }
};


