var dataTableProperties = {
    User: {
        tableName: 'userTable',
        coloumns: [
            { data: 'UserID' },
            { data: 'userName' },
            { data: 'password' },
            { data: 'firstName' },
            { data: 'lastName' },
            { data: 'Email' },
            { data: 'pin' },
            { data: 'designation' },
            { data: 'status' },
            { data: 'actions' }
        ]
    },

    Location: {
        tableName: 'locationTable',
        coloumns: [
            { data: 'Location_Code' },
            { data: 'Location_Name' },
            { data: 'Parent_ID' },
            { data: 'CreatedOn' },
            { data: 'ModifiedOn' },
            { data: 'Actions' }

        ]
    },

    Category: {
        tableName: 'categoryTable',
        coloumns: [
            { data: 'Category_Code' },
            { data: 'BranchID' },
            { data: 'Location_Code' },
            { data: 'Category_Name' },
            { data: 'Actions' }

        ]
    },

    Company: {
        tableName: 'companyTable',
        coloumns: [
            { data: 'CompanyID' },
            { data: 'Company_Code' },
            { data: 'Company_Name' },
            { data: 'Country' },
            { data: 'Contact' },
            { data: 'Status' },
            { data: 'Actions' }

        ]
    },

    Branch: {
        tableName: 'branchTable',
        coloumns: [
            { data: 'Branch_Code' },
            { data: 'CompanyID' },
            { data: 'Branch_Name' },
            { data: 'Country' },
            { data: 'Contact' },
            { data: 'Status' },
            { data: 'Actions' }

        ]
    },

    Asset: {
        tableName: 'assetTable',
        coloumns: [
            { data: 'AssetID' },
            { data: 'BranchID' },
            { data: 'Location_Code' },
            { data: 'Category_Code' },
            { data: 'PurchaseID' },
            { data: 'RFID_Tag' },
            { data: 'Barcode' },
            { data: 'CreatedOn' },
            { data: 'Actions' }


        ]
    }

};