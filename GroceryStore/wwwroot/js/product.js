var dataTable;


$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        type="Get",
        dataSrc: '',
        error: function (xhr, error, thrown) {
            console.log("Error: " + error);
            console.log("Thrown: " + thrown);
            console.log("Response: " + xhr.responseText);
        }
    },

        "columns": [
            { "data": "productName", "width": "15%" },
            {
                "data": 'imageUrl',
                render: function (file_id) {
                    return file_id
                        ? `<img src="${file_id}" alt="Product Image" class="img-thumbnail" width="65" />`
                        : null;
                },
                defaultContent: 'No image',
                title: 'Image',
                width:"15%"
            },
            { "data": "price", "width": "10%" },
            { "data": "quantity", "width": "10%" },
            { "data": "description", "width": "25%" },
            { "data": "category.categoryName", "width": "10%" },
            {
                "data": "productId",
                "render": function (data)
                {
                    return `
                            <div class="w-75 btn-group" role="group">
                                <a href="/admin/product/upsert?id=${data}" class="btn btn-primary bg-dark mx-2">
                                    <i class="bi bi-pencil"></i> Edit
                                </a>
                                    <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2">
                                    <i class="bi bi-trash"></i> Delete
                                </a>
                            </div>

                `},
                "width": "15%"
            }
        ]
    });
}


function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {

            $.ajax({
                url: url,
                type: 'Delete',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);

                }


            })
        }
    })
}